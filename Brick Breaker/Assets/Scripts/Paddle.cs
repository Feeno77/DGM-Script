using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        //get current paddle position
        Vector3 paddlePosition = new Vector3(0, gameObject.transform.position.y, 0);
        //get mouse horizontal position
        float mousePositionX = Input.mousePosition.x / Screen.width *16 - 8;
        //save new position
        paddlePosition.x = mousePositionX;
        //set paddle object to saved position 
        this.gameObject.transform.position = paddlePosition;
	}
}
