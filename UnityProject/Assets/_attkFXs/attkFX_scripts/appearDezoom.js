#pragma strict

var iniScale : Number;
var isClosing : boolean = false;
var startingPoint : Number;
var timeOfBeingHere : Number = 2;

function Start () {
	iniScale = transform.localScale.x;
	transform.localScale *= 4;
	startingPoint = Time.time;
}

function Update () {
	if ((transform.localScale.x > iniScale+0.05) && !isClosing){
		transform.localScale = ((iniScale*Vector3.one) + 5*transform.localScale)/6;
	}
	else {
		isClosing = true;
		
	};
	
	if (isClosing && Time.time > startingPoint + timeOfBeingHere){
		if (transform.localScale.x > 0.04){
			transform.localScale -= 0.02*Vector3.one;
		}
		else {
			Destroy(gameObject);
		}
	}
}