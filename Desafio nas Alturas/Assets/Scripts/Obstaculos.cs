﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    [SerializeField]

    private float velocidade = 0.2f;
    [SerializeField]

    private float variacaoDaPosicaoY;

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        Destruir();
    }


    private void Destruir()
    {
        GameObject.Destroy(this.gameObject);
        //Debug.Log("C");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * velocidade);
    }
}
