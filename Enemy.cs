﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour {

    public float HP = 1;
    private float chance;
    public Transform Bullet;

    public ScoreManager scoreManager;

    //movement int
    float time;
    public float moveInterval = 5;
    Vector3 dir;
    public float speed = 10;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        chance = Random.Range(0, 5000);
        if (chance <= 0)
        {
            fire();
        }
    }

    void fire()
    {
        Instantiate(Bullet, transform.position, transform.rotation);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pbullet")
        {           
            HP -= 1;
            if (HP == 0)
            {
                scoreManager.AddPoint(1);
                print("score:"+ scoreManager.currentScore);
                print("combo" + scoreManager.combo);
                Destroy(this.gameObject);
            }
        }
    }

    void SpaceInvadersMovement()
    {
        time += Time.deltaTime;
        if (time % moveInterval * 2 < moveInterval) dir = new Vector3(-1, 0, 0);
        else dir = new Vector3(1, 0, 0);
        transform.position = transform.position + dir * Time.deltaTime * speed;
    }
}
