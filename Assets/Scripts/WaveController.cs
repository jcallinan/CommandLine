using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour {
    public float speed;
    public float moveSpeed;
    public float gradSpeed = 0;
    private Rigidbody2D rb2d;  
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        


    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey(KeyCode.W))
        {
            Vector2 pos = transform.position;
            Vector2 newPos = pos;
            newPos.y += .1f;
            Vector2 final = Vector2.Lerp(pos, newPos, 1);
            transform.position = final;
           
            //rb2d.AddForce(new Vector2(0, .01f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector2 pos = transform.position;
            Vector2 newPos = pos;
            newPos.y -= .1f;
            Vector2 final = Vector2.Lerp(pos, newPos, 1);
            transform.position = final;
            
            
            //rb2d.AddForce(new Vector2(0, -.01f));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Quaternion rot = transform.rotation;
            rot.z = .3f;
            transform.rotation = rot;
        }
        if (Input.GetKeyUp(KeyCode.S)) {
            Quaternion rot = transform.rotation;
            rot.z = 0;
            transform.rotation = rot;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Quaternion rot = transform.rotation;
            rot.z = -.3f;
            transform.rotation = rot;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Quaternion rot = transform.rotation;
            rot.z = 0;
            transform.rotation = rot;
        }




        Vector2 playerPos = transform.position;
        playerPos.x -= speed;
        transform.position = playerPos;
	}

}
