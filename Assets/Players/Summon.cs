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
	
	
	void Update () 
	{
		foreach(Option o in options)
		{
			if(Input.GetKeyDown(o.keyboardKey))
			{
				GameObject minion = (GameObject)GameObject.Instantiate(
					o.prefab, transform.position, transform.rotation);
			}
		}
	}
}
