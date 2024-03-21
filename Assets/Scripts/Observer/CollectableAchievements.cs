using UnityEngine;

public class CollectableAchievements: Subject
{
    [SerializeField]
    private int ID;

    private void OnTriggerEnter(Collider collision)
    {
        Notify(ID);
        Destroy(this.gameObject,.1f);
    }
}
