using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script
{
    private int currentLine;
    
    private List<string> script;

    public object obj;

    //public bool isExecuting { get; set; }

    public Script(string script, object obj)
    {
        currentLine = 0;
        this.script = new List<string>(script.Split('\n'));
    }

    public string[] GetCommand()
    {
        return script[currentLine++].Split('\n');
    }
}
