using UnityEngine;

[CreateAssetMenu(fileName = "New Station Config", menuName = "Coffee Game/Station Config")]
public class StationConfig : ScriptableObject
{
    public StationType stationType = StationType.Counter;
}