# Prog6221-part-1-ST10089515 
# NB: CODE IS SAVED ON THE MASTER NOT MAIN BRANCH 
The Recipe class contains properties for the number of ingredients and steps, as well as two lists to store the actual ingredients and steps. It also has methods to add ingredients and steps, display the recipe, scale the recipe by a given factor, reset the quantities of the ingredients, and clear the recipe.

The Ingredient class has properties for the name, quantity, unit, original quantity, and meal of an ingredient.

In the Main method, the user is prompted to enter the meal name, number of ingredients, names of the ingredients, quantities, and units of measurement. The user is then prompted to enter the number of steps and a description of each step. The recipe is then displayed, and the user is prompted to enter a scaling factor. If the factor is valid, the recipe is scaled by the given factor and the scaled recipe is displayed.

Overall, this code provides a simple way for the user to create and manipulate a recipe.

The program starts by creating a new Recipe object called "recipe". This object will store all the ingredients and steps of the recipe that the user creates.

The user is then prompted to enter the meal name, number of ingredients, and information about each ingredient. For each ingredient, the user is asked to provide the name, quantity, and unit of measurement. This information is stored in an Ingredient object, which is then added to the recipe using the AddIngredient method.

Next, the user is prompted to enter the number of steps in the recipe and a description of each step. Each step is stored as a string in the recipe's Steps list using the AddStep method.

After the user has entered all the ingredients and steps, the program displays the entire recipe by calling the DisplayRecipe method of the Recipe object.

The user is then prompted to enter a scaling factor for the recipe. If the user enters a valid scaling factor (0.5, 2, or 3), the program calls the ScaleRecipe method of the Recipe object to scale the quantities of each ingredient by the given factor. The scaled recipe is then displayed using the DisplayRecipe method.

If the user enters an invalid scaling factor, the program simply displays an error message.

The program also includes other methods that allow the user to reset the ingredient quantities to their original values or to clear the entire recipe.