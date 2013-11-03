#pragma strict

private var iniScale : Number;
private var a : Number = 0;

function Start () {
	iniScale = transform.localScale.x;
}

function Update () {
	
		transform.localScale = (iniScale + 0.05*(Mathf.Sin(Time.time)))*Vector3.one;
	
}