﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    [SerializeField]

    private float velocidade = 0.1f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * velocidade);
    }
}
