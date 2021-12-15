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
import { AddCategory } from "../Components/Categories/AddCategory";
import { CategoryDetails } from "../Components/Categories/CategoryDetails";
import { EditRecipe } from "../Components/Recipes/EditRecipe";
import { Ingredients } from "../Components/Ingredients/Ingredients";
import { CreateIngredient } from "../Components/Ingredients/CreateIngredient";
import { EditIngredient } from "../Components/Ingredients/EditIngredients";

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
        path={generateLink(routes.CATEGORY_CREATE)}
        component={AddCategory}
      />
      <Route
        exact
        path={generateLink(routes.RECIPES, { id: ":id" })}
        component={Recipes}
      />
      <PrivateRoute
        path={generateLink(routes.CATEGORY_DETAILS, { id: ":id" })}
        component={CategoryDetails}
      />
      <Route
        exact
        path={generateLink(routes.CATEGORIES)}
        component={Categories}
      />
      <PrivateRoute
        path={generateLink(routes.RECIPE_CREATE)}
        component={AddRecipe}
      />
      <PrivateRoute
        path={generateLink(routes.RECIPE_EDIT, { id: ":id" })}
        component={EditRecipe}
      />
      <Route
        exact
        path={generateLink(routes.RECIPE_DETAILS, { id: ":id" })}
        component={RecipeDetails}
      />
      <PrivateRoute
        path={generateLink(routes.INGREDIENTS_CREATE)}
        component={CreateIngredient}
      />
      <PrivateRoute
        path={generateLink(routes.INGREDIENTS_EDIT, { id: ":id" })}
        component={EditIngredient}
      />
      <PrivateRoute
        path={generateLink(routes.INGREDIENTS)}
        component={Ingredients}
      />
    </Switch>
  );
};
