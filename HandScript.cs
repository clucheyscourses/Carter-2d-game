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
        if(ship.transform.position.x >= -3 && ship.transform.position.x <= 1 && ship.transform.position.y <= 0) {
            transform.position = new Vector3(-0.4f, -0.8f, 0f);
            
        }
    }
}
