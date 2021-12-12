using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class History : MonoBehaviour
{
    int currentPage = 1;
    public GameObject Page1;
    public GameObject Page2;
    public GameObject Page3;
    public Button control;
    public Button contro2l;
    public Button contro3l;
    // Start is called before the first frame update
    void Start()
    {
        control.onClick.AddListener(Case1);
        contro2l.onClick.AddListener(Case2);
        contro3l.onClick.AddListener(Case1);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPage == 1) {
            control.onClick.AddListener(Case1);
            
        }
        else if(currentPage == 2)
        {
            control.onClick.AddListener(Case2);
        }
        else if (currentPage == 3)
        {
            control.onClick.AddListener(Case3);
        }
    }

    void Case1() {
        Page1.SetActive(false);
        Page2.SetActive(true);
        control.gameObject.SetActive(false);
        contro2l.gameObject.SetActive(true);
        currentPage++;
        print("Case1");
    }

    void Case2()
    {
        Page2.SetActive(false);
        Page3.SetActive(true);
        contro2l.gameObject.SetActive(false);
        contro3l.gameObject.SetActive(true);
        currentPage++;
        print("Case2");
    }
    void Case3()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
