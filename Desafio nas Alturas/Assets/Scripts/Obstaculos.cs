﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    [SerializeField]

    private float velocidade = 0.2f;
    [SerializeField]

    private float variacaoDaPosicaoY;

    private Vector3 posicaoDoAviao;

    private Pontuacao pontuacao;

    private bool pontuei;

    void Start()
    {
        posicaoDoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
        pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }


    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        Destruir();
    }


     public void Destruir()
    {
        GameObject.Destroy(this.gameObject);
        Debug.Log("Colidiu");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * velocidade);
        if(!pontuei && this.transform.position.x < posicaoDoAviao.x)
        {
            pontuei = true;
            pontuacao.AdicionaPontos();
        }
    }
}
