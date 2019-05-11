using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    
    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        Debug.Log("Finalizar Jogo");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
