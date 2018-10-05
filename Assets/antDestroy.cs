using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            Destroy(this.gameObject);//ゴールにあたったら自分が消える
        }
        if (other.gameObject.tag == "mizutamari")
        {
            Destroy(this.gameObject);　//水溜りにあたったら自分が消える
        }
    }
}
