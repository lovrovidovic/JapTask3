import React from "react";
import { Route, Redirect } from "react-router-dom";
import { generateLink, routesConfiguration as routes } from "./routes";
import useIsLoggedIn from "../Hooks/useIsLoggedIn";

export default function PrivateRoute({ component: Component, path }) {
  const isLoggedIn = useIsLoggedIn();
  return (
    <Route
      exact
      path={path}
      render={(props) => {
        return isLoggedIn ? (
          <Component {...props} />
        ) : (
          <Redirect to={generateLink(routes.LOGIN)} />
        );
      }}
    />
  );
}
