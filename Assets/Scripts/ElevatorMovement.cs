using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMovement : MonoBehaviour {
    bool origin;
    private bool isAtOriginalPosition;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    //Variable to control if the elevator is "up" or "down" 

    void Update()
    {
        
    }
    public void ActiveElevator()
    {
        if (origin)
        {
            GetComponent<Animation>()["ElevatorMovement"].time = 0;
            GetComponent<Animation>()["Elevator"].speed = 1;
            GetComponent<Animation>().Play("Elevator");
            isAtOriginalPosition = false;
        }
        else
        {
            GetComponent<Animation>()["Elevator"].time = GetComponent<Animation>()["Elevator"].length;
            GetComponent<Animation>()["Elevator"].speed = -1;
            GetComponent<Animation>().Play("Elevator");
            isAtOriginalPosition = true;
        }
    }
}