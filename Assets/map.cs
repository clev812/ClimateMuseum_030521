using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour
{

    public GameObject mapTab;
    public GameObject inventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown()
    {
        mapTab.SetActive(true);
        gameObject.SetActive(false);
        inventory.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
