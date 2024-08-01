using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
      public float life = 3;
      
      void Awake() {
          Destroy(gameObject, life);
      }

      void OnCollisionEnter2D(Collision2D collision) {
          Destroy(collision.gameObject);
          Destroy(gameObject);
      }

}
