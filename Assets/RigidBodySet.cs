﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rb : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 10f;
	private Rigidbody rbody;
	void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
		
		float moveX = inputX*moveSpeed*Time.deltaTime;
		float moveZ = inputZ*moveSpeed*Time.deltaTime;
		
		
		rbody.AddForce(moveX,0f,moveZ);
    }
}
