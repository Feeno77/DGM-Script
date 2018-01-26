using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour {

    public enum States { cell, window, cellDoor, bed, searchBed, unlockedCellDoor,
        left, right, fight, run, nurseStation, openWindow, jump };
    public States currentState;
    public Text textObject;


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
        else if (currentState == States.cellDoor)
        {
            cellDoor();
        }
        else if (currentState == States.bed)
        {
            Bed();
        }
        else if (currentState == States.searchBed)
        {
            SearchBed();
        }
        else if (currentState == States.unlockedCellDoor)
        {
            UnlockCell();
        }
        else if (currentState == States.left)
        {
            Guards();
        }
        else if (currentState == States.right)
        {
            Right();
        }
        else if (currentState == States.fight)
        {
            Fight();
        }
        else if (currentState == States.run)
        {
            Run();
        }
        else if (currentState == States.nurseStation)
        {
            Nurse();
        }
        else if (currentState == States.openWindow)
        {
            OpenWindow();
        }
        else if (currentState == States.jump)
        {
            Jump();
        }



    }

    private void Cell()
    {
        print("You are in a Cell. It smells of beef and sadness.\n" +
            "There is a Window.\n" +
            "There is a Cell Door.\n" +
            "There is a Bed.\n" +
            "Press W for Window, C for Cell Door, B for Bed.");
        textObject.text = "You are in a Cell. It smells of beef and sadness.\n" +
            "There is a Window.\n" +
            "There is a Cell Door.\n" +
            "There is a Bed.\n" +
            "Press W for Window, C for Cell Door, B for Bed.";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.cellDoor; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }

    private void Window()
    {
        print("You walk to the window." +
            " It's dark outside.");
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.cellDoor; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    
    private void cellDoor()
    {
        print("You go over to the gate.");
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    private void Bed()
    {
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.cellDoor; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
    }
    private void SearchBed()
    {

    }
    private void UnlockCell()
    {

   
    }
    private void Guards()
    {

    }
    private void Right()
    {

    }
    private void Fight()
    {

    }
    private void Run()
    {

    }
    private void Nurse()
    {

    }
    private void OpenWindow()
    {

    }
    private void Jump()
    {

    }
}
