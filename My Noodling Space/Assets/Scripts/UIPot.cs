using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Image;
    int flip;
    void Start()
    {
        flip = 0;
        Debug.Log("1");
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TurnOn()
    {
        if (flip == 0)
        {
            Image.SetActive(true);
            flip = 1;
        }
        else
        {
            Image.SetActive(false);
            flip = 0;
        }
    }
}
