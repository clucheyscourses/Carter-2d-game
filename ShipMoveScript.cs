using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMoveScript : MonoBehaviour
{
    public GameObject ship;
    public float speed = 7f;
    public float playerHealth = 100f;
    public float checkTimer;
    public bool cheat;
    // Start is called before the first frame update
    void Start()
    {
        cheat = false;
    }

    // Update is called once per frame
    void Update()
    {
        checkForMove();
        Quaternion target = Quaternion.Euler(0, 45, 0);
        Quaternion target2 = Quaternion.Euler(0, -45, 0);
        resetRotation();

        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            transform.position = transform.position + Vector3.left * speed * Time.deltaTime;
            transform.rotation = Quaternion.Slerp(transform.rotation, target, 100);
            checkTimer = 0;
        }

        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.position = transform.position + Vector3.right * speed * Time.deltaTime;
            transform.rotation = Quaternion.Slerp(transform.rotation, target2, 100);
            checkTimer = 0;
        }

        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
            checkTimer = 0;
        }

        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            transform.position = transform.position + Vector3.down * speed * Time.deltaTime;
            checkTimer = 0;
        }
        
        Vector3 mousePos = Input.mousePosition;
         mousePos.z = 0;
         Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);

         mousePos.x = mousePos.x - objectPos.x;
         mousePos.y = mousePos.y - objectPos.y;

         float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
         transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + 270));
    }
    void resetRotation() 
    {
        Quaternion target3 = Quaternion.Euler(0, 0, 0);
        if (Input.GetAxis("Horizontal") != 1 || Input.GetAxis("Horizontal") != -1) 
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, target3, 100);
        }

    }
   
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Boss") {
            playerHealth = playerHealth - 10;
        }
        if (other.tag == "InstaKill") {
            playerHealth = playerHealth - 100;   
        }
    }

    

    void checkForMove() {
        checkTimer = checkTimer + 1 * Time.deltaTime;
        if (checkTimer > 2f) {
            playerHealth = 0;
            cheat = true;
        }
    }

    
}