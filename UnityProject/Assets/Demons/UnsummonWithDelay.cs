using UnityEngine;
using System.Collections;

public class UnsummonWithDelay : MonoBehaviour 
{
	[Range(2.0f, 10.0f)]
	public float delay = 3.0f;
	
	void Start () 
	{
		StartCoroutine(unsummonWithDelay());
	}
	
	private IEnumerator unsummonWithDelay()
	{
		// wait
		yield return new WaitForSeconds(delay);
		
		GameObject.Destroy(gameObject);
		
		yield break;
	}
}
