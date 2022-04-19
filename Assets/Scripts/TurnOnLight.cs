using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnLight : MonoBehaviour
{
    public Light Light1, Light2;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "silver")
        {
            Light1.enabled = false;
            Light2.enabled = false;
        }
        else
        {
            Light1.enabled = true;
            Light2.enabled = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "silver")
        {
            Light1.enabled = true;
            Light2.enabled = true;
        }
        else
        {
            Light1.enabled = false;
            Light2.enabled = false;
        }
    }








    //[SerializeField] private Animator myLight = null;

    //[SerializeField] private bool openTrigger = false;
    //[SerializeField] private bool closeTrigger = false;

   // public void OnTriggerEnter(Collider other)
   // {




        //if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.Mouse0))
        //{

        //    Debug.Log("fdfsdfsdf");

        //    //if (openTrigger)
        //    //{
        //    //    myLight.Play("TurnOnLight", 0, 0.0f);
        //    //    gameObject.SetActive(false);
        //    //}

        //    //else if (closeTrigger)
        //    //{
        //    //    myLight.Play("TurnOffLight", 0, 0.0f);
        //    //    gameObject.SetActive(false);
        //    //}
        //}
    //}
}
