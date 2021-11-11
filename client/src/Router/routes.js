import { generatePath } from "react-router";

const routesConfiguration = {
  LOGIN: {
    id: "LOGIN",
    path: "/",
  },
  CATEGORIES: {
    id: "CATEGORIES",
    path: "/categories",
  },
  RECIPES: {
    id: "RECIPES",
    path: "/categories/:id",
  },
  RECIPE_DETAILS: {
    id: "RECIPE_DETAILS",
    path: "/recipes/:id",
  },
  RECIPE_CREATE: {
    id: "RECIPE_CREATE",
    path: "/recipes/create",
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
