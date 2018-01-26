using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour {

    public enum States { cell, window, cellDoor, bed, searchBed, unlockedCellDoor,
       hallway, left, right, fight, run, nurseStation, openWindow, jump };
    public States currentState;
    public Text textObject;
    public Text titleText;


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
        else if (currentState == States.hallway)
        {
            Hallway();
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
        titleText.text = "Prison Cell";
        textObject.text = "You are in a prison Cell. It smells of beef and sadness.\n" +
            "The beef smell you kind of like...\n" +
            "But the floors and walls are covered in... God only knows what.\n" +
            "This will not do. You MUST escape!\n" +
            "There is a Window.\n" +
            "There is a Cell Door.\n" +
            "There is a Bed.\n" +
            "Press W for Window, C for Cell Door, B for Bed.";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cellDoor; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }

    private void Window()
    {
        titleText.text = "Window";
        textObject.text = "You walk over to the window.\n" +
            "It has thick steel bars. It's dark outside.\n" +
            "There's no way you're escaping through those bars...\n" +
            "Press C for Cell Door, B for Bed.";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cellDoor; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    
    private void cellDoor()
    {
        titleText.text = "Cell Door";
        textObject.text = "You go over to the Cell Door.\n" +
            "It's locked up tight. Push as hard as you want, it's not budging.\n" +
            "Unless you can find a way to unlock it...\n" +
            "Press W for Window, B for Bed";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    private void Bed()
    {
        titleText.text = "Bed";
        textObject.text = "You mosey on over to the bed.\n" +
            "If you can even call it a bed...\n" +
            "It's mattress is thinner than the fake meat they serve at Subway.\n" +
            "You fill with despair as your eyes look over it's uncomfortable metal frame.\n" +
            "But wait... you catch a glint of something stuck in a crack of the Bed frame!?...\n" +
            "Press S to search the Bed, W for Window, C for Cell Door.";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cellDoor; }
        if (Input.GetKeyDown(KeyCode.S)) { currentState = States.searchBed; }
    }
    private void SearchBed()
    {
        titleText.text = "Bed";
        textObject.text = "Your hands fumble as you excitedly kneel down to look at the crack.\n" +
            "You see some small metallic object crammed in there.\n" +
            "Your fingers are too fat to get it.\n" +
            "You grab the almost finished prison shank you've been carving from your toothbrush to wedge it out.\n" +
            "It clanks onto the floor, as you look down in utter disbelief...\n" +
            "It's... A KEY!\n" +
            "Press C for Cell Door, W for Window.";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.unlockedCellDoor; }

    }
    private void UnlockCell()
    {
        titleText.text = "Cell Door";
        textObject.text = "You go to the Cell Door.\n" +
            "Looking to see if the coast is clear, you slide the key gently into the keyhole.\n" +
            "You slowly start twisting the key...\n" +
            "To your amazement, it turns the lock!\n" +
            "With an audible 'click' the Cell Door pops open.\n" +
            "Press S to step out into Hallway, W for Window.";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.S)) { currentState = States.hallway; }
    }

    private void Hallway()
    {
        titleText.text = "Hallway";
        textObject.text = "You cautiously creep out into the dimly lit Hallway.\n" +
            "It looks like the coast is clear.\n" +
            "You can choose to go Left or Right.\n" +
            "Press L for Left, R for Right.";
        if (Input.GetKeyDown(KeyCode.L)) { currentState = States.left; }
        if (Input.GetKeyDown(KeyCode.R)) { currentState = States.right; }
    }
    private void Guards()
    {
        titleText.text = "Left Hallway";
        textObject.text = "You quickly but quietly dart down the hallway to the left.\n" +
            "As you round the corner, you strike disaster.\n" +
            "There are two guards standing there!\n" +
            "They see you instantly, and yell 'STOP!'\n" +
            "With a surge of adrenaline, your fight or flight response kicks in.\n" +
            "Press F to Fight, R to Run.";
        if (Input.GetKeyDown(KeyCode.F)) { currentState = States.fight; }
        if (Input.GetKeyDown(KeyCode.R)) { currentState = States.run; }
    }
    private void Right()
    {
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.unlockedCellDoor; }
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
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.unlockedCellDoor; }
    }
    private void Jump()
    {

    }
}
