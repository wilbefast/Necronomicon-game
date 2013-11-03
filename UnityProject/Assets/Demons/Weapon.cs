using UnityEngine;
using System.Collections;

public abstract class Weapon : MonoBehaviour 
{
	[Range(1, 10)]
	public int ammunition = 1;
	
	public bool canBeLaunched()
	{
		return (ammunition > 0);
	}
	
	public void launchAttack()
	{
		if(canBeLaunched())
		{
			_launchAttack();
			ammunition--;	
		}
	}
	
	protected abstract void _launchAttack();
}
