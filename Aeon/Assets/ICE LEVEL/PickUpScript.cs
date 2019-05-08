using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{

    public GameObject Card;





    void OnTriggerEnter()
    {
        Card.SetActive(false);
    }
}