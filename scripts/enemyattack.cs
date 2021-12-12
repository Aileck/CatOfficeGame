using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack : MonoBehaviour
{
    float attacktime = 1f;
    float defaulttime = 1f;
    public GameObject wapon;
    // Start is called before the first frame update
    void Start()
    {
        attacktime = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        attacktime -= Time.deltaTime;
        if(attacktime <= 0)
        {
            startattack();
            attacktime = defaulttime;
        }
    }

    void startattack()
    {
        GameObject tmpObject = Instantiate(wapon);
        tmpObject.SetActive(true);
        tmpObject.GetComponent<WeaponController>().setPosition(transform.position);
        tmpObject.GetComponent<WeaponController>().setVerticaDirection(1);
        Destroy(tmpObject, 3);
        GameObject tmpObject2 = Instantiate(wapon);
        tmpObject2.SetActive(true);
        tmpObject2.GetComponent<WeaponController>().setPosition(transform.position);
        tmpObject2.GetComponent<WeaponController>().setHorizonDirection(1);
        Destroy(tmpObject2, 3);
        GameObject tmpObject3 = Instantiate(wapon);
        tmpObject3.SetActive(true);
        tmpObject3.GetComponent<WeaponController>().setPosition(transform.position);
        tmpObject3.GetComponent<WeaponController>().setHorizonDirection(-1);
        Destroy(tmpObject3, 3);
        GameObject tmpObject4 = Instantiate(wapon);
        tmpObject4.SetActive(true);
        tmpObject4.GetComponent<WeaponController>().setPosition(transform.position);
        tmpObject4.GetComponent<WeaponController>().setVerticaDirection(-1);
        Destroy(tmpObject4, 3);
    }
}
