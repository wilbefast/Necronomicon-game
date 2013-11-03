using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Weapon))]
public class AttackWithDelay : MonoBehaviour 
{
	[Range(0.0f, 10.0f)]
	public float delayBeforeAttack = 1.0f;
	
	[Range(0.0f, 10.0f)]
	public float attackDuration = 1.0f;
	
	public Weapon weaponToUse;
	
	void Start () 
	{
		if(weaponToUse == null)
			weaponToUse = GetComponent<Weapon>();
		
		StartCoroutine(attackWithDelay(attackDuration, delayBeforeAttack));
	}
			
	protected IEnumerator attackWithDelay(float duration = 0.0f, float delay = 0.0f)
	{
		while(enabled && weaponToUse.canBeLaunched())
		{
			// wait
			yield return new WaitForSeconds(delay);
			
			// launch attack
			Animator animator = GetComponentInChildren<Animator>();
			animator.SetBool("isAttacking", true);
			
			// wait for the end of the animation
			yield return new WaitForSeconds(duration);
			animator.SetBool("isAttacking", false);
			
			// launch the attack
			weaponToUse.launchAttack();
		}
	}
}
