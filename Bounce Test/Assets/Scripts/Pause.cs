using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
    public GameObject pausecanvas;
    public GameObject pausebutton;
	// Use this for initialization
	void Start () {
        pausecanvas.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PauseOn()
    {
        pausecanvas.SetActive(true);
        pausebutton.SetActive(false);
        Time.timeScale = 0;
    }
    public void PauseOff()
    {
        pausecanvas.SetActive(false);
        pausebutton.SetActive(true);
        Time.timeScale = 1;
    }
}
