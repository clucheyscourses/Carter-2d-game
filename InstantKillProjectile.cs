using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantKillProjectile : MonoBehaviour
{
    public GameObject ship;
    public Vector3 shipPos;
    public GameObject instaProjectile;
    // Start is called before the first frame update
    void Start()
    {
        ship = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        shipPos = new Vector3(ship.transform.position.x, ship.transform.position.y, 0);
        transform.position = Vector3.MoveTowards(transform.position, shipPos, 3 * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Destroy(instaProjectile);
        }
}
}
