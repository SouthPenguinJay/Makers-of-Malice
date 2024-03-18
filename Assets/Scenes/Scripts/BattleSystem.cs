using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST,ENDTURN }

public class BattleSystem : MonoBehaviour
{


	public GameObject playerPrefab1;
	public GameObject playerPrefab2;
	public GameObject playerPrefab3;
	public GameObject playerPrefab4;
	public GameObject enemyPrefab1;
	public GameObject enemyPrefab2;
	public GameObject enemyPrefab3;
	public GameObject enemyPrefab4;

	public Transform playerBattleStation1;
    public Transform playerBattleStation2;
    public Transform playerBattleStation3;
    public Transform playerBattleStation4;
    public Transform enemyBattleStation1;
    public Transform enemyBattleStation2;
    public Transform enemyBattleStation3;
    public Transform enemyBattleStation4;
	public int[] Turnorder;

    Unit playerUnit;
	Unit enemyUnit;

	public Text dialogueText;

	public BattleHUD playerHUD;
	public BattleHUD enemyHUD;

	public BattleState state;

    private int EnemiesLeft = 0;

    //random number gen
	
	public void enemyHasDied()
	{
		EnemiesLeft--;
		print(EnemiesLeft);

		if (EnemiesLeft == 0)
		{
			// Enable cleared ui menu here
			// destroy this if needs be
		}
	}
	
	public void enemyHasAppeared()
	{
		EnemiesLeft++;
		print(EnemiesLeft);
	}

    // Start is called before the first frame update
    void Start()
	{
		state = BattleState.START;
		StartCoroutine(SetupBattle());
		//place units on platforms acording to rank
	}

	IEnumerator SetupBattle()
	{
		GameObject playerGO1 = Instantiate(playerPrefab1, playerBattleStation1);
        GameObject playerGO2 = Instantiate(playerPrefab2, playerBattleStation2);
        GameObject playerGO3 = Instantiate(playerPrefab3, playerBattleStation3);
        GameObject playerGO4 = Instantiate(playerPrefab4, playerBattleStation4);
        playerUnit = playerGO1.GetComponent<Unit>();
        playerUnit = playerGO2.GetComponent<Unit>();
        playerUnit = playerGO3.GetComponent<Unit>();
        playerUnit = playerGO4.GetComponent<Unit>();

        GameObject enemyGO1 = Instantiate(enemyPrefab1, enemyBattleStation1);
        GameObject enemyGO2 = Instantiate(enemyPrefab2, enemyBattleStation2);
        GameObject enemyGO3 = Instantiate(enemyPrefab3, enemyBattleStation3);
        GameObject enemyGO4 = Instantiate(enemyPrefab4, enemyBattleStation4);
        enemyUnit = enemyGO1.GetComponent<Unit>();
        enemyUnit = enemyGO2.GetComponent<Unit>();
		enemyUnit = enemyGO3.GetComponent<Unit>();
        enemyUnit = enemyGO4.GetComponent<Unit>();


		playerHUD.SetHUD(playerUnit);
		enemyHUD.SetHUD(enemyUnit);

		yield return new WaitForSeconds(2f);

	     NewTurn();
		//roll a d8 for every units turn
		//deal status effect damage to units at the start of THEIR turn
	}

	IEnumerator PlayerAttack()
	{
		bool isDead = enemyUnit.TakeDamage(playerUnit.damage);

		enemyHUD.SetHP(enemyUnit.currentHP);

		yield return new WaitForSeconds(2f);
			state = BattleState.ENDTURN;
			StartCoroutine(NewTurn());
	}

	IEnumerator EnemyTurn()
	{


		yield return new WaitForSeconds(1f);

		bool isDead = playerUnit.TakeDamage(enemyUnit.damage);

		playerHUD.SetHP(playerUnit.currentHP);

		yield return new WaitForSeconds(1f);

			state = BattleState.ENDTURN;
			NewTurn();
	}

	void EndBattle()
	{
		if (state == BattleState.WON)
		{
	
		}
		else if (state == BattleState.LOST)
		{

		}
	}

	void PlayerTurn()
	{

	}

	IEnumerator PlayerHeal()
	{
		playerUnit.Heal(5);

		playerHUD.SetHP(playerUnit.currentHP);


		yield return new WaitForSeconds(2f);

		state = BattleState.ENDTURN;
		StartCoroutine(NewTurn());
	}

	public void OnAttackButton()
	{
		if (state != BattleState.PLAYERTURN)
			return;

		StartCoroutine(PlayerAttack());
	}

	public void OnHealButton()
	{
		if (state != BattleState.PLAYERTURN)
			return;

		StartCoroutine(PlayerHeal());
	}
	IEnumerator NewTurn()
    {


		yield return new WaitForSeconds(2f);
    }
}
//dmg * crit * prot if (rand()%100+ 1)== crit + crit_mod;{   critical = true;} chance = rand() % 100 + 1	2== sucess 1 == fail	87%
