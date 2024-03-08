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
            RangeInt damage = (6. 11);
            int maxhp = 26; 
            double dodge = 7.5;
            int prot = 0;
            int spd = 7;
            int acc = 0;
            int crit = 2;

        }
        if (level == 1)
        {
            RangeInt damage = (7. 13);
            int maxhp = 31;
            double dodge = 12.5;
            int prot = 0;
            int spd = 7;
            int acc = 0;
            int crit = 3;

        }
        if (level == 2)
        {
            RangeInt damage = (8. 15);
            int maxhp = 36;
            double dodge =17.5;
            int prot = 0;
            int spd = 8;
            int acc = 0;
            int crit = 4;

        }
        if (level == 3)
        {
            RangeInt damage = (10. 18);
            int maxhp = 41;
            double dodge = 22.5;
            int prot = 0;
            int spd = 8;
            int acc = 0;
            int crit = 5;

        }
        if (level == 4)
        {
            RangeInt damage = (11. 20);
            int maxhp = 46;
            double dodge =27.5;
            int prot = 0;
            int spd = 9;
            int acc = 0;
            int crit = 6;

        }
    }
}