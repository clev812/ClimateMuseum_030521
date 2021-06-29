using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionTranspEfficiency : MonoBehaviour
{

    public GameObject TransportEfficiencyGem;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnMouseDown()
    {
        TransportEfficiencyGem.SetActive(true);
        //Debug.Log("Interaction works");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
