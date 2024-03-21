using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public static BulletPool Instance { get; private set; }
    public GameObject bulletPrefab;
    private Queue<GameObject> bullets = new Queue<GameObject>();

    void Awake()
    {
        Instance = this;
        AddBullets(5); 
    }

    public GameObject GetBullet()
    {
        if (bullets.Count == 0)
            AddBullets(10);
        return bullets.Dequeue();
    }

    private void AddBullets(int count)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.SetActive(false);
            bullets.Enqueue(bullet);
        }
    }

    public void ReturnBullet(GameObject bullet)
    {
        bullet.SetActive(false);
        bullets.Enqueue(bullet);
    }
}
