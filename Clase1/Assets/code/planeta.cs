﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeta : MonoBehaviour
{
    public string planetName;
    public float speed;
    public int radio;
    public float actualPos;

    public float newx, newz;

    public GameObject sol;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Este planeta se llama: " + planetName);
    }

    // Update is called once per frame
    void Update()
    {
        actualPos += Time.deltaTime * speed;

        newx = sol.transform.position.x + radio * Mathf.Cos(actualPos);
        newz = sol.transform.position.z + radio * Mathf.Sin(actualPos);
        transform.position = new Vector3(newx,transform.position.y,newz);

    }
}