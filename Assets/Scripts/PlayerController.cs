using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D rb2d;
    private Transform playerTransform;
    private bool onGround = true; //DO NOT FORGET TO TAG GROUND
    public float fallMultiplier = 5f;
    public float lowJumpMultiplier = 4f;
    public float jumpVelocity;
    public bool isMoveable;
    // Use this for initialization
    private void Awake()
    {
    }
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
        isMoveable = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (isMoveable)
        {
            if (Input.GetAxis("Horizontal") > 0 && Input.GetButton("Horizontal"))
            {
                Vector2 playerPos = playerTransform.position;
                playerPos.x += .5f;
                playerTransform.position = playerPos;
            }

            if (Input.GetAxis("Horizontal") < 0 && Input.GetButton("Horizontal"))
            {
                Vector2 playerPos = playerTransform.position;
                playerPos.x -= .5f;
                playerTransform.position = playerPos;
            }

            if (Input.GetButton("Jump") && onGround)
            {
                Debug.Log(rb2d);
                rb2d.velocity = Vector2.up * jumpVelocity;
                onGround = false;
            }

            if (rb2d.velocity.y < 0)
            {
                Debug.Log("hit");
                rb2d.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
            }
            else if (rb2d.velocity.y > 0 && !Input.GetButton("Jump"))
            {
                Debug.Log("uh");
                rb2d.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
            }
        }

    }
        

    private void OnCollisionEnter2D(Collision2D e)
    {
        if (e.collider.tag == "Ground")
            onGround = true;
    }
}
