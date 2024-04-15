using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedling_unit : MonoBehaviour
{
    public int level;
    public GameObject Healthbar;
    // Start is called before the first frame update
    void Start()
    {
        if (level == 0)
        {
            int damage = Random.Range(4, 7);
            int maxhp = 22;
            double dodge = 0;
            int prot = 0;
            int spd = 7;
            int acc = 0;
            int crit = 2;

        }
        if (level == 1)
        {
            int damage = Random.Range(5, 8);
            int maxhp =26;
            double dodge = 5;
            int prot = 0;
            int spd = 7;
            int acc = 0;
            int crit = 3;

        }
        if (level == 2)
        {
            int damage = Random.Range(6, 10);
            int maxhp = 30;
            double dodge = 10;
            int prot = 0;
            int spd = 8;
            int acc = 0;
            int crit = 4;

        }
        if (level == 3)
        {
            int damage = Random.Range(6, 11);
            int maxhp = 34;
            double dodge = 15;
            int prot = 0;
            int spd = 8;
            int acc = 0;
            int crit = 5;

        }
        if (level == 4)
        {
            int damage = Random.Range(7, 13);
            int maxhp = 38;
            double dodge = 20;
            int prot = 0;
            int spd = 9;
            int acc = 0;
            int crit = 6;

        }
    }
}