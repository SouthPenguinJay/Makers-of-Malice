using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public BattleSystem EnemyControl;

    // Start is called before the first frame update
    void Start()
    {
        //let controller know enemy is in scene
        EnemyControl.enemyHasAppeared();
    }
    void OnCollisionEnter(Collision col)
    {
        //test
        if(col.gameObject.tag == "Enemy")
        {
            //let controller know enemy died
            EnemyControl.enemyHasDied();
            //any destroy ingame functionality here - play death sound, death particles, etc
            // Destroy the gameObject after 1 sec
            Destroy(col.gameObject, 1.0f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
