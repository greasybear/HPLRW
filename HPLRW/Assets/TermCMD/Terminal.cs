using System.Collections.Generic; 
using UnityEngine;
using System.Linq;


namespace Terminal{
    //public class Terminal : MonoBehaviour { public GameObject door; 
    public static class delayPrint{
        public static string[] cmds = { "telnet"};
    }
    public class VirtualFileSystem:Dictionary<string, Dictionary<string, object>>{
    }
    public class TerminalArt{
        public static string initConsole(){
        string cmd = @"
MOUNT fs / . . .
                    Initiated 
COM Check var/system/init.d 
Satalite A     . . . ESTABLISHED
Satalite B   . . . ESTABLISHED
Site Kadath     . . . ESTABLISHED
Site Hyperbora . . . ESTABLISHED 
Site Xaath     █ █ █  unknown

WELCOME TO
                                                                                                       
    _/      _/  _/      _/  _/_/_/_/_/  _/    _/                _/_/      _/_/_/   
   _/_/  _/_/    _/  _/        _/      _/    _/              _/    _/  _/          
  _/  _/  _/      _/          _/      _/_/_/_/              _/    _/    _/_/       
 _/      _/      _/          _/      _/    _/              _/    _/        _/      
_/      _/      _/          _/      _/    _/      _/        _/_/    _/_/_/         
a Samata-Albright venture:

";
                                                                            

                                                                             
        return cmd;
        }
    }

  public class Parser{
        public static string termParse(string s)
        
        {
            string[] s_arr = s.Split();
            //Parse commands for text based prompts and responses 
            if (s.Contains("telnet"))
            {
                return @"CONNECTION='wired'
                        DESCRIPTION='SatLINK'
                        INTERFACE='eth0'
                        IP='static'
                        ADDR='10.10.10.5'
                        GATEWAY='10.10.10.1'
                        ENDSAT=KADATH
                        NETCFG_DEBUG=yes
                        GEOMETRY=TETRAHED
                        

                        connection: Faild
                        ...";
            }
            else if (s.Equals("clear"))
            {
                return "";
            }
            else if (s.Equals("HELP"))
            {
                return @"
                telnet: access remote connections
                ls    : list the contents of the current directory
                magic : list of accessible objects
                magicrm objectName: remove object from telnet
                create cube: instantiate cube object
                elevator: deactivated";

            }
            else if (s.Equals("ls"))
            {
                string _s = string.Join("\n", FileSystem.ls(FileSystem.ROOT).ToArray());
                return _s;
            }
            else if (s.Equals("magic"))
            {
                GameObject fps = GameObject.Find("TerminalCamera");
                Inventory inventory = fps.GetComponent<Inventory>(); //need to find a way to properly access this script 


                return string.Join("\n",
             inventory.cliObjects.Select(edit => edit.name).ToArray());



            }
            else if (s.Equals("Please"))
            {
                return @"Ah ah ah, you didn't say the magic word!";
            }
            //else if (s.Equals("magicrm BlockingDoor"))
            //{

            //    GameObject door = GameObject.Find("BlockingDoor");

            //    door.SetActive(false);
            //    return @"Completed";
            //}

            else if (s_arr[0].Equals("magicrm"))  //&& s_arr[1] == Inventory) 
            {   
                GameObject door = GameObject.Find(s_arr[1]);

                door.SetActive(false);

                return @"removed";
            }
            else if (s.Equals("create cube"))
            {
                GameObject ladder = Object.Instantiate(Resources.Load("LadderCube")) as GameObject;
                
                return @"created";
            }
            else if (s.Equals ("activate elevator"))
            
            {   
                GameObject elevator = GameObject.Find("Elevator");
                ElevatorMover elevatormover = elevator.GetComponent<ElevatorMover>();
                elevatormover.enabled = true;

                return @"elevator activated";
               
            }
         
            //else if (s.Equals ("show walls"))
            //{ GameObject wall = GameObject.Find("ShadowMaze");
            //    Object shadows = Object.Fin("ShadowWall");

            //    return @"revealed";

            //}
            



            else {
                 return s;
              
            }
        }
    
    public static void engineParser(string s){

    }
    }
}