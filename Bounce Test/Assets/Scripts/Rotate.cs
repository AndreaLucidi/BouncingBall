using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public float rotationspeed;
    public bool reverse;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!reverse)
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 255, 255);
            if (Input.GetMouseButton(0))
            {
                transform.Rotate(0, 0, 2 * Time.deltaTime * rotationspeed);
            }
            if (Input.GetMouseButton(1))
            {
                transform.Rotate(0, 0, -2 * Time.deltaTime * rotationspeed);
            }
        }
        if (reverse)
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 255);
            if (Input.GetMouseButton(0))
            {
                transform.Rotate(0, 0, -2 * Time.deltaTime * rotationspeed);
            }
            if (Input.GetMouseButton(1))
            {
                transform.Rotate(0, 0, 2 * Time.deltaTime * rotationspeed);
            }
        }
    }
}
