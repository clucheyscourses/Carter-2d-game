using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    public GameObject ship;
    public GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion flipY = Quaternion.Euler(180, 0, 0);
        Quaternion flipX = Quaternion.Euler(0, 180, 0);
        Quaternion angle = Quaternion.Euler(0, 0, -45);
        Quaternion angle2 = Quaternion.Euler(0, 0, -90);
        Quaternion angle3 = Quaternion.Euler(0, 180, 135);
        Quaternion reset = Quaternion.Euler(0, 0, 0);
        if(ship.transform.position.x >= -3 && ship.transform.position.x <= 3 && ship.transform.position.y <= 0) {
            transform.position = new Vector3(-0.05f, -1f, 0f);   
            transform.rotation = reset; 
        }
        if(ship.transform.position.x <= -3 && ship.transform.position.x >= -20 && ship.transform.position.y <= 0) { 
            transform.position = new Vector3(-0.5f, -0.7f, 0);
            transform.rotation = angle;
        }
        if(ship.transform.position.y >= -3 && ship.transform.position.y <= 3 && ship.transform.position.x <= 0) {
            transform.position = new Vector3(-0.8f, 0f, 0f);
            transform.rotation = angle2;
        }
        if(ship.transform.position.x <= -3 && ship.transform.position.x >= -20 && ship.transform.position.y >= 0) {
            transform.position = new Vector3(-0.5f, 0.64f, 0);
            transform.rotation = angle3;
        }
    }
}
