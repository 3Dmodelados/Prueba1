using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarDano : MonoBehaviour
{
    public float cantidadDano;
    public Vida vida;

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player"))
        {
            vida.TomarVida(cantidadDano);
        }
    }
}
