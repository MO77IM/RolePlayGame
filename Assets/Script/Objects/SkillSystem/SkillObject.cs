using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillObject : MonoBehaviour
{
    public enum Trigger { TOUCH, TIME, DISTANCE, CLICK}

    public Vector3 dir;

    public float speed;
    public float size;
    public Trigger trigger;
    public float lastTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
