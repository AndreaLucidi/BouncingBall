using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
    public GameObject deathcanvas;
    public GameObject deathposition;
    public Vector3 dp;
    public GameObject pausebutton;
    public AudioClip pop;
    public AudioClip laugh;
    public GameObject gman;
    // Use this for initialization
	void Start () {
        deathcanvas.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            collision.gameObject.transform.DetachChildren();
            dp = collision.gameObject.transform.position;
            Instantiate(deathposition, dp, Quaternion.identity);
            Destroy(collision.gameObject);
            deathcanvas.SetActive(true);
            pausebutton.SetActive(false);
            StartCoroutine(sound());
        }
    }
    IEnumerator sound()
    {
        gman.GetComponent<AudioSource>().clip = pop;
        gman.GetComponent<AudioSource>().Play();
        yield return new WaitForSecondsRealtime(1);
        Debug.Log("Qui");
        gman.GetComponent<AudioSource>().clip = laugh;
        gman.GetComponent<AudioSource>().Play();
        //yield return new WaitForSeconds(1);
    }

}
