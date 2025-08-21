using UnityEngine;

[System.Serializable]
public class CoffeeOrder
{
    public CoffeeRecipe recipe;
    public int currentStepIndex = 0;
    public OrderStatus status = OrderStatus.InProgress;
    
    public CoffeeOrder(CoffeeRecipe recipe)
    {
        this.recipe = recipe;
    }
    
    public RecipeStep GetCurrentStep()
    {
        if (currentStepIndex >= recipe.steps.Count)
            return null;
        
        return recipe.steps[currentStepIndex];
    }
    
    public bool IsComplete()
    {
        return currentStepIndex >= recipe.steps.Count;
    }
    
    public void CompleteCurrentStep()
    {
        currentStepIndex++;
        
        if (IsComplete())
        {
            status = OrderStatus.Complete;
            Debug.Log("Order completed!");
        }
    }
}

public enum OrderStatus
{
    InProgress,
    Complete,
    Failed
}