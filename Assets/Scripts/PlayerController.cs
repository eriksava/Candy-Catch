﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    float maxPos;


    public bool canMove = true;

    [SerializeField]
    float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(canMove){

            Move();

        }
	}

    void Move(){

        float inputX = Input.GetAxis("Horizontal");

        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;

        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);

        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }
}
