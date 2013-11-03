using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour 
{
	void Start () 
	{
		if(transform.forward.x < 0)
			// invert the x scale so that the billboard face away from Z
			transform.localScale = new Vector3(
				-transform.localScale.x, 
				transform.localScale.y, 
				transform.localScale.z);
	}
}
