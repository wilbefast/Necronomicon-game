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
	
	public Transform spawnPosition;
	
	private GameObject currentMinion = null;
	
	void Start()
	{
		if(spawnPosition == null)
			spawnPosition = transform;
	}
	
	void Update () 
	{
		foreach(Option o in options)
		{
			if(Input.GetKeyDown(o.keyboardKey))
			{
				if(currentMinion != null)
					GameObject.Destroy(currentMinion);
					
				currentMinion = (GameObject)GameObject.Instantiate(
					o.prefab, spawnPosition.position, spawnPosition.rotation);
				currentMinion.transform.parent = transform;
				break;
			}
		}
	}
}
