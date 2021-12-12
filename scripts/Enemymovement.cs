using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    float speed = 5f;
    public GameObject player;
    Vector2 pos;
    Vector2 possign;
    float inputduration = 0;
    public GameObject Spawnerz;
 
    Animator anim;
    
    bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            
             inputduration -= Time.deltaTime;
            if (inputduration <= 0)
            {
                pos = this.transform.position - player.transform.position;
                if (Mathf.Abs(pos.x) >= Mathf.Abs(pos.y))
                {
                    
                    possign = new Vector2(Mathf.Sign(-pos.x), (float)0);
                }
                else
                {

                    possign = new Vector2((float)0, Mathf.Sign(-pos.y));
                }
                inputduration = 0.3f;
            }

            anim.SetFloat("Horizontal", possign.x);
            anim.SetFloat("Vertical", possign.y);
            transform.Translate(new Vector2(speed * Time.deltaTime * possign.x, speed * Time.deltaTime * possign.y));
            
        }
    }

    void OnCollisionEnter2D(Collision2D id)
    {
        if(id.gameObject.tag == "Weapon")
        {
            Spawnerz.GetComponent<Spawner>().deadenemies++;
            //Debug.Log("Enemy hit");
            StartCoroutine("Die");
        }
    }
    IEnumerator Die()
    {
        //die anim
        alive = false;
        
        
        yield return new WaitForSeconds(1);
        
        Destroy(this.gameObject);
    }
}
