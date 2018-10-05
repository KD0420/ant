using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slidemove : MonoBehaviour {
    public float groundSpeed;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0.0f, 0.0f, groundSpeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0.0f, 0.0f, -groundSpeed) * Time.deltaTime;
        }
    }
}
