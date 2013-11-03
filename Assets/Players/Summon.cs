using UnityEngine;
using System.Collections;

public class Summon : MonoBehaviour 
{
	[System.Serializable]
	public class Option
	{
		public GameObject prefab;
		public KeyCode keyboardKey;
	}
	public Option[] options;
	
	private GameObject currentMinion = null;
	
	void Update () 
	{
		if(currentMinion == null)
		foreach(Option o in options)
		{
			if(Input.GetKeyDown(o.keyboardKey))
			{
				currentMinion = (GameObject)GameObject.Instantiate(
					o.prefab, transform.position, transform.rotation);
				currentMinion.transform.parent = transform;
			}
		}
	}
}
