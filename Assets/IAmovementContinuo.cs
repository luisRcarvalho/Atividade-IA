using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAmovementContinuo : MonoBehaviour
{
    public float movespeed = 5;
    public GameObject [] posfinal = new GameObject[5];
    int index = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, posfinal[index].transform.position, movespeed * Time.deltaTime);

        if (transform.position == posfinal[index].transform.position)
        {
            index++;
        }


        if (index == posfinal.Length)
        {
            index = 0;
        }
    }
}
