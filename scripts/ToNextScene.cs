using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToNextScene : MonoBehaviour
{
    int scenenum = 1;
    public GameObject spawner;

    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D id)
    {
        spawner.GetComponent<RoundController>().loadScene(++scenenum);
        Destroy(this.gameObject);
    }
}
