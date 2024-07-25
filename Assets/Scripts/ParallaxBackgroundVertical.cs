using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackgroundVertical : MonoBehaviour
{
    public float scrollSpeed = -2f;  // Velocidad base de desplazamiento
    public GameObject[] backgrounds; // Arreglo de fondos

    private float[] parallaxScales;  // Proporción de desplazamiento para cada fondo
    private float backgroundHeight;  // Altura de las imágenes de fondo

    void Start()
    {
        // Inicializar parallax scales basados en las posiciones z de los fondos
        parallaxScales = new float[backgrounds.Length];
        for (int i = 0; i < backgrounds.Length; i++)
        {
            parallaxScales[i] = backgrounds[i].transform.position.z * -1;
        }

        // Obtener la altura de las imágenes de fondo
        backgroundHeight = backgrounds[0].GetComponent<SpriteRenderer>().bounds.size.y;
    }

    void Update()
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {
            // Calcular desplazamiento parallax
            float parallax = (Time.time * scrollSpeed) * parallaxScales[i];
            Vector3 newPos = backgrounds[i].transform.position + Vector3.up * parallax * Time.deltaTime;

            // Reposicionar fondo si ha salido de la pantalla
            if (newPos.y >= backgroundHeight)
            {
                newPos = new Vector3(newPos.x, newPos.y - backgroundHeight * backgrounds.Length, newPos.z);
            }

            backgrounds[i].transform.position = newPos;
        }
    }
}