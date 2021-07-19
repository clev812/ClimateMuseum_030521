using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapScript : MonoBehaviour
{
    public GameObject inventoryTab;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseDown()
    {
        inventoryTab.SetActive(true);
        gameObject.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
