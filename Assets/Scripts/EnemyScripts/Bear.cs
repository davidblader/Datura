﻿using UnityEngine;
using System.Collections;
using System;

public class Bear : Enemy {
    protected override void Initialize()
    {
        // Character attributes
        characterName = "Bear";
        maxHealth = 200.0f;
        currentHealth = 200.0f;
        attackSpeed = 5.0f;
        damage = 5.0f;
        patrolRange = 10.0f;
        chaseRange = 12.0f;
        attackRange = 5.0f;

        // Set player reference and start AI
        player = PlayerController.player;
        ChangeState(activeState);
    }
}
