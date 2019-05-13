using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerryCanCollect : MonoBehaviour {

    public int RotateSpeed;
    public GameObject Card;
    public GameObject Cube;


    void Update () {
        RotateSpeed = 2;
        transform.Rotate (0, RotateSpeed, 0, Space.World);
    }


    void OnTriggerEnter () {
        Card.SetActive (false);
        Cube.SetActive(true);
    }
}