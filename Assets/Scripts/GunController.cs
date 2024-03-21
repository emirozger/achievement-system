using System;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Camera fpsCamera;
    private float range;
    private float damage;
    private float fireRate;
    private float nextTimeToFire = 0f;

    [SerializeField]private GunData data;
    private void Start()
    {
        damage = data.damage;
        fireRate = data.fireRate;
        range = data.gunRange;
        
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
        {
            GameObject bullet = BulletPool.Instance.GetBullet();
            bullet.transform.position = hit.point; 
            bullet.SetActive(true);
            Destroy(bullet, 1f);

            Health targetHealth = hit.transform.GetComponent<Health>();
            if (targetHealth != null)
            {
                targetHealth.TakeDamage(damage);
            }
        }
    }

}