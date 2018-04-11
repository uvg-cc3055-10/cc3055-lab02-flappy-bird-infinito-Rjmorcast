using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour {

    private float scrollingSpeed = 2f;

    void Start () {
		
	}
	
	void Update () {
        if (!GameController.instance.GameOver) { 
        transform.Translate(Vector3.left * scrollingSpeed * Time.deltaTime);
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
}
