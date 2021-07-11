using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionTranspEfficiency : MonoBehaviour
{

    public GameObject Gem;
    public GameObject MiniGem;
    public GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnMouseDown()
    {
        if (!MiniGem.activeSelf)
        {
            Gem.SetActive(true);
        }
        else
        {
            Debug.Log("gem already collected");
            Text.SetActive(true);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
