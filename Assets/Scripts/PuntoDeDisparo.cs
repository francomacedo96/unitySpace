using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Transform puntoDeDisparo;
    public Transform puntoDeDisparoDos;
    public GameObject balaPrefab;
    public float balaVelocidad = 10;



    void Update() {
        if(Input.GetButtonDown("Fire1")) {
            var bala = Instantiate(balaPrefab, puntoDeDisparo.position, puntoDeDisparo.rotation);
            bala.GetComponent<Rigidbody2D>().velocity= puntoDeDisparo.up * balaVelocidad;

            var balaDos = Instantiate(balaPrefab, puntoDeDisparoDos.position, puntoDeDisparoDos.rotation);
            balaDos.GetComponent<Rigidbody2D>().velocity= puntoDeDisparoDos.up * balaVelocidad;
        }
    }

}
