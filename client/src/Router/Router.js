import React from "react";
import { Switch, Route, Redirect } from "react-router-dom";
import useIsLoggedIn from "../Hooks/useIsLoggedIn";
import Login from "../Components/Login/Login";
import { Categories } from "../Components/Categories/Categories";
import { AddRecipe } from "../Components/Recipes/AddRecipe";
import { RecipeDetails } from "../Components/Recipes/RecipeDetails";
import { Recipes } from "../Components/Recipes/Recipes";
import { generateLink, routesConfiguration as routes } from "./routes";
import PrivateRoute from "./PrivateRoute";

export const Router = () => {
  const isLoggedIn = useIsLoggedIn();

  return (
    <Switch>
      <Route
        exact
        path="/"
        render={() => {
          return isLoggedIn ? (
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
        isAdminRoute={true}
      />
      <PrivateRoute
        path={generateLink(routes.RECIPE_DETAILS, { id: ":id" })}
        component={RecipeDetails}
      />
    </Switch>
  );
};
