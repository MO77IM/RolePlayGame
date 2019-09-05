using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float v = 0f;
    private float h = 0f;

    private float _speed = 0.1f;
    private List<Skill> skills = new List<Skill>();
   
    public float speed
    {
        get
        {
            return _speed;
        }
        set
        {
            _speed = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxisRaw("Vertical");
        h = Input.GetAxisRaw("Horizontal");
        Vector3 distance = new Vector3(h, v, 0);
        distance = speed * distance.normalized;
        transform.Translate(distance);
    }
}
