using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Completed : MonoBehaviour {
    public GameObject completedcanvas;
    public GameObject pausebutton;
    public AudioClip victorysound;
    public GameObject gman;
	// Use this for initialization
	void Start () {
        completedcanvas.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Time.timeScale = 0;
            collision.gameObject.transform.DetachChildren();
            Destroy(collision.gameObject);
            completedcanvas.SetActive(true);
            pausebutton.SetActive(false);
            gman.GetComponent<AudioSource>().clip = victorysound;
            gman.GetComponent<AudioSource>().Play();
        }
    }
}
