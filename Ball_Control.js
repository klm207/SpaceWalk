#pragma strict

function Start () {
    
}

function Update () {
    transform.Rotate(20*Time.deltaTime,20*Time.deltaTime,20*Time.deltaTime);
    transform.RotateAround(Vector3.zero, Vector3.up, 20*Time.deltaTime); 
}
