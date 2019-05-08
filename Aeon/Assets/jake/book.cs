using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book : MonoBehaviour
{
    
    public GameObject Card;


   


    void OnTriggerEnter()
    {
        Card.SetActive(false);
    }
}