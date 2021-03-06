﻿using UnityEngine;
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
	
	protected override void _launchAttack()
	{
		Rigidbody projectile = (Rigidbody)Rigidbody.Instantiate(
			projectilePrefab, muzzle.position, muzzle.rotation);
		projectile.velocity = muzzle.forward*muzzleVelocity;
		projectile.transform.parent = transform;
	}
}
