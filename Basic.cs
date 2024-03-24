using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour
{
    public GameObject obj;


    private void Start()
    {
        obj.SetActive(false); // Объект исчезает при старте. 
    }
}
