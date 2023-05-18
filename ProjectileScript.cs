using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public GameObject ship;
    private float speed = 0.1f;
    private Vector2 target;
    
    // Start is called before the first frame update
    void Start()
    {
        target = new Vector2(0.0f, 0.0f);  
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(ship.transform.position, step);
    }
}
