using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

	public Animator animator;

	public int health = 200;

	public int curhealth;

	public HealthBarp healthBarp; 

	public GameObject deathEffect;

	void Start()
    {
		curhealth = health;
		healthBarp.Sethealth(health);


	}

	public void TakeDamage(int damage)
	{
		curhealth -= damage;

		animator.SetTrigger("Hurt");
		// Se quiseres por o inimigo a piscar em vez de levar dano

		//StartCoroutine(DamageAnimation());

		if (curhealth <= 0)
		{
			Die();
		}

		healthBarp.SetHealth(curhealth);
	}

	void Die()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}





// Se quiseres por o inimigo a piscar em vez de levar dano



//	IEnumerator DamageAnimation()
//	{
//		SpriteRenderer[] srs = GetComponentsInChildren<SpriteRenderer>();
//
//		for (int i = 0; i < 3; i++)
//		{
//			foreach (SpriteRenderer sr in srs)
//			{
//				Color c = sr.color;
//				c.a = 0;
//				sr.color = c;
//			}
//
//			yield return new WaitForSeconds(.1f);
//
//			foreach (SpriteRenderer sr in srs)
//			{
//				Color c = sr.color;
//				c.a = 1;
//				sr.color = c;
//			}
//
//			yield return new WaitForSeconds(.1f);
//		    }
//	  }

}
