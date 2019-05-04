﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{

    Rigidbody2D fisica;
    [SerializeField]

    private float forca = 10f;
    private void Awake()
    {
        
        {
            //Debug.log("Acordei")
            this.fisica = this.GetComponent<Rigidbody2D>();
        }
    }

    private void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }



    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Impulsionar();

        }
    }
}
