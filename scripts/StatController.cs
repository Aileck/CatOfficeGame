using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StatController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public Image HP1;
    public Image HP2;
    public Image HP3;
    float currentHP;
    float time = 1f;
    bool posible;

    void Start()
    {
       // player = GameObject.FindGameObjectWithTag("Player");
        posible = false;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            posible = true;
        }
        if (posible)
        {
            currentHP = player.GetComponent<PlayerControler>().currentHP;
            if (currentHP == 3)
            {
                HP1.enabled = true;
                HP2.enabled = true;
                HP3.enabled = true;
            }
            else if (currentHP == 2)
            {
                HP1.enabled = true;
                HP2.enabled = true;
                HP3.enabled = false;
            }
            else if (currentHP == 1)
            {
                HP1.enabled = true;
                HP2.enabled = false;
                HP3.enabled = false;
            }
            else if (currentHP == 0)
            {
                HP1.enabled = false;
                HP2.enabled = false;
                HP3.enabled = false;
            }
        }
    }
}
