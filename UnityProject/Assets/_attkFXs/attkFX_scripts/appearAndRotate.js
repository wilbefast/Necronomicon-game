var iniScale : Number;
var isClosing : boolean = false;
var startingPoint : Number;
var timeOfBeingHere : Number = 2;

var yRotation : Number;

function Start () {
	iniScale = transform.localScale.x;
	transform.localScale = 0.1*transform.localScale;
	startingPoint = Time.time;
}

function Update () {
	
	yRotation ++;
	transform.eulerAngles = Vector3(transform.eulerAngles.x, yRotation, transform.eulerAngles.z);
	
	
	if ((transform.localScale.x < iniScale-0.05) && !isClosing){
		transform.localScale = ((iniScale*Vector3.one) + 5*transform.localScale)/6;
	}
	else {
		isClosing = true;
		//Destroy(gameObject);
		
	};
	
	/*if (isClosing){
		if (Time.time > startingPoint + timeOfBeingHere){
			transform.localScale = (((Vector3.zero) + 5*transform.localScale)/6);
			if (transform.localScale.x <= 0.1*iniScale){
				Destroy(gameObject.transform.parent.gameObject); //prevents bugs ?
			}
		}
	}*/
}