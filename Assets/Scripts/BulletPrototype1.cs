﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPrototype1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public float maxSpeed = 25f;
    public Rigidbody2D bullet;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody2D bulletInstance = Instantiate(bullet, transform.position, Quaternion.Euler(new Vector3(0, 0, 1))) as Rigidbody2D;
            bulletInstance.velocity = - transform.up * maxSpeed;
            bulletInstance.AddForce(this.transform.right * maxSpeed);
            Physics2D.IgnoreCollision(bulletInstance.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}
