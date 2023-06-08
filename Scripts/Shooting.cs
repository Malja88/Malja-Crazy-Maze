using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;
    [SerializeField] float interval;
    float timer;
    public void Shoot()
    {
        Instantiate(bullet, firePoint.position, Quaternion.Euler(0,-90,0));
    }
    void Update()
    {
        BulletTimer();
    }

    public void BulletTimer()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            Shoot();
            timer -= interval;
        }
    }
}
