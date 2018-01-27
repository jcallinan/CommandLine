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
            if (Transition)
        {
            man = GameObject.FindGameObjectWithTag("Man").transform;
            Vector3 manpos = man.position;
            manpos.z = transform.position.z;
            transform.position = manpos;

        }
        if (!Transition)
        {
            try
            {
                wave = GameObject.FindGameObjectWithTag("Wave").transform;
                Vector3 wavepos = wave.position;
                wavepos.z = transform.position.z;
                transform.position = wavepos;
            }
            catch (Exception ex) { }

        }
    }


    public void TransitionCamera(GameObject g)
    {
        transform.position = g.transform.position;
    }
}
