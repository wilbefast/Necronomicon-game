using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Weapon))]
public class AttackOnDamaged : AttackWithDelay 
{
	[Range(0.0f, 10.0f)]
	public float delayBeforeRetaliation = 0.0f;
	
	void OnDamaged()
	{
		// restart delayed attack with lower wait
		delayBeforeAttack = delayBeforeRetaliation;
		StartCoroutine(attackWithDelay(attackDuration, delayBeforeRetaliation));
	}
}
