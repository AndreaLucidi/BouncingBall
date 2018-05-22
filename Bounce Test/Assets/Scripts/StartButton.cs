using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartButton : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler {
    public GameObject platform;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnPointerClick(PointerEventData eventData)
    {
        platform.SetActive(false);
        this.gameObject.GetComponent<AudioSource>().Play();
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 255);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 200);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 175);
    }
}
