using System.Collections.Generic; 
using System.Linq; 

namespace Terminal{ 
    public class VirtualFileSystem:Dictionary<string, Dictionary<string, object>>{
    }
    public class TerminalArt{
        public static string initConsole(){
        string cmd = @"   .-.
                        (o.o)
                        |=|
                        __|__
                    //.=|=.\\
                    // .=|=. \\
                    \\ .=|=. //
                    \\(_=_)//
                        (:| |:)
                        || ||
                        () ()
                        || ||
                        || ||
                    l42 ==' '==
                    SKULL -&- BONES OS
                    V SPOOKY
                    SYSTEM Init 2.0";
    return cmd;
        } 
    }
  public class Parser{
        public static string termParse(string s){
            //Parse commands for text based prompts and responses 
            if (s.Contains("telnet")){
                return @"CONNECTION='wired'
                        DESCRIPTION='BroadMau'
                        INTERFACE='eth0'
                        IP='static'
                        ADDR='10.10.10.5'
                        GATEWAY='10.10.10.1'
                        DNS='10.10.10.1'
                        WPA_DRIVER='wext'
                        NETCFG_DEBUG=yes

                        connection: Faild
                        ...";
            }
            else if (s.Equals("clear")){
                return "";
            }
            else if (s.Equals("help")){
                return @"telnet: access remote connections";
                        
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