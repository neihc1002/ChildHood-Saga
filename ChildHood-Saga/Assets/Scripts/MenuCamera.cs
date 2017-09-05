using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamera : MonoBehaviour {
    public float waitsec;
    public GameObject title;
	// Use this for initialization
	void Start () {
        StartCoroutine(activeTitle());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator activeTitle()
    {
        yield return new WaitForSeconds(waitsec);
        title.SetActive(true);
    }
}
