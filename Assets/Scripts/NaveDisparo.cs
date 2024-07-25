using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveDisparo : MonoBehaviour
{
    public Disparo balaPrefab;
    
    public Disparo velocidadPrefab;


    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Bala();
        }
        if (Input.GetMouseButtonDown(1)) {
            Velocidad();
        }



    }


    private void Bala() {
        Instantiate(this.balaPrefab, this.transform.position, Quaternion.identity);

    }
    private void Velocidad() {
        Instantiate(this.velocidadPrefab, this.transform.position, Quaternion.identity);

    }


}
