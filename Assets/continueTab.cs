using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continueTab : MonoBehaviour
{
    public GameObject TextTab;
    public GameObject ChallengeTab;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseDown()
    {
        if (TextTab.activeSelf)
        {

          TextTab.SetActive(false);
          ChallengeTab.SetActive(true);
        }
        else
        {
        TextTab.SetActive(false);
        }

        //Debug.Log("Interaction works");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
