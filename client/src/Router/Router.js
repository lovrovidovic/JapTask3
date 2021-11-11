import React from "react";
import { Switch, Route } from "react-router-dom";
import { Categories } from "../Components/Categories/Categories";
import { Login } from '../Components/Login/Login'
import { AddRecipe } from "../Components/Recipes/AddRecipe";
import { RecipeDetails } from "../Components/Recipes/RecipeDetails";
import { Recipes } from "../Components/Recipes/Recipes";
import { routesConfiguration as routes} from './routes'

export const Router = () => {
  return (
    <Switch>
      <Route exact path={routes.LOGIN.path}>
        <Login />
      </Route>
      <Route exact path={routes.CATEGORIES.path}>
        <Categories />
      </Route>
      <Route exact path={routes.RECIPE_CREATE.path}>
        <AddRecipe />
      </Route>
      <Route exact path={routes.RECIPE_DETAILS.path}>
        <RecipeDetails />
      </Route>
      <Route exact path={routes.RECIPES.path}>
        <Recipes />
      </Route>     
    </Switch>
  );
};
