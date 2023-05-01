using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterAnimation : MonoBehaviour
{
    public Animator anim;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            anim.SetBool("Bool", true);
            anim2.SetBool("Bool", true);
        }
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            anim.SetBool("Bool", true);
            anim2.SetBool("Bool", true);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow)) 
        {
            anim.SetBool("Bool", false);
            anim2.SetBool("Bool", false);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            anim3.SetBool("Bool", true);
            anim4.SetBool("Bool", true);
        }
        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            anim3.SetBool("Bool", true);
            anim4.SetBool("Bool", true);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow)) 
        {
            anim3.SetBool("Bool", false);
            anim4.SetBool("Bool", false);
        }
    }
}
