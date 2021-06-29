using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//if random errors occur try to remove this line:
//using UnityEngine.UI;
//

public class UserMovement : MonoBehaviour
{
    public float movementSpeed;
    public float rotateSpeed;
    public float scrollSpeed;
    public GameObject playerCamera;
    public int count;
    public TMP_Text countText;

   

    //Gems
    public GameObject TransportEfficiencyGem;
    public GameObject InstructionGem;
    public GameObject EnergySupplyGem;
    public GameObject EmissionsGem;
    public GameObject CarbonRemovalGem;
    public GameObject GrowthGem;
    public GameObject BuildingsIndustryGem;
    public GameObject PlantGem;

    //Texts
    public GameObject TransportEfficiencyText;
    public GameObject InstructionText;
    //public GameObject EnergySupplyText;
    //public GameObject EmissionsText;
    //public GameObject CarbonRemovalText;
    //public GameObject GrowthText;
    //public GameObject BuildingsIndustryText;
    //public GameObject PlantText;

    //Minigems
    public GameObject TransportEfficiencyGemMini;
    public GameObject InstructionGemMini;
    public GameObject EnergySupplyGemMini;
    public GameObject EmissionsGemMini;
    public GameObject CarbonRemovalGemMini;
    public GameObject GrowthGemMini;
    public GameObject BuildingsIndustryGemMini;
    public GameObject PlantGemMini;


    public GameObject FoundGemText;
    public GameObject InventoryText;
    public GameObject ChallengeText;
    public GameObject TestText;
    

    void Start()
    {
        Debug.Log("start done");
        count = 0;
        SetCountText();


        //deactivate gems
        TransportEfficiencyGem.SetActive(false);
        //EnergySupplyGem.SetActive(false);
        //InstructionGem.SetActive(false);
        //EmissionsGem.SetActive(false);
        //CarbonRemovalGem.SetActive(false);
        //GrowthGem.SetActive(false);
        //BuildingsIndustryGem.SetActive(false);
        //PlantGem.SetActive(false);

        //deactivate mini gems
        TransportEfficiencyGemMini.SetActive(false);
        EnergySupplyGemMini.SetActive(false);
        InstructionGemMini.SetActive(false);
        EmissionsGemMini.SetActive(false);
        CarbonRemovalGemMini.SetActive(false);
        GrowthGemMini.SetActive(false);
        BuildingsIndustryGemMini.SetActive(false);
        PlantGemMini.SetActive(false);


        //deactivate texts
        TestText.SetActive(false);
        FoundGemText.SetActive(false);
        InventoryText.SetActive(false);
        ChallengeText.SetActive(false);

        TransportEfficiencyText.SetActive(false);
        InstructionText.SetActive(false);
        
    }

// Update is called once per frame
void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed * 2.5f;
        }
        else if(Input.GetKey(KeyCode.UpArrow) && ! Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * movementSpeed;
        }

        if (Input.GetMouseButton(1))
        {
            float horiztonalRotation = rotateSpeed * Input.GetAxis("Mouse X");
            this.transform.Rotate(0, horiztonalRotation, 0);

            float verticalRotation = rotateSpeed * Input.GetAxis("Mouse Y");
            playerCamera.transform.Rotate(-verticalRotation,0,0);
        }

        if (Input.mouseScrollDelta != null)
        {
            transform.position += transform.TransformDirection(Vector3.forward)*Input.mouseScrollDelta.y * Time.deltaTime * scrollSpeed * 2.5f;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        
         if (other.gameObject.CompareTag("TransportEfficiency"))
        {
            TransportEfficiencyGem.SetActive(false);
            TransportEfficiencyGemMini.SetActive(true);
            TransportEfficiencyText.SetActive(true);
            count++;
            //FoundGemText.SetActive(true);
            
        }
        else if (other.gameObject.CompareTag("Instruction"))
        {
            InstructionGem.SetActive(false);
            InstructionGemMini.SetActive(true);
            InstructionText.SetActive(true);
            count ++;
           
        }

        SetCountText();

    }

    void SetCountText()
    {
        if (count == 1)
        {
            countText.text = "\n currently, you own " + count.ToString() + " gem";
        }
        else
        {
            countText.text = "\n currently, you own " + count.ToString() + " gems";
        }
        

    }
}
