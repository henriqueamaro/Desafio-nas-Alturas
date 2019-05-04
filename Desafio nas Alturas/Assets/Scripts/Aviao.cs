using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{

    Rigidbody2D fisica;

    private void Awake()
    {
        
        {
            //Debug.log("Acordei")
            this.fisica = this.GetComponent<Rigidbody2D>();
        }
    }

    private void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
    }



    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Impulsionar();

        }
    }
}
