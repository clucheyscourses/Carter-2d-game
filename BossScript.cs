using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public GameObject ship;
    public GameObject boss;
    public Sprite egg_6;
    public Sprite egg_7;
    public Sprite egg_5;
    public Sprite egg_2;
    public Sprite egg_1;
    public Sprite egg_3;
    public Sprite egg_0;
    public Sprite egg_4;
    public float health = 100f;
    public Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        changeSprite();
        
    }
    void changeSprite() 
    {
        if(ship.transform.position.x >= -3 && ship.transform.position.x <= 1 && ship.transform.position.y <= 0) {
            boss.GetComponent<SpriteRenderer>().sprite = egg_6;
        }

        if(ship.transform.position.x <= -3 && ship.transform.position.x >= -20 && ship.transform.position.y <= 0) {
            boss.GetComponent<SpriteRenderer>().sprite = egg_7;
        }

        if(ship.transform.position.x >= 3 && ship.transform.position.x <= 20 && ship.transform.position.y <= 0) {
            boss.GetComponent<SpriteRenderer>().sprite = egg_5;
        }

        if(ship.transform.position.x >= -3 && ship.transform.position.x <= 1 && ship.transform.position.y >= 0) {
            boss.GetComponent<SpriteRenderer>().sprite = egg_2;
        }

        if(ship.transform.position.x <= -3 && ship.transform.position.x >= -20 && ship.transform.position.y >= 0) {
            boss.GetComponent<SpriteRenderer>().sprite = egg_1;
        }

        if(ship.transform.position.x >= 3 && ship.transform.position.x <= 20 && ship.transform.position.y >= 0) {
            boss.GetComponent<SpriteRenderer>().sprite = egg_3;
        }

        if(ship.transform.position.y >= -3 && ship.transform.position.y < 3 && ship.transform.position.x < 0) {
            boss.GetComponent<SpriteRenderer>().sprite = egg_0;
        }

        if(ship.transform.position.y >= -3 && ship.transform.position.y < 3 && ship.transform.position.x > 0) {
            boss.GetComponent<SpriteRenderer>().sprite = egg_4;
        }
    }

    
}
