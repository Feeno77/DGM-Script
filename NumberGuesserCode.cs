using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGuesserCode : MonoBehaviour
{

    public int max;
    public int min;
    private int guess;
    public int count;


    //Use this for initilization
    private void start()
    {
        print("Welcome to Number Guesser!");
        print(("Pick a number between ") + min + "and " + max);
    }

    //Instructions - Push these buttons
    private void instructions()
    {
        print("Up arrow for higher, Down arrow for lower, Enter for correct");
        max = max + 1;
    }



    private void nextGuess()
    {
        count++;
        guess = (min + max) / 2;
        print(("Is the number ") + guess + "?");
    }

    //Update is called once per frame
    void Update()
    {
        //Up Arrow

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            nextGuess();
        }
        //Down Arrow
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            nextGuess();
        }
        //Enter button
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("COMPUTER WIN!");
        }

        else if (count >= 6)
        { print("YOU WIN!"); }
    }
}