using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Life))]
public class TakeDamageOnImpact : MonoBehaviour 
{
	void OnTriggerEnter (Collider collider)
	{
		DealDamageOnImpact damage = 
			collider.gameObject.GetComponent<DealDamageOnImpact>();
		if(damage != null && !damage.consumed)
		{
			GetComponent<Life>().hitpoints -= damage.amount;
			if(damage.destroyOnImpact)
				GameObject.Destroy(damage.gameObject);
			
			damage.consumed = true;
			
			if(damage.impactSpecialEffect != null)
				GameObject.Instantiate(damage.impactSpecialEffect, 
					new Vector3(transform.position.x, 0.1f, -0.5f),
					Quaternion.identity);
		}
	}
}
