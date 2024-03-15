using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghoul_unit : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        if (level == 0)
        {
           int damage = Random.Range(8, 16);
            int maxhp = 35; 
            double dodge = 0;
            int prot = 0;
            int spd = 2;
            int acc = 0;
            int crit = 1;

        }
        if (level == 1)
        {
            int damage = Random.Range(9, 18);
            int maxhp = 42;
            double dodge = 5;
            int prot = 0;
            int spd = 2;
            int acc = 0;
            int crit = 2;

        }
        if (level == 2)
        {
            int damage = Random.Range(10, 21);
            int maxhp = 49;
            double dodge =10;
            int prot = 0;
            int spd = 3;
            int acc = 0;
            int crit = 3;

        }
        if (level == 3)
        {
            int damage = Random.Range(12, 23);
            int maxhp = 56;
            double dodge = 15;
            int prot = 0;
            int spd = 3;
            int acc = 0;
            int crit = 4;

        }
        if (level == 4)
        {
            int damage = Random.Range(13, 26);
            int maxhp = 63;
            double dodge =20;
            int prot = 0;
            int spd = 4;
            int acc = 0;
            int crit = 5;

        }
    }
}