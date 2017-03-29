using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emeny : MonoBehaviour {
    public float speed = 4f;
    private float timer=0;
    private float moveX = 0;
    private float moveZ = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= 1.5f)
        {
            moveX = Random.Range(-1f, 1f);
            moveZ = Random.Range(-1f, 1f);
            timer = 0;
        }
        transform.Translate(new Vector3(moveX,0,moveZ)*speed*Time.deltaTime);
	}
}
