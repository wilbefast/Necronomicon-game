using UnityEngine;
using System.Collections;

public class Replace : MonoBehaviour 
{
	[System.Serializable]
	public class Replacement
	{
		public GameObject prefab;
		public Transform transform;
	}
	public Replacement[] replacements;
	
	void Start()
	{
		foreach(Replacement r in replacements)
		{
			if(r.transform == null)
				r.transform = transform;
			GameObject spawn = (GameObject)GameObject.Instantiate(
				r.prefab, r.transform.position, r.transform.rotation);
			spawn.transform.parent = transform.parent;
			
			if(spawn.rigidbody != null && rigidbody != null)
				spawn.rigidbody.velocity = rigidbody.velocity;
		}
		GameObject.Destroy(gameObject);
	}
}
