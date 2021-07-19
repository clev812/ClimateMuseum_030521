﻿using System.Collections;
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

    public GameObject AlreadyFoundText;
   // public GameObject tracker;
    public GameObject inventory;
    

   

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

    //Map gems
    public GameObject TransportEfficiencyGemMap;
    public GameObject InstructionGemMap;
    public GameObject EnergySupplyGemMap;
    public GameObject EmissionsGemMap;
    public GameObject CarbonRemovalGemMap;
    public GameObject GrowthGemMap;
    public GameObject BuildingsIndustryGemMap;
    public GameObject PlantGemMap;



    //count and inventory
    public int count;
    public TMP_Text countText;
    
    public GameObject ChallengeBackground;
    public Material[] materials;
    public TMP_Text challengeText;
    public Material[] gems;

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
        //ParticleSystem ps = GetComponent<ParticleSystem>();
        var lights = effect.lights;
        lights.enabled = false;
        //effect.lights.enabled = false;

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
        AlreadyFoundText.SetActive(false);
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

        float x;
        float y;
        x = (transform.position.x) / 24;
        y = (transform.position.z) / 24;
        //tracker.transform.position.Set(x, y, 0f);


    }

    void OnTriggerEnter(Collider other)
    {
        
         if (other.gameObject.CompareTag("TransportEfficiency"))
        {
            inventory.SetActive(false);
            TransportEfficiencyGem.SetActive(false);
            TransportEfficiencyGemMini.SetActive(true);
            TransportEfficiencyText.SetActive(true);
            TransportEfficiencyGemMap.GetComponent<MeshRenderer>().material = gems[2];
            count++;
            //FoundGemText.SetActive(true);   
        }
        else if (other.gameObject.CompareTag("Instruction"))
        {
            inventory.SetActive(false);
            InstructionGem.SetActive(false);
            InstructionGemMini.SetActive(true);
            InstructionText.SetActive(true);
            InstructionGemMap.GetComponent<MeshRenderer>().material = gems[1];
            count ++;
            effect.Play();
        }

        else if (other.gameObject.CompareTag("EnergySupply"))
        {
            inventory.SetActive(false);
            EnergySupplyGem.SetActive(false);
            EnergySupplyGemMini.SetActive(true);
            EnergySupplyText.SetActive(true);
            EnergySupplyGemMap.GetComponent<MeshRenderer>().material = gems[3];
            count++;
            effect.Play();
        }

        else if (other.gameObject.CompareTag("Emissions"))
        {
            inventory.SetActive(false);
            EmissionsGem.SetActive(false);
            EmissionsGemMini.SetActive(true);
            EmissionsText.SetActive(true);
            EmissionsGemMap.GetComponent<MeshRenderer>().material = gems[4];
            count++;
            effect.Play();
        }

        else if (other.gameObject.CompareTag("CarbonRemoval"))
        {
            inventory.SetActive(false);
            CarbonRemovalGem.SetActive(false);
            CarbonRemovalGemMini.SetActive(true);
            CarbonRemovalText.SetActive(true);
            CarbonRemovalGemMap.GetComponent<MeshRenderer>().material = gems[5];
            count++;
            effect.Play();
        }

        else if (other.gameObject.CompareTag("Growth"))
        {
            inventory.SetActive(false);
            GrowthGem.SetActive(false);
            GrowthGemMini.SetActive(true);
            GrowthText.SetActive(true);
            GrowthGemMap.GetComponent<MeshRenderer>().material = gems[7];
            count++;
            effect.Play();
        }

        else if (other.gameObject.CompareTag("BuildingsIndustry"))
        {
            inventory.SetActive(false);
            BuildingsIndustryGem.SetActive(false);
            BuildingsIndustryGemMini.SetActive(true);
            BuildingsIndustryText.SetActive(true);
            BuildingsIndustryGemMap.GetComponent<MeshRenderer>().material = gems[6];
            count++;
            effect.Play();
        }

        else if (other.gameObject.CompareTag("Plant"))
        {
            inventory.SetActive(false);
            PlantGem.SetActive(false);
            PlantGemMini.SetActive(true);
            PlantText.SetActive(true);
            PlantGemMap.GetComponent<MeshRenderer>().material = gems[8];
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
