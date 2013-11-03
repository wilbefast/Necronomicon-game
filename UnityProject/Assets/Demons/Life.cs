using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour 
{
	[Range(10, 1000)]
	public int maxHitpoints = 100;
	
	public bool destroyOnDeath = false;
	
	private int __hitpoints;
	public int hitpoints
	{
		get{ return __hitpoints; }
		set
		{
			__hitpoints = value;
			
			if(__hitpoints > maxHitpoints)
				__hitpoints = maxHitpoints;
			else if(__hitpoints <= 0)
			{
				__hitpoints = 0;
				if(destroyOnDeath)
					GameObject.Destroy(gameObject);
				BroadcastMessage("OnDeath", SendMessageOptions.DontRequireReceiver);
			}
		}
	}
	
	void Start()
	{
		__hitpoints = maxHitpoints;
	}
		
}
