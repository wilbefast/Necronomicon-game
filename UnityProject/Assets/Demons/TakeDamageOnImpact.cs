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
		}
	}
}
