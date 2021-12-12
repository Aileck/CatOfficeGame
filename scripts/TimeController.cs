using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text countDown;
    public int TotalTime = 60;
    public int CurrentTime = 60;
    public GameObject spawner;
    float time = 1f;
    bool posible = true;

    void Start()
    {
        //spawner = GameObject.FindGameObjectWithTag("Respawn");
        posible = true;
        spawner = GameObject.FindGameObjectWithTag("Spawn");
    }


    void update()
    {
        time -= Time.deltaTime;
        if (time <= 0 && posible)
        {
            spawner = GameObject.FindGameObjectWithTag("Spawn");
            posible = false;
            
        }
        if (!posible)
        {
            countDown.text = ("Enemies: " + spawner.GetComponent<Spawner>().numenemies + "/30");
        }
    }

}
