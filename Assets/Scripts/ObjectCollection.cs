using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollection : MonoBehaviour {
    public bool gotKey;
    public bool gotCastle;
    // Use this for initialization
    void Start () {
        gotKey = false;
        gotCastle = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Key")
        {
            gotKey = true;
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.tag == "Castle" && gotKey)
        {
            gotCastle = true;
            this.gameObject.SetActive(false);
        }
    }
}
