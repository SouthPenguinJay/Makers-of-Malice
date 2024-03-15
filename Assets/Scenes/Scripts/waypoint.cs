using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class waypoint : MonoBehaviour
{
    public GameObject[] waypointPrefab;
    public float speed;
    public GameObject movetarget;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i < waypointPrefab.Length; i++) { }
       movetarget.transform.position = Vector2.MoveTowards(movetarget.transform.position, waypointPrefab[0].transform.position, speed*Time.deltaTime);
    }
}
