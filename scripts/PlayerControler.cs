using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    Animator anim;
    float speed = 5;
    public GameObject wapon;

    

    public GameObject spawner;
    int maxShot = 5;
    int currentShot = 0;

    int maxHP = 3;
    public int currentHP = 3;

    bool protect = false;
    int currentProtectTime = 0;
    int totalProtectTime = 1;
    bool lagg = false;
    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        lagg = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (currentHP <= 0)
            SceneManager.LoadScene("GameOver");

        if (protect)
        {
            StartCoroutine(Protection());
          //  Debug.Log("Protecting");
            protect = false;
        }
        //Movment
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        anim.SetFloat("Horizon", horizontalInput);
        anim.SetFloat("Vertical", verticalInput);

        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, verticalInput * speed * Time.deltaTime);
        if (!lagg)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                GameObject tmpObject = Instantiate(wapon);
                tmpObject.SetActive(true);
                tmpObject.GetComponent<WeaponController>().setPosition(transform.position);
                tmpObject.GetComponent<WeaponController>().setVerticaDirection(1);
                Destroy(tmpObject, 3);

                StartCoroutine("lag");
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                GameObject tmpObject = Instantiate(wapon);
                tmpObject.SetActive(true);
                tmpObject.GetComponent<WeaponController>().setPosition(transform.position);
                tmpObject.GetComponent<WeaponController>().setVerticaDirection(-1);
                Destroy(tmpObject, 3);

                StartCoroutine("lag");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                GameObject tmpObject = Instantiate(wapon);
                tmpObject.SetActive(true);
                tmpObject.GetComponent<WeaponController>().setPosition(transform.position);
                tmpObject.GetComponent<WeaponController>().setHorizonDirection(-1);
                Destroy(tmpObject, 3);

                StartCoroutine("lag");
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                GameObject tmpObject = Instantiate(wapon);
                tmpObject.SetActive(true);
                tmpObject.GetComponent<WeaponController>().setPosition(transform.position);
                tmpObject.GetComponent<WeaponController>().setHorizonDirection(1);
                Destroy(tmpObject, 3);

                StartCoroutine("lag");
            }
        }
       
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy" && protect == false) {
            currentHP -= 1;
            protect = true;

            //Debug.Log(currentHP);
        }

    }

    IEnumerator lag()
    {
        lagg = true;
        yield return new WaitForSeconds(.2f);
        lagg = false;
    }

    public float GetHP()
    {
        return currentHP;
    }
    IEnumerator Protection()
    {

            yield return new WaitForSeconds(totalProtectTime);

    }


}