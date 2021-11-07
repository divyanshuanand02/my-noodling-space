using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gift_click : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Image[] pops;
    private Image pop;
    private int count=0;


    // Update is called once per frame
    void OnMouseDown()
    {
        // this object was clicked - do something
        pop = pops[count++];
        toggle();

    }
    private void Update()
    {
        if (count > 4)
        {
            count = 4;
        }
        if (count < 0)
        {
            count = 0;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
                pops[count].gameObject.SetActive(false);
                count--;
            
        }
        
    }
    public void toggle()
    {
        if (!pop.gameObject.activeSelf)
        {
            pop.gameObject.SetActive(true);
        }

    }
}
