using UnityEngine;
using System.Collections;

[RequireComponent(typeof(GUIText))]
public class LifeIndicator : MonoBehaviour 
{
	public Life life;
		
	void Update () 
	{
		guiText.text = (""+life.hitpoints);
	}
}
