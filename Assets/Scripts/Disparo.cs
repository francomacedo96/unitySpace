using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public Transform bulletSpawnPointTwo;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;



    void Update() {
        if(Input.GetButtonDown("Fire1")) {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity= bulletSpawnPoint.up * bulletSpeed;

            var bulletTwo = Instantiate(bulletPrefab, bulletSpawnPointTwo.position, bulletSpawnPointTwo.rotation);
            bulletTwo.GetComponent<Rigidbody2D>().velocity= bulletSpawnPointTwo.up * bulletSpeed;
        }
    }

}
