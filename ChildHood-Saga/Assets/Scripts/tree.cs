using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour {
    public float time;
    private Animator anim;
    float nextChange = 0f;
    bool canChange = true;
    Animation animm;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextChange)
        {
            nextChange = Time.time + anim.GetCurrentAnimatorStateInfo(0).length + time;
            change();
        }
	}
    void change()
    {
        canChange = !canChange;
        anim.SetBool("tree", canChange);
    }
}
