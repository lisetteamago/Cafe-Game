using UnityEngine;

[System.Serializable]
public class RecipeStep
{
    [Header("Step Info")]
    public string stepName = "New Step";
    public StationType requiredStation;
}

public enum StationType
{
    Grinder,
    CoffeeMachine,
    SteamWand,
    Counter
}