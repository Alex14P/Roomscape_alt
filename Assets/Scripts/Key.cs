using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject inticon, key, sign1, sign2, sign3, sign4;
    public AudioSource pickup;

    void OnTriggerStay(Collider other){
        if (other.CompareTag("MainCamera")){
            inticon.SetActive(true);
            if(Input.GetKey(KeyCode.E)){
                key.SetActive(false);
                Door.keyfound = true;
                inticon.SetActive(false);
                sign1.SetActive(true);
                sign2.SetActive(true);
                sign3.SetActive(true);
                sign4.SetActive(true);
                pickup.Play();
            }
        }
    }
    void OnTriggerExit(Collider other){
        if(other.CompareTag("MainCamera")){
            inticon.SetActive(false);
        }
    }
}
