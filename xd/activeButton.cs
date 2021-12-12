using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeButton : MonoBehaviour
{
    Canvas parentCanvas;

    private void Start()
    {
        parentCanvas = GetComponentInParent<Canvas>();
    }
    public void DoSetActive(Canvas activeCanvas)
    {
        parentCanvas.gameObject.SetActive(false);
        activeCanvas.gameObject.SetActive(true);
    }
}
