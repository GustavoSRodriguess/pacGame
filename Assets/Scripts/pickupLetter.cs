using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupLetter : MonoBehaviour
{
    public GameObject collectTextObj, intText, monster;
    public AudioSource pickupSound, ambienceLayer;
    public bool interactable;
    public static int pagesCollected;
    public Text collectText;
    public lookAtSlender slenderScript;

    void Start()
    {
        pagesCollected = 0;
    }

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }

    void Update()
    {
        if (interactable == true) 
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                
                pagesCollected = pagesCollected + 1;
                
                slenderScript.drainRate = slenderScript.drainRate + 0.5f;
                slenderScript.rechargeRate = slenderScript.rechargeRate - 0.5f;
                slenderScript.healthDamage = slenderScript.healthDamage + 1;
                slenderScript.healthRechargeRate = slenderScript.healthRechargeRate - 0.5f;
                slenderScript.audioIncreaseRate = slenderScript.audioIncreaseRate + 0.5f;
                slenderScript.audioDecreaseRate = slenderScript.audioDecreaseRate - 0.5f;

                if (monster.active == false)
                {
                    monster.SetActive(true);
                }
                collectText.text = pagesCollected + "/10 páginas";
                collectTextObj.SetActive(true);
                pickupSound.Play();

                /*
                if(pagesCollected == 1) 
                {
                    ambienceLayer.Play();
                }
                if (pagesCollected == 2)
                {
                    ambienceLayer.Play();
                }
                if (pagesCollected == 3)
                {
                    ambienceLayer.Play();
                }
                if (pagesCollected == 4)
                {
                    ambienceLayer.Play();
                }
                if (pagesCollected == 5)
                {
                    ambienceLayer.Play();
                }
                if (pagesCollected == 6)
                {
                    ambienceLayer.Play();
                }
                */

                intText.SetActive(false);
                this.gameObject.SetActive(false);
                interactable = false;

            }
        }
    }

}
