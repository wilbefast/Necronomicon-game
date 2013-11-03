#pragma strict


//////////// ATTENTION SCRIPT DEGUEULASSE


var hasStarted : boolean = false;
var startingDelay : Number = 0.0;
var iniScale : Number;
var isClosing : boolean = false;
var startingPoint : Number;
var timeOfBeingHere : Number = 2;

var hasNotYetInvoked : boolean = true;

var black : boolean = true;
var newColor : Color;

function Start () {
	iniScale = transform.localScale.x;
	transform.localScale *= 6;
	startingPoint = Time.time;
	Invoke("startTheShit", startingDelay);
	transform.renderer.enabled = false;
}



function startTheShit(){
	hasStarted = true;
	transform.renderer.enabled = true;
}

function KBOOM (){
	 Destroy(gameObject.transform.parent.gameObject);
}

function blink(){
	if (black){
		black = false;
		newColor = Color(0, 0, 0);
		transform.renderer.material.SetColor("_TintColor", newColor);
	}
	else {
		black = true;
		newColor = Color(255, 255, 255);
		transform.renderer.material.SetColor("_TintColor", newColor);
	}
}

function Update () {
	if ((transform.localScale.x > iniScale) && !isClosing){
		if (hasStarted){
			transform.localScale -= 0.1*Vector3.one;
		}
	}
	else {
		isClosing = true;
		
	};
	
	if (isClosing && Time.time > startingPoint + timeOfBeingHere){
		
		if (hasNotYetInvoked){
			CancelInvoke();
			InvokeRepeating("blink", 0, 0.1);
			Invoke("KBOOM", 1);
			hasNotYetInvoked = false;
		}
		
	}
}