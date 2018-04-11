using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

    public float scrollingSpeed = 5f;
   public GameObject rb;

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
    if (!GameController.instance.GameOver) { 
            rb.transform.Translate(new Vector3(-1, 0,0) * scrollingSpeed * Time.deltaTime);
            if (transform.position.x < -20f)
            {
                transform.position = new Vector3(20f, transform.position.y, transform.position.z);
            }

        }
    }
}
