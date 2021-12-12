using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoundController : MonoBehaviour
{
    public GameObject scene1;
    public GameObject scene2;
    public GameObject scene3;
    public GameObject nextround;
    bool done = true;
    GameObject gonext;
    GameObject Scene1;
    GameObject Scene2;
    GameObject Scene3;

    void Start()
    {
        Scene1 = scene1;
    }
    // Update is called once per frame
    void Update()
    {
        
        if(GetComponent<Spawner>().numenemies >= 30 && done)
        {
            Debug.Log("Round ended");
            endRound();
            spawnnextrounder();
            done = false;
        }
    }
    void spawnnextrounder()
    {
        gonext = Instantiate(nextround, new Vector3(0f, -3.3f, 0f),Quaternion.identity);
        gonext.SetActive(true);
    }

    void endRound()
    {
        GetComponent<Spawner>().spawning = false;
        //Spawn Arrow pointing to exit
        //Spawn collider to next Scene
    }

    public void loadScene(int scenenum)
    {
        
        SceneManager.LoadScene("Ganaste");
         /*if(scenenum == 2)
        {
            Destroy(Scene1.gameObject);
           scene2 =  Instantiate(scene2);
            GetComponent<Spawner>().spawning = true;
            done = true;
        }
        else if(scenenum == 3)
        {
            Destroy(Scene2.gameObject);
            Scene3 = Instantiate(scene3);

            GetComponent<Spawner>().spawning = true;
            done = true;
        }
         */
    }
}
