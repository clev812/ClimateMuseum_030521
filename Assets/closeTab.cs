using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeTab : MonoBehaviour
{
    public GameObject TextTab;
    public GameObject inventory;
   // public GameObject FoundGemTab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        //if (TextTab.activeSelf)
        //{
           
         //   TextTab.SetActive(false);
         //   FoundGemTab.SetActive(true);
        //}
        //else
        //{
            TextTab.SetActive(false);
        inventory.SetActive(true);

        //}
            
        //Debug.Log("Interaction works");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
