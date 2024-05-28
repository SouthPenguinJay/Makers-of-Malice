using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class Options : MonoBehaviour
{
    public GameObject OptionsMenuGO; 

    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
             
                OptionsMenuGO.SetActive(!OptionsMenuGO.activeSelf);
            } 
         

    }
}
