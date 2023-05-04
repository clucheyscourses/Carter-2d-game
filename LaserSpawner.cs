using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour
{
    private Vector3 mousePos;
    public GameObject laser;
    public Transform laserTransform;
    public bool canFire;
    private float timer;
    public float timeBetweenFiring = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float rotZ   = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        if (!canFire) 
        {
            timer += Time.deltaTime;
            if (timer > timeBetweenFiring) 
            {
                canFire = true;
                timer = 0;
            }
        }


        if (Input.GetMouseButtonDown(0) &&canFire)
        {
            canFire = false;
            Instantiate(laser, laserTransform.position, Quaternion.identity);

            
        }
    }
}
