﻿using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    GameObject Player;
    EnemyAttack attack;
    public int speed;
    public float dist;

    public Transform target;
    Transform enemy;

    void Start()
    {
        enemy = this.GetComponent<Transform>();
        target = GameObject.FindWithTag("Player").transform;
    }

	// Update is called once per frame
	void Update () {
        
        AI_movement();
	}

    void AI_movement() {

        // move to player after locating it on target.position

        // player is left of enemy, move left
        if ((target.position.x+dist) <= enemy.position.x) 
        { 
            enemy.position -= enemy.right * speed * Time.deltaTime; 
        }
        // player is right of enemy, move right
        else if ((target.position.x-dist) >= enemy.position.x) 
        { 
            enemy.position += enemy.right * speed * Time.deltaTime; 
        }
    }
}

