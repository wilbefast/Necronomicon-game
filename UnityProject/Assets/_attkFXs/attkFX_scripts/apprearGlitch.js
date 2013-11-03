#pragma strict

var black : boolean = true;
var newColor : Color;
var startingPoint : Number;

var hasNotCancelledYet : boolean = true;

function Start () {
	startingPoint = Time.time;
	InvokeRepeating("blink", 0, 0.1);
}


function blink(){
	transform.localScale *= Random.Range(0.99, 1.01);
}




function Update () {
	if (Time.time > startingPoint + 1 && hasNotCancelledYet){
		CancelInvoke();
		hasNotCancelledYet = false;
	}
	if (Time.time > startingPoint + 1.5){
		if (transform.localScale.z > 0.002){
			transform.localScale.z *= 0.5;
		}
		if (transform.localScale.x < 30){
			transform.localScale.x *= 1.5;
		}
	}
	if (Time.time > startingPoint + 2){
		Destroy(gameObject.transform.parent.gameObject);
	}
}