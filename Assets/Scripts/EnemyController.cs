using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    [SerializeField]
    private float speed =0;
    [SerializeField]
   private float fireIntervel=100;
    [SerializeField]
    private float shotExpansionMultiplier=1;
    [SerializeField]
    private float numberofShots = 3;
    [SerializeField]
    private float shotDirectionDegrees=30;
    [SerializeField]
    private Vector2 shotSpeed= new Vector2(0,0);
    [SerializeField]
    private float shotKillTime = 100;
    [SerializeField]
    private float shotDelay = 5;
    [SerializeField]
    private float shotDam=5;

    private float counter=0;
    private float shotCounter=0;
    private float shotDelayCount=0;
    public GameObject shotPrefab;
    public Transform shotSpawn;
   
    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        Move();
        Emission();
    }

    private void Move()
    {
        Vector2 playerPos = transform.position;
        playerPos.x -= speed;
        transform.position = playerPos;
        
    }

    private void Emission()
    {
       if(counter<fireIntervel)
        { counter += 1;
        }else if (counter>=fireIntervel)
        {
            if(shotDelayCount<shotDelay)
            {
                shotDelayCount += 1;
            }else
            {
                shotCounter += 1;
                shotDelayCount = 0;
                Fire();
            }


            if(shotCounter<numberofShots)
            {
                
            } else { counter = 0;
                shotCounter = 0;
            }
            

            
            
           
        }

    }
    private void Fire()
    {
        


        float x = shotSpawn.transform.position.x;
        float y = shotSpawn.transform.position.y;
        float z = shotSpawn.transform.position.z; 
        GameObject Shot = Instantiate(shotPrefab, new Vector3(x,y,z), new Quaternion(0,0,shotDirectionDegrees,0)) as GameObject;
        ShotController shotContGetter = Shot.GetComponent<ShotController>();
        shotContGetter.GetShotStats(shotSpeed,shotKillTime,shotExpansionMultiplier,shotDam);
        Vector3 rotA = Shot.transform.position;
        rotA.z = shotDirectionDegrees;
        Shot.transform.Rotate(rotA);
       
}
   



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "wave")
        {
            collision.gameObject.GetComponent<WaveController>().speed -= .01f;
        }
    }

}
