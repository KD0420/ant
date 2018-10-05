using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slide : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
       

    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Ant")
        {
            other.gameObject.transform.parent = this.gameObject.transform;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ant")
        {
            other.gameObject.transform.parent = null;
        }
    }
}
