using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    private Transform man;
    private Transform wave;
    public bool Transition;
    // Use this for initialization
    void Start () {
        man = GameObject.FindGameObjectWithTag("Man").transform;
        wave = GameObject.FindGameObjectWithTag("Wave").transform;
        Transition = true;
    }

    // Update is called once per frame
    void Update () {
        
             if (Input.GetKeyDown("j"))
             {
               Transition = true;
             }
             if (Input.GetKeyDown("k"))
             { 
                Transition = false;
             }
        TransitionCamera();

    }


    public void TransitionCamera()
    {
        if (Transition)
        {

            Vector3 manpos = man.position;
            manpos.z = transform.position.z;
            transform.position = manpos;

        }
        if (!Transition)
        {
            try
            {
                Vector3 wavepos = wave.position;
                wavepos.z = transform.position.z;
                transform.position = wavepos;
            }
            catch (Exception ex) { }

        }
    }
}
