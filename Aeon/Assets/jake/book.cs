using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book : MonoBehaviour
{
 
    public GameObject Card;
    public GameObject door;

    void OnTriggerEnter()
    {
        Card.SetActive(false);
        door.SetActive(false);
    }
}