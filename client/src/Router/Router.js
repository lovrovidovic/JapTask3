import React from "react";
import { Switch } from "react-router-dom";
import { Categories } from "../Components/Categories/Categories";
import { AddRecipe } from "../Components/Recipes/AddRecipe";
import { RecipeDetails } from "../Components/Recipes/RecipeDetails";
import { Recipes } from "../Components/Recipes/Recipes";
import { routesConfiguration as routes } from "./routes";
import PrivateRoute from "./PrivateRoute";

export const Router = () => {
  return (
    <Switch>
      <PrivateRoute path={routes.RECIPES.path} component={Recipes} />
      <PrivateRoute path={routes.CATEGORIES.path} component={Categories} />
      <PrivateRoute path={routes.RECIPE_CREATE.path} component={AddRecipe} />
      <PrivateRoute
        path={routes.RECIPE_DETAILS.path}
        component={RecipeDetails}
      />
    </Switch>
  );
};
