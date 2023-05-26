using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjScript : MonoBehaviour
{
    private Vector3 shipPos;
    public GameObject ship;
    private Rigidbody2D rb;
    public float force;
    public GameObject projectile;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 direction = shipPos - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * -8;
    }

    // Update is called once per frame
    void Update()
    {
        shipPos = ship.transform.position;
    }

    public void OnBecameInvisible() 
    {
        Destroy(projectile);
    }
    public void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Destroy(projectile);
        }
}
}