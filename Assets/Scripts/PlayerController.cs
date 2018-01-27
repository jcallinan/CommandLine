using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D rb2d;
    private Transform playerTransform;
    private bool onGround = true;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    public float jumpVelocity;
    // Use this for initialization
    private void Awake()
    {
    }
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 playerPos = playerTransform.position;
            playerPos.x += .1f;
            playerTransform.position = playerPos;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector2 playerPos = playerTransform.position;
            playerPos.x -= .1f;
            playerTransform.position = playerPos;
        }

        if (Input.GetKeyDown("space"))
        {
            Debug.Log(rb2d);
            rb2d.velocity = Vector2.up * jumpVelocity;
        } 

        if (rb2d.velocity.y < 0)
        {
            Debug.Log ("hit"); 
            rb2d.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb2d.velocity.y > 0 && !Input.GetKey("space"))
        {
            Debug.Log("uh");
            rb2d.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }   
    }
}
