using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Recipe
{
    //an array to store the number 
    public int NumIngredients { get; set; }
    // an array list to store the ingredients 
    public List<Ingredient> Ingredients { get; set; }

    // an array to store the number of steps 
    public int NumSteps { get; set; }

    // an arrayList to store the steps
    public List<string> Steps { get; set; }

    public Recipe()
    {
        Ingredients = new List<Ingredient>();
        Steps = new List<string>();
    }

    public void AddIngredient(string name, double quantity, string unit, string meal)
    {
        Ingredients.Add(new Ingredient(name, quantity, unit, meal));
    }

    public void AddStep(string description)
    {
        Steps.Add(description);
    }

    public void DisplayRecipe()
    {
        Console.WriteLine("Ingredients:");
        foreach (Ingredient ingredient in Ingredients)
        {

            Console.WriteLine("{0} {1} {2}", ingredient.Quantity, ingredient.Unit, ingredient.Name);
        }

        Console.WriteLine("\nSteps:");
        for (int i = 0; i < Steps.Count; i++)
        {
            Console.WriteLine("{0}. {1}", i + 1, Steps[i]);
        }
    }

    public void ScaleRecipe(double factor)
    {
        foreach (Ingredient ingredient in Ingredients)
        {
            ingredient.Quantity *= factor;
        }
    }

    public void ResetQuantities()
    {
        foreach (Ingredient ingredient in Ingredients)
        {
            ingredient.Quantity = ingredient.OriginalQuantity;
        }
    }
    // clearing the all the ingredients and recipes 
    public void ClearRecipe()
    {
        Ingredients.Clear();
        Steps.Clear();


    }
}

class Ingredient
{
    public string Name { get; set; }
    public double Quantity { get; set; }
    public string Unit { get; set; }
    public double OriginalQuantity { get; set; }

    public string meal { get; set; }

    public Ingredient(string name, double quantity, string unit, string meal)
    {
        Name = name;
        Quantity = quantity;
        Unit = unit;
        OriginalQuantity = quantity;
        meal = meal;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Recipe recipe = new Recipe();

        // Get number of ingredients and add them to the recipe

        Console.WriteLine("Enter meal name");
        string meal = Console.ReadLine();
        //exception handling 
        try
        {
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());
            recipe.NumIngredients = numIngredients;
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("\nNumber Of Ingredient {0}", i + 1);
                Console.Write("Name Of Ingredients: ");
                string name = Console.ReadLine();
                Console.Write("Quantity Of Each Ingredient: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit Of Measurement: ");
                string unit = Console.ReadLine();
                recipe.AddIngredient(name, quantity, unit, meal);
            }

        }

        catch (FormatException e)
        {

            Console.WriteLine("Please enter a number e.g. 5");



        }


        // Get number of steps and add them to the recipe
        try
        {
            Console.Write("\nEnter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());
            recipe.NumSteps = numSteps;

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("\nStep {0}", i + 1);
                Console.Write("Description: ");
                string description = Console.ReadLine();
                recipe.AddStep(description);
            }
        }
        catch (FormatException e)
        {

            Console.WriteLine("Please enter an integer ");



        }

        // Display the recipe
        Console.WriteLine("\nRecipe:" + meal);
        recipe.DisplayRecipe();

        // Scale the recipe
        Console.Write("\nEnter a scaling factor (0.5, 2, 3): ");
        double factor = double.Parse(Console.ReadLine());

        if (factor == 0.5 || factor == 2 || factor == 3)
        {
            recipe.ScaleRecipe(factor);
            Console.WriteLine("\nScaled Recipe:");
            recipe.DisplayRecipe();
        }
        else
        {
            Console.WriteLine("\nInvalid scaling factor.");
        }
    }

}



