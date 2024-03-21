using UnityEngine;

[CreateAssetMenu(menuName = "Create GunData", fileName = "GunData", order = 0)]
public class GunData : ScriptableObject
{
    public string gunName;
    public float damage;
    public float fireRate;
    public float gunRange;
}