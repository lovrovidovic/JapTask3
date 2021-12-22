import { generatePath } from "react-router";
import Login from "../Components/Login/Login";
import { AddRecipe } from "../Components/Recipes/AddRecipe";
import { RecipeDetails } from "../Components/Recipes/RecipeDetails";
import { Recipes } from "../Components/Recipes/Recipes";
import { Categories } from "../Components/Categories/Categories";
import { AddCategory } from "../Components/Categories/AddCategory";
import { CategoryDetails } from "../Components/Categories/CategoryDetails";
import { EditRecipe } from "../Components/Recipes/EditRecipe";
import { Ingredients } from "../Components/Ingredients/Ingredients";
import { CreateIngredient } from "../Components/Ingredients/CreateIngredient";
import { EditIngredient } from "../Components/Ingredients/EditIngredients";

const routesConfiguration = {
  LOGIN: {
    id: "LOGIN",
    path: "/",
    Component: Login,
  },
  RECIPES: {
    id: "RECIPES",
    path: "/categories/:id/recipes",
    Component: Recipes,
  },
  RECIPE_DETAILS: {
    id: "RECIPE_DETAILS",
    path: "/recipes/:id",
    Component: RecipeDetails,
  },
  RECIPE_EDIT: {
    id: "RECIPE_EDIT",
    path: "/recipes/:id/edit",
    Component: EditRecipe,
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
  CATEGORY_CREATE: {
    id: "CATEGORY_CREATE",
    path: "/categories/create",
    Component: AddCategory,
  },
  CATEGORY_DETAILS: {
    id: "CATEGORY_DETAILS",
    path: "/categories/:id/edit",
    Component: CategoryDetails,
  },
  INGREDIENTS: {
    id: "INGREDIENTS",
    path: "/ingredients",
    Component: Ingredients,
  },
  INGREDIENTS_CREATE: {
    id: "INGREDIENTS_CREATE",
    path: "/ingredients/create",
    Component: CreateIngredient,
  },
  INGREDIENTS_EDIT: {
    id: "INGREDIENTS_EDIT",
    path: "/ingredients/:id",
    Component: EditIngredient,
  },
};

function generateLink(routeOrRouteId, params) {
  let route;
  if (typeof routeOrRouteId.id === "string") {
    route = routesConfiguration[routeOrRouteId.id];
  }
  if (!route) {
    console.error(`Route not found error. Can't generate link for unknown route ${routeOrRouteId}`);
    return "#";
  }
  return generatePath(route.path, params);
}

export { routesConfiguration, generateLink };
