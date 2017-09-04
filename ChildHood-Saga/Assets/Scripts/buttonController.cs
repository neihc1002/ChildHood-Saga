using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonController : MonoBehaviour {
    public buttonController.ButtonType button;
    private Animator anim;
    public buttonController()
    {

    }
    private void OnMouseDown()
    {
        if(button == buttonController.ButtonType.buttonTravel)
        {
            anim.SetBool("Pressed", true);
        }
        if (button == buttonController.ButtonType.buttonEscape)
        {
            anim.SetBool("Pressed", true);
        }
        if (button == buttonController.ButtonType.buttonRecall)
        {
            anim.SetBool("Pressed", true);
        }
    }
    private void OnMouseOver()
    {
        if (button == buttonController.ButtonType.buttonTravel)
        {
            anim.SetBool("Hover", true);
        }
        if (button == buttonController.ButtonType.buttonEscape)
        {
            anim.SetBool("Hover", true);
        }
        if (button == buttonController.ButtonType.buttonRecall)
        {
            anim.SetBool("Hover", true);
        }

    }
    private void OnMouseExit()
    {
        if (button == buttonController.ButtonType.buttonTravel)
        {
            anim.SetBool("Hover", false);
           
        }
        if (button == buttonController.ButtonType.buttonEscape)
        {
            anim.SetBool("Hover", false);

        }
        if (button == buttonController.ButtonType.buttonRecall)
        {
            anim.SetBool("Hover", false);

        }

    }
    private void OnMouseUp()
    {
        if (button == buttonController.ButtonType.buttonTravel)
        {
            anim.SetBool("Pressed", false);
            SceneManager.LoadScene("Main Game");
        }
        if (button == buttonController.ButtonType.buttonEscape)
        {
            anim.SetBool("Pressed", false);
            Application.Quit();
        }
        if(button == buttonController.ButtonType.buttonRecall)
        {
            anim.SetBool("Pressed", false);
        }
    }
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public enum ButtonType
    {
        buttonTravel,
        buttonEscape,
        buttonRecall
    }
}
