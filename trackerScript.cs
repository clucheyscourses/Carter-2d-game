using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackerScript : MonoBehaviour
{
    public GameObject ship;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ship.transform.position;
    }
}