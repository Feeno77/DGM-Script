using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public static MusicManager instance = null; //Singleton

    // Use this for initialization
    void Awake () {
          if (instance == null) //If instance is not assigned, 
    {
        instance = this;        //Assign it to this
    }
          else if (instance != this)  //If instance is not this
        {
            Destroy(this.gameObject);  //Destroy it
        }

        DontDestroyOnLoad(this.gameObject);
}
	

}
