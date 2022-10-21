# *Way of the knight*
### Прототип компьютерной игры в жанре 2D Платформер
**Технология**: Игровой движок Unity

**Язык программирования**: C#

**Платформа**: Windows

___

1.  Общие положения
    *  Жанр и целевые платформы
        +  2D Платформер
        +  Целевая платформа – Windows
    *  Игровые механики и фичи
        - [X] Передвижение (бег, прыжок, скольжение по стенам, прыжок от стены):running:
        ![movement_gif](https://github.com/GeorgeD615/GameProject/blob/main/GameplayRecording/PlayerMovement.gif?raw=true)
        - [X]  Атака в ближнем бою :facepunch:
        ![combat_gif](https://github.com/GeorgeD615/GameProject/blob/main/GameplayRecording/PlayerCombat.gif?raw=true)
        - [X]  Блокирование :raised_hand:
        ![combat_gif](https://github.com/GeorgeD615/GameProject/blob/main/GameplayRecording/PlayerBlock.gif?raw=true)
        - [X]  Сбор сокровищ (монеты, драгоценные камни и т. п.) :gem:
        ![collectables_gif](https://github.com/GeorgeD615/GameProject/blob/main/GameplayRecording/PlayerCollectables.gif?raw=true)
        - [ ]  Ловушки в окружении:bomb:
2.  Игровые сцены (игрок переходит последовательно из одной в другую)	
    - [ ]  Exposition_scene :beginner:
        +  Назначение сцены: указать конечную цель (спасти принцессу, найти сокровище, победить дракона и т. п.), обучить механикам перемещения
        + Объекты в сцене: Игрок, сокровища
        + Механики: Передвижение, сбор сокровищ
    - [ ]  Training_scene :ghost:
        +  Назначение сцены: обучить механикам ближнего боя и блокирования, познакомить с основным типом врагов
        +  Объекты в сцене: Игрок, сокровища, Противники
        +  Механики: Передвижение, сбор сокровищ, атака в ближнем бою, блокирование
    - [ ]  Main_scene :european_castle:
        +  Назначение сцены: основная сцена c противниками на проверку навыков игрока
        +  Объекты в сцене: Игрок, сокровища, Противники, ловушки в окружении
        +  Механики: Передвижение, сбор сокровищ, атака в ближнем бою, блокирование, ловушки в окружении
    - [ ]  Finale_scene :gift:
        +  Назначение сцены: сцена с вознаграждением (сокровище, принцесса и т.п.)
        +  Объекты в сцене: Игрок, …
        +  Механики: Передвижение

3.  Объекты 
    *  Player 
    *  Enemy
    *  Treasure
    *  Trap
    *  Others…
4.  Дополнительные сведения 
    *  Предполагается использование доступных ассетов в unity asset store
    *  Референсы
        +  Hollow Knight
        
        ![HK](https://cdn.cloudflare.steamstatic.com/steam/apps/367520/ss_47f3523dbea462aff2ca4bc9f605faaf80a792b2.1920x1080.jpg?t=1625363925)
        
        +  Shovel Knight
        
        ![SK](https://images.gog-statics.com/5d000816fa3165a98ad1fac7414618ba70bb934f37b8b88fc79f19e83a0eabff_product_card_v2_mobile_slider_639.jpg)
