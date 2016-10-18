using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class FileSystem {
    static public string ROOT = Application.persistentDataPath + "/ROOT";


    public static IEnumerable<string> ls(string path){
        IEnumerable<string> files = Directory.GetFiles(path)
            .Select(i => formatter(i, Application.persistentDataPath)); 
        
        IEnumerable<string> dirs = Directory.GetDirectories(path)
            .Select(i => formatter(i, Application.persistentDataPath));

        return files.Concat(dirs); 
    }
    
     public static string formatter(string s, string a ){
        var x =  s.Split('/').Except(a.Split('/'));
		return string.Join("/", x.ToArray()); 

    }




}
