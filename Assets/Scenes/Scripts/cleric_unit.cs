using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleric_enemy_unit : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        if (level == 0)
        {
            int damage = Random.Range(4, 8);
            int maxhp = 24;
            double dodge = 0;
            int prot = 0;
            int spd = 4;
            int acc = 0;
            int crit = 1;

        }
        if (level == 1)
        {
            int damage = Random.Range(5, 10);
            int maxhp = 29;
            double dodge = 5;
            int prot = 0;
            int spd = 4;
            int acc = 0;
            int crit = 2;

        }
        if (level == 2)
        {
            int damage = Random.Range(6, 11);
            int maxhp = 34;
            double dodge = 10;
            int prot = 0;
            int spd = 5;
            int acc = 0;
            int crit = 3;

        }
        if (level == 3)
        {
            int damage = Random.Range(6, 13);
            int maxhp = 39;
            double dodge = 15;
            int prot = 0;
            int spd = 5;
            int acc = 0;
            int crit = 4;

        }
        if (level == 4)
        {
            int damage = Random.Range(7, 14);
            int maxhp = 44;
            double dodge = 20;
            int prot = 0;
            int spd = 6;
            int acc = 0;
            int crit = 5;

        }
    }
}