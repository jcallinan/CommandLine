using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour {
    GameObject camera;
    GameObject waveObj;
    GameObject playerObj;

	// Use this for initialization
	void Start () {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        waveObj = GameObject.FindGameObjectWithTag("Wave");
        playerObj = GameObject.FindGameObjectWithTag("Man");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("test");
        switch (collision.gameObject.tag)
        {
            case "Wave":
                waveObj.GetComponent<WaveController>().isMoveable = false;
                playerObj.GetComponent<PlayerController>().isMoveable = true;
                camera.GetComponent<CameraMovement>().Transition = true;
                camera.GetComponent<CameraMovement>().TransitionCamera();
                this.gameObject.SetActive(false);
                break;
            case "Man":
                waveObj.GetComponent<WaveController>().isMoveable = true;
                playerObj.GetComponent<PlayerController>().isMoveable = false;
                camera.GetComponent<CameraMovement>().Transition = false;
                camera.GetComponent<CameraMovement>().TransitionCamera();
                this.gameObject.SetActive(false);

                break;
        }
        
    }
}
