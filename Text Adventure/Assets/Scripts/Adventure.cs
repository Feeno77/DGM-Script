using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventure : MonoBehaviour {

    public enum States { cell, window, gate, bed };
    public States currentState;


    // Use this for initialization
    void Start() {
        currentState = States.cell;

    }

    // Update is called once per frame
    void Update()
    {
        if (currentState == States.cell)
        {
            Cell();
        }
        else if (currentState == States.window)
        {
            Window();
        }
        else if (currentState == States.gate)
        {
            Gate();
        }
        else if (currentState == States.bed)
        {
            Bed();
        }



    }

    private void Cell()
    {
        print("You are in a Cell. It smells of beef and sadness.\n" +
            "There is a Window.\n" +
            "There is a Gate.\n" +
            "There is a Bed.\n" +
            "Press W for Window, G for Gate, B for Bed.");
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.gate; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }

    private void Window()
    {
        print("You walk to the window." +
            " It's dark outside.");
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.gate; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    
    private void Gate()
    {
        print("You go over to the gate.");
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    private void Bed()
    {
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.gate; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
    }

}
