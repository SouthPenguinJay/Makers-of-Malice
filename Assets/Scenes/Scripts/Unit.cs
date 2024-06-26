using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Unit : MonoBehaviour
{

	public string unitName;

	public int unitLevel;

	public int damage;

	public int spd;

	public int acc;

	public int dodge;

	public int prot;

	public int crit;

	public int maxHP;

	public int currentHP;

	public GameObject Healthbar;

	public bool TakeDamage(int dmg)
	{
		Healthbar.GetComponent<HealthManager>().TakeDamage(dmg);
		currentHP -= dmg;

		if (currentHP <= 0)
			return true;
		else
			return false;
	}

	public void Heal(int amount)
	{
		currentHP += amount;
		if (currentHP > maxHP)
			currentHP = maxHP;
        Healthbar.GetComponent<HealthManager>().Heal(amount);
    }

}
