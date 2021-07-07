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

    public ParticleSystem effect;
    

   

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
    public GameObject EnergySupplyText;
    public GameObject EmissionsText;
    public GameObject CarbonRemovalText;
    public GameObject GrowthText;
    public GameObject BuildingsIndustryText;
    public GameObject PlantText;

    //Minigems
    public GameObject TransportEfficiencyGemMini;
    public GameObject InstructionGemMini;
    public GameObject EnergySupplyGemMini;
    public GameObject EmissionsGemMini;
    public GameObject CarbonRemovalGemMini;
    public GameObject GrowthGemMini;
    public GameObject BuildingsIndustryGemMini;
    public GameObject PlantGemMini;


    //count and inventory
    public int count;
    public TMP_Text countText;
    
    public GameObject ChallengeBackground;
    public Material[] materials;
    public TMP_Text challengeText;

    public GameObject InventoryText;
    public GameObject ChallengeText;

    //random
    public GameObject FoundGemText;
    public GameObject TestText;

    void Start()
    {
        Debug.Log("start done");
        count = 0;
        SetCountText();
        SetChallengeProgress();
        SetChallengeText();

        //effect = GetComponent<ParticleSystem>();
        //effect.enableEmission = true;

        effect.Stop();

        //deactivate gems
        TransportEfficiencyGem.SetActive(false);
        EnergySupplyGem.SetActive(false);
        InstructionGem.SetActive(false);
        EmissionsGem.SetActive(false);
        CarbonRemovalGem.SetActive(false);
        GrowthGem.SetActive(false);
        BuildingsIndustryGem.SetActive(false);
        PlantGem.SetActive(false);

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
        EnergySupplyText.SetActive(false);
        EmissionsText.SetActive(false);
        CarbonRemovalText.SetActive(false);
        GrowthText.SetActive(false);
        BuildingsIndustryText.SetActive(false);
        PlantText.SetActive(false);


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
            effect.Play();
        }

        else if (other.gameObject.CompareTag("EnergySupply"))
        {
            EnergySupplyGem.SetActive(false);
            EnergySupplyGemMini.SetActive(true);
            EnergySupplyText.SetActive(true);
            count++;
            effect.Play();
        }

        else if (other.gameObject.CompareTag("Emissions"))
        {
            EmissionsGem.SetActive(false);
            EmissionsGemMini.SetActive(true);
            EmissionsText.SetActive(true);
            count++;
            effect.Play();
        }

        else if (other.gameObject.CompareTag("CarbonRemoval"))
        {
            CarbonRemovalGem.SetActive(false);
            CarbonRemovalGemMini.SetActive(true);
            CarbonRemovalText.SetActive(true);
            count++;
            effect.Play();
        }

        else if (other.gameObject.CompareTag("Growth"))
        {
            GrowthGem.SetActive(false);
            GrowthGemMini.SetActive(true);
            GrowthText.SetActive(true);
            count++;
            effect.Play();
        }

        else if (other.gameObject.CompareTag("BuildingsIndustry"))
        {
            BuildingsIndustryGem.SetActive(false);
            BuildingsIndustryGemMini.SetActive(true);
            BuildingsIndustryText.SetActive(true);
            count++;
            effect.Play();
        }

        else if (other.gameObject.CompareTag("Plant"))
        {
            PlantGem.SetActive(false);
            PlantGemMini.SetActive(true);
            PlantText.SetActive(true);
            count++;
            effect.Play();
        }


        SetCountText();
        SetChallengeProgress();
        SetChallengeText();

    }

    void SetCountText()
    {
        if (count == 1)
        {
            countText.text = "\n currently, you own " + count.ToString() + " gem";
        }
        else if (count == 8)
        {
            countText.text = "\n you found all of the gems!";
        }
        else
        {
            countText.text = "\n currently, you own " + count.ToString() + " gems";
        }

    }

    void SetChallengeProgress()
    {    
            ChallengeBackground.GetComponent<MeshRenderer>().material = materials[count];    
    }

    void SetChallengeText()
    {
        if (count == 0)
        {
            challengeText.text = "\n look for gems to safe the world!";
        }
        else if (count == 8)
        {
            challengeText.text = "\n challenge completed!";
        }
        else
        {
            challengeText.text = "\n find more gems to complete the challenge";
        }

    }
}
