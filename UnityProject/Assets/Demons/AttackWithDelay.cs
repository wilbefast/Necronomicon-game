using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Weapon))]
public class AttackWithDelay : MonoBehaviour 
{
	[Range(0.0f, 10.0f)]
	public float delayBeforeAttack = 1.0f;
	
	[Range(0.0f, 10.0f)]
	public float attackDuration = 1.0f;
	
	void Start () 
	{
		StartCoroutine(attackWithDelay());
	}
			
	private IEnumerator attackWithDelay()
	{
		// wait
		yield return new WaitForSeconds(delayBeforeAttack);
		
		// launch attack
		Animator animator = GetComponentInChildren<Animator>();
		animator.SetBool("isAttacking", true);
		
		// wait for the end of the animation
		yield return new WaitForSeconds(attackDuration);
		animator.SetBool("isAttacking", false);
		
		// launch the attack
		GetComponent<Weapon>().launchAttack();
		
		yield break;
	}
}
