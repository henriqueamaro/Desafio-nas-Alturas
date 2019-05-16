using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    public GameObject imagemGameOver;
    [SerializeField]
    private Aviao avião;

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        imagemGameOver.SetActive(true);
        Debug.Log("Finalizar Jogo");
    }
    // Start is called before the first frame update
    void Start()
    {
        avião = GameObject.FindObjectOfType<Aviao>();
    }


    public void ReiniciarJogo()
    {
        //avião = GameObject.FindObjectOfType<Aviao>();

        avião.Reniciar();
        imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        //Destruir os obstaculos
        Debug.Log("Reiniciou");
    }
    
    private void DestruirObstaculos()
    {
        Obstaculos[] obstaculosEncontrados = GameObject.FindObjectsOfType<Obstaculos>();
        foreach(Obstaculos obstaculoAtual in obstaculosEncontrados)
        {
            obstaculoAtual.Destruir();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
