using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body : MonoBehaviour {
    public float speed = 0.1f;
    public float edgeBounds = 10f;
    public float chanceToChangeDirection = 0.1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;


    }
}
