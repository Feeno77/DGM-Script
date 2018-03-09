using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    
      
        public Vector2 startVector;
    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(startVector, ForceMode2D.Force);
    }


     
}
