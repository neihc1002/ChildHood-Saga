using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour {
    public float time;
    private Animator anim;
    float nextChange = 0f;
    bool canChange = true;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextChange)
        {
            nextChange = Time.time + 15f + time;
            change();
        }
	}
    void change()
    {
        canChange = !canChange;
        anim.SetBool("tree", canChange);
    }
}
