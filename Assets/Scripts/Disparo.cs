using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{   
    public Vector3 direction;

    public float speed;

    // Update is called once per frame
    private void Update()
    {

        this.transform.position += this.direction * this.speed * Time.deltaTime;
    }

}
