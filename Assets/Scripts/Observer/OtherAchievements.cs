using System.Diagnostics;
using UnityEngine;

public class OtherAchievements : Subject
{
    void Update()
    {
        var enemy = GameObject.Find("Enemy");
        if (enemy!=null && enemy.GetComponent<Health>().currentHealth<=0 || enemy.GetComponent<Enemy>().health<=0)
        {
            Notify(1);
            Destroy(enemy.gameObject);
        }
        
    }
    
}
