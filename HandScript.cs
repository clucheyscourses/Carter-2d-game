using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    public GameObject ship;
    public GameObject hand;
    public float timer;
    public GameObject projectile;
    public Animator anim;
     
    
    
    // Start is called before the first frame update
    void Start()
    {
    }
    
    // Update is called once per frame
    void Update()
    {
        timer = timer + 1 * Time.deltaTime;
        if (timer > 1) {
            anim.SetBool("Bool", true);
        }
        if (timer > 3.2f) {
            Instantiate(projectile);
            anim.SetBool("Bool", false);
            timer = 0;
        }
        
        if(ship.transform.position.x >= -3 && ship.transform.position.x <= 3 && ship.transform.position.y <= 0) {
            transform.position = new Vector3(-0.05f, -1f, 0f);   
            transform.rotation = Quaternion.Euler(0, 0, 0); 
        }
        if(ship.transform.position.x <= -3 && ship.transform.position.x >= -20 && ship.transform.position.y <= 3) { 
            transform.position = new Vector3(-0.5f, -0.7f, 0);
            transform.rotation = Quaternion.Euler(0, 0, -45);
        }
        if(ship.transform.position.y >= -3 && ship.transform.position.y <= 3 && ship.transform.position.x <= 0) {
            transform.position = new Vector3(-0.7f, 0f, 0f);
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        if(ship.transform.position.x <= -3 && ship.transform.position.x >= -20 && ship.transform.position.y >= 3) {
            transform.position = new Vector3(-0.5f, 0.64f, 0);
            transform.rotation = Quaternion.Euler(0, 180, 135);
        }
        if(ship.transform.position.x >= -3 && ship.transform.position.x <= 3 && ship.transform.position.y >= 0) {
            transform.position = new Vector3(-0.05f, 0.96f, 0f);   
            transform.rotation = Quaternion.Euler(180, 0, 0); 
        }
        if(ship.transform.position.x >= 3 && ship.transform.position.x <= 20 && ship.transform.position.y >= 3) {
            transform.position = new Vector3(0.5f, 0.64f, 0);
            transform.rotation = Quaternion.Euler(0, 0, 135);
        }
        if(ship.transform.position.y >= -3 && ship.transform.position.y <= 3 && ship.transform.position.x >= 0) {
            transform.position = new Vector3(0.7f, 0f, 0f);
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if(ship.transform.position.x >= 3 && ship.transform.position.x <= 20 && ship.transform.position.y <= -3) { 
            transform.position = new Vector3(0.5f, -0.7f, 0);
            transform.rotation = Quaternion.Euler(0, 0, 45);
        }
        
}
}
