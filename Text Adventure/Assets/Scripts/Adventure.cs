using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour {

    public enum States { cell, window, cellDoor, bed, searchBed, unlockedCellDoor,
       hallway, left, right, fight, run, nurseStation, openWindow, jump, lose, win };
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
        else if (currentState == States.lose)
        {
            Lose();
        }
        else if (currentState == States.win)
        {
            Win();
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
            "Press H to step out into Hallway, W for Window.";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.H)) { currentState = States.hallway; }
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
        titleText.text = "Right Hallway";
        textObject.text = "You slink down the hallway to the Right.\n" +
            "Up ahead, you see a Nurses station.\n" +
            "Maybe there's some valuable things in there to help in your escape?\n" +
            "But there's also a window, that looks like it might be cracked open.\n" +
            "Where could it lead?\n" +
            "Press N for Nurses Station, W for Window.";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.openWindow; }
        if (Input.GetKeyDown(KeyCode.N)) { currentState = States.nurseStation; }
    }
    private void Fight()
    {
        titleText.text = "FIGHT!";
        textObject.text = "You decide to fight the guards, even though you have no weapons.\n" +
            "Maybe it's all the Bourne Identity movies you've watched.\n" +
            "Or maybe you're just stupid.\n" +
            "Either way, you're confident in your destructive power as you charge forward.\n" +
            "One of the guards promptly pulls out pepper spray and sprays a lethal shot right into your face.\n" +
            "Eyes watering, snot dripping from your nose, you cry like a little girl on the floor.\n" +
            "Press C to Continue...";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.lose; }
    }
    private void Run()
    {
        titleText.text = "RUN!";
        textObject.text = "You know you don't stand a chance, so you decide to Run!\n" +
            "You scramble to turn back around and take off running.\n" +
            "The guards are hot on your heels!\n" +
            "One of them pulls out a taser, and you hear a 'POP!'\n" +
            "You feel the taser prongs plunge into your back, as 50,000 volts courses through your body.\n" +
            "Wimpering and defeated, you writhe in agony on the floor.\n" +
            "IT BUURRNNSS UUUSSSSS!!!\n" +
            "Press C to Continue...";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.lose; }
    }
    private void Nurse()
    {
        titleText.text = "Nurses Station";
        textObject.text = "You decide to see if there's anything of value you can swipe in the Nurses Station.\n" +
            "You walk over to the door, fairly confident that nobody will be inside.\n" +
            "It's the middle of the night, nobody's working, right?\n" +
            "WRONG! As if some programmer planned it in his head, a big burly female nurse is waiting there!\n" +
            "With the strength of 1000 vikings, she sticks a needle in your neck and injects you with something.\n" +
            "Your vision starts to blur, and the last thing you see is the floor rushing up to meet your face...\n" +
            "Press C to Continue...";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.lose; }

    }
    private void Lose()
    {
        titleText.text = "You Lost :(";
        textObject.text = "You were not able to escape this pit of despair...\n" +
            "Would you like to try again?\n" +
            "Press T to try again";
        if (Input.GetKeyDown(KeyCode.T)) { currentState = States.cell; }
    }
    private void OpenWindow()
    {
        titleText.text = "Open Window";
        textObject.text = "You decide to play it safe and check out the Window.\n" +
            "It looks as if someone forgot to close this window.\n" +
            "You push it open further and peer outside... You can't see much.\n" +
            "You think you can see the ground below, maybe 15 feet down.\n" +
            "Should you jump?\n" +
            "Press J to Jump, N for Nurses Station";
        if (Input.GetKeyDown(KeyCode.J)) { currentState = States.jump; }
        if (Input.GetKeyDown(KeyCode.N)) { currentState = States.nurseStation; }
    }
    private void Jump()
    {
        titleText.text = "Geronimo!";
        textObject.text = "You decide to jump, anything to get outta this place!\n" +
            "Breathing heavily, you nervously stand in front of the window.\n" +
            "'FOR THE SHIRE!' You yell, as you fling your body out into the darkness.\n" +
            "Wind rushes agaisnt your face as you freefall down...\n" +
            "Press C to Continue...";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.win; }
    }
    private void Win()
    {
        titleText.text = "YOU WIN!!";
        textObject.text = "Right before you hit the ground, you suddenly jolt awake.\n" +
            "You're sitting in a chair, with wires connected all over your body.\n" +
            "Someone lifts a helmet visor off of your head, and you see men standing all around you.\n" +
            "'Congratulations, Soilder. You passed the simulation' An old man says as he claps you on the shoulder.\n" +
            "Welcome to Treadstone, Jason Bourne.";
    }
}
