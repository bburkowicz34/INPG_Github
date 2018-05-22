using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        (other.GetComponent("Rigidbody2D") as Rigidbody2D).AddForce(Vector2.up * 6, ForceMode2D.Impulse);
    }
}

