using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {


    [RequireComponent(typeof(AudioSource))]
    public class ExampleClass : MonoBehaviour
    {
        public AudioClip clip;
        void Start()
        {
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
