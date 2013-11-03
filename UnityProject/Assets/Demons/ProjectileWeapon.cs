using UnityEngine;
using System.Collections;

public class ProjectileWeapon : Weapon 
{
	[Range(0.0f, 50.0f)]
	public float muzzleVelocity = 1.0f;
	
	public Rigidbody projectilePrefab;
	
	public Transform muzzle;
	
	public void Start()
	{
		if(muzzle == null)
			muzzle = transform;
	}
	
	public override void launchAttack()
	{
		Rigidbody projectile = (Rigidbody)Rigidbody.Instantiate(
			projectilePrefab, muzzle.position, muzzle.rotation);
		projectile.velocity = transform.forward*muzzleVelocity;
	}
}
