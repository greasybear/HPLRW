# HPLRW
<<<<<<< HEAD
New project GamePlayTest1 is the only valid scene right now, ignore GamePlayTes2 for now. Scripts will be in the main asset folder.

Some of those scripts are not attached to any game objects right now and were for testing purposes only.

https://www.reddit.com/r/Unity3D/comments/3u0dov/giveaway_i_made_a_quick_little_in_game_terminal/
```
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Terminal : MonoBehaviour {

public bool terminalActive;
public string terminalInput;
public InputField theField;
public string[] strArray;

void Update(){

////if the game hasn't started, don't allow terminal to be used
    if(!gameStarted)
    {
        return;
    }

    if(Input.GetKeyDown(KeyCode.BackQuote))
    {
        terminalActive = !terminalActive;
        ActivateTerminal(terminalActive);
    }
}   

void ActivateTerminal(bool on){

 ////tell the inputField animator it's time to get goin'
    UserInterface.theUI.terminalAnim.SetBool("isActive", on);
    if(on){

 ////disable character control, free up mouse, .
        GnomeAnimatorController.theController.inputController.controllable = false;
        Cursor.lockState = CursorLockMode.None;
        theField.ActivateInputField();

  ////get the carat blinking in the input field so user can type right away
        UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(
                               theField.gameObject, null);
        theField.OnPointerClick(
                             new UnityEngine.EventSystems.PointerEventData(
                                         UnityEngine.EventSystems.EventSystem.current));
        Cursor.visible = true;
    } 
    else
    {

  ////if turning off, do the opposite
        GnomeAnimatorController.theController.inputController.controllable = true;
        theField.DeactivateInputField();
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }
    terminalActive = on;
}

public Text text;


public void ProcessTerminalInput(){

  ////break the input into two pieces separating at the space
    string input = theField.text;
    strArray = theField.text.Split(" "[0]);
    string command = strArray[0];
    string value = "";
    if(strArray.Length > 1){
    value = strArray[1];
    }
    theField.text = "";

   /////Add whatever commands you want to in after the case.
    switch(command){
    case "loadlevel":
        if(value == "" || int.Parse(value) > 26 || int.Parse(value) < 3){
            UserInterface.theUI.StartCoroutine("QuickHint", "Usage: loadlevel [number 3-26]");
            UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(
                                        theField.gameObject, null);
            theField.OnPointerClick(
                                     new UnityEngine.EventSystems.PointerEventData(
                                              UnityEngine.EventSystems.EventSystem.current));
            break;
            }
        if(value != ""){
            UserInterface.theUI.StartCoroutine("QuickHint", "Loading Level " + value);
            UserInterface.theUI.StartCoroutine("LoadLevelFadeOut", int.Parse(value));
        }
        ActivateTerminal(false);
        break;

    case "refillmana":
        UserInterface.theUI.StartCoroutine("QuickHint", "Ok.");
        mpRemaining = totalMp;  
        ActivateTerminal(false);
        break;

    case "invincible":
        StartCoroutine("Invincibility");
        ActivateTerminal(false);
        break;

    case "help":
        UserInterface.theUI.StartCoroutine("QuickHint", "loadlevel [3-26], refillmana, invincible, refillberries, refillhealth, equipme, switchcolor, help, Ok?");
        UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(
                                theField.gameObject, null);
        theField.OnPointerClick(
                          new UnityEngine.EventSystems.PointerEventData(
                                   UnityEngine.EventSystems.EventSystem.current));
        break;

    case "refillberries":
        UserInterface.theUI.StartCoroutine("QuickHint", "Ok.");
        berriesRemaining = berryLimit;  
        ActivateTerminal(false);
        break;

    case "refillhealth":
        UserInterface.theUI.StartCoroutine("QuickHint", "Ok.");
        RestoreHealth(20);  
        ActivateTerminal(false);
        break;

    case "equipme":
        UserInterface.theUI.StartCoroutine("QuickHint", "Ok.");
        EquipMe();
        ActivateTerminal(false);
        break;

    case "switchcolor":

        ///limit value from 1 thru 5, if not valid, tell user how to use it.
        if(value == "" || int.Parse(value) > 5 || int.Parse(value) < 1){
            UserInterface.theUI.StartCoroutine("QuickHint", "Usage: switchcolor [number 1-5]");
            UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(
                                               theField.gameObject, null);
            theField.OnPointerClick(
                                   new UnityEngine.EventSystems.PointerEventData(
                                              UnityEngine.EventSystems.EventSystem.current));
            break;
        }
        UserInterface.theUI.StartCoroutine("QuickHint", "Ok.");
        SwitchColor(int.Parse(value));
        ActivateTerminal(false);
        break;

   ///default is what we tell the user when their input isn't in the switch statement (wrong entry, command not found)
    default:
        UserInterface.theUI.StartCoroutine("QuickHint", "I don't know what that means, try 'help.'");
        ActivateTerminal(false);
        break;
    }
   }
   }
```
=======

New project

GamePlayTest1 is the only valid scene right now.

Files right now are:

Editor:   Prefab controller scripts

Materials:  basic colors

Prefab_Imports:   more unity made scripts

Scenes
  
    GameplayeTest1:   data for the only scene
    
        Animations
    
        Lights

Scripts
    
    GamePlayScripts
    
    OldScripts: not being used and likely won't be
>>>>>>> origin/master
