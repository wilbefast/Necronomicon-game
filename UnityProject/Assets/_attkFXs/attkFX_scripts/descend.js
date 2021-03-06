﻿#pragma strict

var iniPosition : Number;
var endFirstAnim : boolean = false;
var sizeExtend : Number = 0.5; // /!\ la taille originale du truc c'est environs 0.2

var startingPoint : Number;
var newColor : Color;

function Start () {
	iniPosition = transform.localPosition.y;
	transform.localPosition.y +=3;
	startingPoint = Time.time;
}

function Update () {
	if (transform.localPosition.y > iniPosition+0.1){
		transform.localPosition.y = (iniPosition + 30*transform.localPosition.y)/31;
		newColor = Color(1, 1, 1, 1-(transform.localPosition.y-iniPosition)/3);
        transform.renderer.material.SetColor("_TintColor", newColor);
	}
	else {
		endFirstAnim = true;
		//transform.localPosition.y = iniPosition;
	};
	
	if (endFirstAnim && Time.time > startingPoint +2.5){
		if (transform.localScale.z < sizeExtend-0.1){
			transform.localScale.z *= 1.5;
			if (transform.localScale.x > 0.002){
				transform.localScale.x *= 0.5;
			}
		}
		else {
			//Debug.Log("self destruct");
			Destroy (gameObject.transform.parent.gameObject);
		}
	}
}