using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryScript : MonoBehaviour
{
    public GameObject inventoryTab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        inventoryTab.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
