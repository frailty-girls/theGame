using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textDisplayer : MonoBehaviour
{
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       GetComponent<TextMesh>().text = "uuu";
    }
}
