using UnityEngine;
using System.Collections;

public class DealDamageOnImpact : MonoBehaviour 
{
	[Range(0, 500)]
	public int amount = 1;
	
	public GameObject impactSpecialEffect;
	
	internal bool consumed = false;
	
	public bool destroyOnImpact = false;
}
