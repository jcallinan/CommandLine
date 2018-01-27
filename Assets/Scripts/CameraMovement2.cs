using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement2 : MonoBehaviour {
    //public GameObject wave;
    //public GameObject player;
    // public bool followchar;
    // private Vector3 offsetplay;
    //private Vector3 offsetwave;
    public GameObject player;
    private Vector3 offset;

    // Use this for initialization
    void Start () {
        //offset = transform.position - player.transform.position;
        //  followchar = true;
        // offsetwave = transform.position - wave.transform.position;
        // offsetplay = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update () {
        //  if (Input.GetKeyDown("j"))
        // {
        //    
        //   followchar = true;
        //  }
        // if (Input.GetKeyDown("k"))
        // {
        //     
        //     followchar = false;
        // }

        //        if (followchar)
        //      {
        //        Debug.Log("transfrm.position: " + transform.position);
        //      Debug.Log("player.t:" + player.transform.position + offsetplay);
        //
        //    transform.position = player.transform.position + offsetplay;
        //    }
        //  if (!followchar)
        // {
        //   Debug.Log("transfrm.position: " + transform.position);
        //  Debug.Log("wave.t:"  + wave.transform.position + offsetwave);
        // transform.position = wave.transform.position + offsetwave;
        //}

        transform.position = player.transform.position + offset;
    }

}
