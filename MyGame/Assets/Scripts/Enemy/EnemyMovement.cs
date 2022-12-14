using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private EnemyController _controller;
    [SerializeField] private EnemyCombat _enemyCombat;
    [SerializeField] private Animator _animator;

    public float _runSpeed = 30f;
    public float _horizontalMove = 0f;

    public float _biasHurtSpeed = 6f;
    public float _biasHurt = 0.05f;
    public Vector3 _prevPosition;

    void Start()
    {
        
    }
    void Update()
    {
        HurtBias();
        switch (_controller._currentState)
        {
            case EnemyController.State.IDLE:
                IdleBehaviour();
                break;
            case EnemyController.State.COMBAT:
                CombatBehavior();
                break;
            case EnemyController.State.IDLECOMBAT:
                IdleCombatBehaviour();
                break;
            case EnemyController.State.DEATH:
                DeathBehaviour();
                break;
        }
    }
    private void FixedUpdate()
    {
        _controller.MoveToPlayer(_horizontalMove * Time.fixedDeltaTime);
    }
    private void HurtBias()
    {
        if (_enemyCombat._hurtCount > 0)
        {
            if (_playerTransform.position.x < transform.position.x)
            {
                if (_controller._lookAtRight) _controller.Flip();
                transform.position = Vector3.Lerp(transform.position, new Vector3(_prevPosition.x + _biasHurt, _prevPosition.y, _prevPosition.z), _biasHurtSpeed * Time.deltaTime);
                if (transform.position.x >= _prevPosition.x + (_biasHurt - 0.05f))
                {
                    --_enemyCombat._hurtCount;
                    if (_enemyCombat._hurtCount != 0)
                        _prevPosition = transform.position;
                }
            }
            else
            {
                if (!_controller._lookAtRight) _controller.Flip();
                transform.position = Vector3.Lerp(transform.position, new Vector3(_prevPosition.x - _biasHurt, _prevPosition.y, _prevPosition.z), _biasHurtSpeed * Time.deltaTime);
                if (transform.position.x <= _prevPosition.x - (_biasHurt - 0.05f))
                {
                    --_enemyCombat._hurtCount;
                    if (_enemyCombat._hurtCount != 0)
                        _prevPosition = transform.position;
                }
            }
        }
    }
    private void CombatBehavior()
    {
        if (Math.Abs(_playerTransform.position.x - transform.position.x) <= 1)
        {
            _horizontalMove = 0f;
        }
        else
        {
            if (_playerTransform.position.x < transform.position.x)
                _horizontalMove = (-1) * _runSpeed;
            else
                _horizontalMove = _runSpeed;
        }
        _animator.SetFloat("Speed", Math.Abs(_horizontalMove));     
    }
    private void IdleBehaviour()
    {
        _horizontalMove = 0;
        _animator.SetFloat("Speed", Math.Abs(_horizontalMove));
    }
    private void IdleCombatBehaviour()
    {
        _horizontalMove = 0;
        _animator.SetFloat("Speed", Math.Abs(_horizontalMove));
    }
    private void DeathBehaviour()
    {
        _horizontalMove = 0;
    }
}
