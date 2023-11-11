using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundButton : MonoBehaviour
{
    [SerializeField] GameObject[] activate;
    bool activated = false;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Animator>().Play("Activate");

        if (collision.gameObject.CompareTag("Player") && activated == false)
        {
            for(int i=0; i < activate.Length; i++)
            {
                activate[i].GetComponent<Animator>().Play("Activate");
            }
        }

        activated = true;
    }
}
