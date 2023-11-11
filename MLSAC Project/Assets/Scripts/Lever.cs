using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] GameObject[] activate;
    bool isInRange = false;
    bool activated = false;

    private void Update()
    {
        if(isInRange && Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Animator>().Play("Activate");

            for (int i = 0; i < activate.Length; i++)
            {
                activate[i].GetComponent<Animator>().Play("Activate");
            }
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.CompareTag("Player") && activated == false)
         {
            isInRange = true;
            activated = true;
        }
    }
}
