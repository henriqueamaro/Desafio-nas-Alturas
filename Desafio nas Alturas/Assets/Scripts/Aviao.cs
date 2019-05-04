using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{

    Rigidbody2D fisica;

    private void Awake()
    {
        
        {
            this.fisica = this.GetComponent<Rigidbody2D>();
        }
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Clicou");
        }
    }
}
