using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antmove : MonoBehaviour {
    [SerializeField] private float antSpeed;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(antSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }
}
