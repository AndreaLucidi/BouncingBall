using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMan : MonoBehaviour {
    public bool death = false;
    public GameObject deathcanv;
	// Use this for initialization
	void Start () {
        deathcanv.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (death)
        {
            deathcanv.SetActive(true);
        }
	}
}
