import { generatePath } from "react-router";
import Login from "../Components/Login/Login";
import { AddRecipe } from "../Components/Recipes/AddRecipe";
import { RecipeDetails } from "../Components/Recipes/RecipeDetails";
import { Recipes } from "../Components/Recipes/Recipes";
import { Categories } from "../Components/Categories/Categories";

const routesConfiguration = {
  LOGIN: {
    id: "LOGIN",
    path: "/",
    Component: Login,
  },
  RECIPES: {
    id: "RECIPES",
    path: "/categories/:id",
    Component: Recipes,
  },
  RECIPE_DETAILS: {
    id: "RECIPE_DETAILS",
    path: "/recipes/:id",
    Component: RecipeDetails,
  },
  RECIPE_CREATE: {
    id: "RECIPE_CREATE",
    path: "/recipes/create",
    Component: AddRecipe,
  },
  CATEGORIES: {
    id: "CATEGORIES",
    path: "/categories",
    Component: Categories,
  },
};

function generateLink(routeOrRouteId, params) {
  let route;
  if (typeof routeOrRouteId.id === "string") {
    route = routesConfiguration[routeOrRouteId.id];
  }
  if (!route) {
    console.error(
      `Route not found error. Can't generate link for unknown route ${routeOrRouteId}`
    );
    return "#";
  }
  return generatePath(route.path, params);
}

export { routesConfiguration, generateLink };
