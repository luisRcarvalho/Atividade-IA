using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAmovement : MonoBehaviour
{
    public float movespeed = 5;
    Vector3 finalpos;
    public GameObject posfinal;
    void Start()
    {
        finalpos = posfinal.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, finalpos, movespeed * Time.deltaTime);
    }
}
