using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMovimiento : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento

    private Camera mainCamera;
    private float cameraWidth;
    private float cameraHeight;

    void Start()
    {
        mainCamera = Camera.main;
        if (mainCamera == null)
        {
            Debug.LogError("No se encontró la cámara principal.");
            return;
        }

        // Obtener el tamaño de la cámara en unidades del mundo
        // Calcular el tamaño de la cámara basado en el aspecto y tamaño de la pantalla
        cameraHeight = 2f * mainCamera.orthographicSize;
        cameraWidth = cameraHeight * mainCamera.aspect;
    }

    void Update()
    {
        // Movimiento del sprite con las teclas W, A, S, D
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        Vector3 newPosition = transform.position + movement * speed * Time.deltaTime;

        // Restringir el movimiento dentro de los límites de la cámara
        Vector3 cameraBottomLeft = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane));
        Vector3 cameraTopRight = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, mainCamera.nearClipPlane));

        float clampedX = Mathf.Clamp(newPosition.x, cameraBottomLeft.x, cameraTopRight.x);
        float clampedY = Mathf.Clamp(newPosition.y, cameraBottomLeft.y, cameraTopRight.y);

        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}