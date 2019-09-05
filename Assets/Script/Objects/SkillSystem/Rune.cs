using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Rune{
    public enum RuneType { CONTROL, EFFECT, ENHANCE};

    private RuneType _runeType;
    public RuneType runeType { get { return _runeType; } }

    public List<Skill.Value> values = new List<Skill.Value>();

    public abstract void Effect();

}
