using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class merc_enemy_unit : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        if (level == 0)
        {
            int damage = Random.Range(5, 10);
            int maxhp = 23;
            double dodge = 10;
            int prot = 0;
            int spd =5;
            int acc = 0;
            int crit = 5;

        }
        if (level == 1)
        {
            int damage = Random.Range(6, 12);
            int maxhp = 28;
            double dodge = 15;
            int prot = 0;
            int spd = 5;
            int acc = 0;
            int crit = 6;

        }
        if (level == 2)
        {
            int damage = Random.Range(7, 13);
            int maxhp = 33;
            double dodge = 20;
            int prot = 0;
            int spd = 6;
            int acc = 0;
            int crit = 7;

        }
        if (level == 3)
        {
            int damage = Random.Range(8, 15);
            int maxhp = 38;
            double dodge = 25;
            int prot = 0;
            int spd = 6;
            int acc = 0;
            int crit = 8;

        }
        if (level == 4)
        {
            int damage = Random.Range(9, 16);
            int maxhp = 43;
            double dodge = 30;
            int prot = 0;
            int spd = 7;
            int acc = 0;
            int crit = 9;

        }
    }
}