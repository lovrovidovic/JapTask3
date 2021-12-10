import React from "react";
import { Route, Redirect } from "react-router-dom";
import { generateLink, routesConfiguration as routes } from "./routes";
import useIsLoggedIn from "../Hooks/useIsLoggedIn";
import useIsAdmin from "../Hooks/useIsAdmin";

export default function PrivateRoute({ component: Component, path, isAdminRoute }) {
  const isLoggedIn = useIsLoggedIn();
  const isAdmin = useIsAdmin();
  return (
    <Route
      exact
      path={path}
      render={(props) => {
        return (isAdminRoute ? isAdmin : isLoggedIn) ? (
          <Component {...props} />
        ) : (
          <Redirect to={generateLink(routes.LOGIN)} />
        );
      }}
    />
  );
}
