using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    Vector3[] spawnpoint = { new Vector3(0f, -3.5f,0f), new Vector3(0f, 3.3f,0f), new Vector3(7.3f, 0f,0f), new Vector3(-7.3f, 0f,0f) };
    float Spawntime;
    float itime = 3.4f;
    public GameObject Enemy;
    public GameObject Player;
    public GameObject playerref;
    int i = 0;
    public int deadenemies = 0;
    public bool spawning = true;


    GameObject[] enemies = new GameObject [30];
    public int numenemies = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawning = true;
        playerref = Instantiate(Player, new Vector3(0f, 0f, 0f), Quaternion.identity);
        Spawntime = itime;

        numenemies = 0;
        deadenemies = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawning)
        {
            Spawntime -= Time.deltaTime;
            if (Spawntime <= 0)
            {
                Spawntime = itime;
                if (itime > 0.5f)
                {
                    itime -= 0.1f;
                }

                if (i < 30)
                {
                    enemies[i] = Instantiate(Enemy, spawnpoint[Random.Range(0, 3)], Quaternion.identity);
                    enemies[i].GetComponent<Enemymovement>().player = playerref;
                    i++;
                    numenemies++;
                }

            }
        }
    }
}
