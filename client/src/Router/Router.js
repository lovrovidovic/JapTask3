import React from "react";
import { Switch, Route } from "react-router-dom";
import { Categories } from "../Components/Categories/Categories";
import { Login } from '../Components/Login/Login'
import { AddRecipe } from "../Components/Recipes/AddRecipe";
import { RecipeDetails } from "../Components/Recipes/RecipeDetails";
import { Recipes } from "../Components/Recipes/Recipes";

export const Router = () => {
  return (
    <Switch>
      <Route exact path="/">
        <Login />
      </Route>
      <Route exact path="/categories">
        <Categories />
      </Route>
      <Route exact path="/recipes">
        <Recipes />
      </Route>
      <Route exact path="/recipes/:id">
        <RecipeDetails />
      </Route>
      <Route exact path="/recipes/add">
        <AddRecipe />
      </Route>
    </Switch>
  );
};
