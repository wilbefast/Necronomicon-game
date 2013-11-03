using UnityEngine;
using System.Collections;

public class ForceRotation : MonoBehaviour 
{
	void Update () 
	{
		Debug.Log ("WHAT THE FUCK???");
		transform.localRotation.SetLookRotation(transform.parent.forward, transform.parent.up);
	}
}
