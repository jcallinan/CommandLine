using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement1 : MonoBehaviour {
    public GameObject player1;
    public GameObject wave1;
    public bool followchar1;
    private Vector2 offset1;

    // Use this for initialization
    void Start () {
        followchar1 = true;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        
    }
    void Update()
    {
        if (Input.GetKeyDown("j"))
        {
            TransitionCamera(player1);
            followchar1 = true;
        }
        if (Input.GetKeyDown("k"))
        {
            followchar1 = false;
            TransitionCamera(wave1);
        }
        if (followchar1)
        {
            offset1.x = 10;
        }
        if (!followchar1)
        {
            offset1.x = -10;
        }
    }

    public void TransitionCamera(GameObject g)
    {
        Vector3 newPos = Vector3.zero;
        newPos.x = transform.position.x + offset1.x;
        newPos.y = transform.position.y;
        newPos.z = transform.position.z-10;
        transform.position = newPos;

    }

}
