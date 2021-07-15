using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackerScript : MonoBehaviour
{
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x;
        float y;
        x = (player.transform.position.x)/24;
        y = (player.transform.position.z)/24;
        this.transform.position = new Vector3(0, 0, 0f);
        
    }
}
