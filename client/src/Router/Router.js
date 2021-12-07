import React from "react";
import { Switch, Route, Redirect } from "react-router-dom";
import isLoggedIn from "../Hooks/isLoggedIn";
import Login from "../Components/Login/Login";
import { Categories } from "../Components/Categories/Categories";
import { AddRecipe } from "../Components/Recipes/AddRecipe";
import { RecipeDetails } from "../Components/Recipes/RecipeDetails";
import { Recipes } from "../Components/Recipes/Recipes";
import { generateLink, routesConfiguration as routes } from "./routes";
import PrivateRoute from "./PrivateRoute";

export const Router = () => {
  return (
    <Switch>
      <Route
        exact
        path="/"
        render={() => {
          return isLoggedIn() ? (
            <Redirect to={generateLink(routes.CATEGORIES)} />
          ) : (
            <Login />
          );
        }}
      />
      <PrivateRoute
        path={generateLink(routes.RECIPES, { id: ":id" })}
        component={Recipes}
      />
      <PrivateRoute
        path={generateLink(routes.CATEGORIES)}
        component={Categories}
      />
      <PrivateRoute
        path={generateLink(routes.RECIPE_CREATE)}
        component={AddRecipe}
      />
      <PrivateRoute
        path={generateLink(routes.RECIPE_DETAILS, { id: ":id" })}
        component={RecipeDetails}
      />
    </Switch>
  );
};
