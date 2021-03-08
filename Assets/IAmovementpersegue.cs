using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAmovementpersegue : MonoBehaviour
{
    public Transform player;
    public float movespeed = 5f;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, movespeed * Time.deltaTime);
    }
}
