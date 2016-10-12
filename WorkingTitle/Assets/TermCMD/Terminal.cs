using System.Collections.Generic; 
using System.Linq; 

namespace Terminal{ 
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
a Samata-Albright venture:";
                                                                            

                                                                             
        return cmd;
        }
    }

  public class Parser{
        public static string termParse(string s){
            //Parse commands for text based prompts and responses 
            if (s.Contains("telnet")){
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
            else if (s.Equals("clear")){
                return "";
            }
            else if (s.Equals("help")){
                return @"
                telnet: access remote connections
                ls    : list the contents of the current directory";
                        
            }
            else if (s.Equals("ls")){
                string _s = string.Join("\n", FileSystem.ls(FileSystem.ROOT).ToArray()); 
                return _s; 
            }

            else{
                return s;
            }
        }
    
    public static void engineParser(string s){

    }
    }
}