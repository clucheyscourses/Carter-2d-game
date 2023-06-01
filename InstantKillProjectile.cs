using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantKillProjectile : MonoBehaviour
{
    private GameObject ship;
    private Vector3 shipPos;
    public GameObject instaProjectile;
    private float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        ship = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        shipPos = new Vector3(ship.transform.position.x, transform.position.y, ship.transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, shipPos, speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Destroy(instaProjectile);
        }
}
}
