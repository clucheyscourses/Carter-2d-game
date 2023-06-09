using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    private const float MAX_HEALTH = 100f;

    public float health = MAX_HEALTH;

    private Image healthBar;

    public GameObject ship;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        health = ship.GetComponent<ShipMoveScript>().playerHealth;
        healthBar.fillAmount = health / MAX_HEALTH;
    }
}
