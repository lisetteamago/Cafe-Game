using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Coffee Recipe", menuName = "Coffee Game/Recipe")]
public class CoffeeRecipe : ScriptableObject
{
    public string coffeeName = "New Coffee";
    public List<RecipeStep> steps = new List<RecipeStep>();
}