using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyespider_unit : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        if (level == 0)
        {
            int damage = Random.Range(4,8);
            int maxhp = 20;
            double dodge = 10;
            int prot = 0;
            int spd = 8;
            int acc = 0;
            int crit = 6;

        }
        if (level == 1)
        {
            int damage = Random.Range(5, 10);
            int maxhp = 24;
            double dodge = 15;
            int prot = 0;
            int spd = 8;
            int acc = 0;
            int crit = 7;

        }
        if (level == 2)
        {
            int damage = Random.Range(6, 11);
            int maxhp = 28;
            double dodge = 20;
            int prot = 0;
            int spd = 9;
            int acc = 0;
            int crit = 8;

        }
        if (level == 3)
        {
            int damage = Random.Range(6, 13);
            int maxhp = 32;
            double dodge = 25;
            int prot = 0;
            int spd = 9;
            int acc = 0;
            int crit = 9;

        }
        if (level == 4)
        {
            int damage = Random.Range(7, 14);
            int maxhp = 36;
            double dodge = 30;
            int prot = 0;
            int spd = 10;
            int acc = 0;
            int crit = 10;

        }
    }
}