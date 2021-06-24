using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightInteraction : MonoBehaviour
{

    public GameObject TestText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("highlight start done");
        //TestText.SetActive(true);
    }

    void OnMouseDown()
    {
        TestText.SetActive(true);
        Debug.Log("Interaction works");

        //if (!(TestText.activeSelf))
        //{
        //  TestText.SetActive(true);
        //}
        //else
        // {
        //    TestText.SetActive(false);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
