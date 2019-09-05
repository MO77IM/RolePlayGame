using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : MonoBehaviour
{

    /******Value类用于描述技能中所有类型的数值******/
    public class Value
    {
        enum ValueType { EFFECT, TIME, NUM}

        public float value;

        private string _description;
        public string description { get { return _description; } }

        public Value(float value, string _description = "")
        {
            this.value = value;
            this._description = _description;
        }
    }


    private int _maxEffectRuneNum;
    
    public int maxEffectRuneNum
    {
        get { return _maxEffectRuneNum; }
        set { _maxEffectRuneNum = value; }
    }

    public Rune controlRune;
    public List<Rune> effectRunes = new List<Rune>();

    public abstract void OnUse();
}
