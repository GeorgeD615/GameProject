using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController _controller;
    public PlayerCombat _playerCombat;
    public Animator _animator;

    public float _runSpeed = 30f;
    float _horizontalMove = 0f;
    bool _isJumpButtonPressed = false;

    public bool gameOver = false;
    private void Update()
    {
        if (!gameOver)
        {
            _horizontalMove = Input.GetAxisRaw("Horizontal") * _runSpeed;
            _animator.SetFloat("Speed", Math.Abs(_horizontalMove));
            if (!_controller._blockMoveAttack1 && !_controller._blockMoveAttack2 && !_controller._blockMoveAttack3 && !_controller._isBlocking)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    _isJumpButtonPressed = true;
                    _animator.SetBool("Jumping", true);
                }
            }
        }
        else
        {
            _horizontalMove = 0;
            _animator.SetFloat("Speed", Math.Abs(_horizontalMove));
        }
    }
    private void FixedUpdate()
    {
        _controller.Move(_horizontalMove * Time.fixedDeltaTime, _isJumpButtonPressed);
        _isJumpButtonPressed = false;
    }
    public void OnLanding()
    {
        _animator.SetBool("Falling", false);
        _animator.SetBool("Jumping", false);
        _animator.SetBool("Sliding", false);
    }
    public void IsFalling()
    {
        _animator.SetBool("Falling", true);
        _animator.SetBool("Jumping", false);
        _animator.SetBool("Sliding", false);
    }
    public void WallSlide()
    {
        _animator.SetBool("Sliding", true);
        _animator.SetBool("Falling", false);
        _animator.SetBool("Jumping", false);
    }
}
