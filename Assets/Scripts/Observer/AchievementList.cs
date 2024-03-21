using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Achievement")]
public class AchievementList : ScriptableObject
{
    public List<AchievementData> achievements;
}