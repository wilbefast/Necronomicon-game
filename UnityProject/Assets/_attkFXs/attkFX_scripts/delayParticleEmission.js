#pragma strict

var delay : Number = 3;
var startingPoint : Number;

function Start () {
	GetComponent(ParticleEmitter).emit = false;
	startingPoint = Time.time;
}

function Update () {
	if (!GetComponent(ParticleEmitter).emit && (Time.time > startingPoint+delay)){
		GetComponent(ParticleEmitter).emit = true;
	}
}