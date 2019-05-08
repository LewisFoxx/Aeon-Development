using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maptest : MonoBehaviour
{

    public GameObject MAP;
    //public GameObject AttachedObject;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")//&& (Input.GetKeyDown("m")))
            MAP.SetActive(true);
		Cursor.visible = true;
        StartCoroutine("MapOff");
    }

    IEnumerator MapOff()
    {
        yield return new WaitForSeconds(10);
        //CollectExplain.SetActive (true);
        MAP.SetActive(false);
    }
}