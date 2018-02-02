using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGuesser : MonoBehaviour
{

    public int max;
    public int min;
    private int guess;
    private int guessesMade;
    public int guessesAllowed = 8;


    //Use this for initilization
    private void Start()
    {
        print("Welcome to Number Guesser!");
        print(("Pick a number between ") + min + " and " + max);
        print("Up arrow for higher, Down arrow for lower, Enter for correct");
        //max = max + 1;
        nextGuess();
    }


    private void nextGuess()
    {
        guessesMade++;
        guess = Random.Range(min, max);
        //guess = (min + max) / 2;
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

        else if (guessesMade >= guessesAllowed)
        { print("YOU WIN!"); }
    }
}