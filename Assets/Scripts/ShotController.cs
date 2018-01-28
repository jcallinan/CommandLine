using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour {
    private Vector2 speed;
    private float killTime;
    private float shotDegrees;
    [HideInInspector]
    public float shotDam;
    float count=0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        move();
        TimeOut();
        Expand();
    }
    private void move()
    {
        Vector2 playerPos = transform.position;
        playerPos += speed;
        transform.position = playerPos;
    }
    public void GetShotStats(Vector2 shotSpeed, float shotKillTime, float expansionRate, float shotDamage)
    {
        speed = shotSpeed;
        killTime = shotKillTime;
        shotDegrees = expansionRate;
        shotDam = shotDamage;

    }
    private void TimeOut()
    {
        
        if(count<killTime)
        {
            count +=1;
        }else if(count>=killTime)
        {
            Destroy(gameObject);
        }
    }
    private void Expand()
    {
       Vector3 newScale= transform.localScale;
        newScale.x += .1f*shotDegrees;
        newScale.y += .1f* shotDegrees;
        transform.localScale = newScale;
    }
}
