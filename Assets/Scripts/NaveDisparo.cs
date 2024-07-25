using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveDisparo : MonoBehaviour
{
    public Disparo balaPrefab;
    

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Bala();
        }

    }


    private void Bala() {
        Instantiate(this.balaPrefab, this.transform.position, Quaternion.identity);

    }

}
