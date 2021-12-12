using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    float waponSpeed = 10;
    float horizontalDirection = 0;
    float verticalDirection = 0;

    float counter = 0;
    float time = .0925f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            GetComponent<BoxCollider2D>().enabled = true;

        }
        transform.position = transform.position +
            new Vector3(waponSpeed * horizontalDirection * Time.deltaTime, 
                        waponSpeed * verticalDirection   * Time.deltaTime);

        counter++;

    }

    public void setPosition(Vector2 pos)
    {
        transform.position = pos;
    }

    public void setHorizonDirection(float pos)
    {
        horizontalDirection = pos;
    }

    public void setVerticaDirection(float pos)
    {
        verticalDirection = pos;
    }

    void OnCollisionEnter2D(Collision2D id)
    {
        
        Destroy(this.gameObject);
    }

}
