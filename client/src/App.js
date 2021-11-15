import "./App.css";
import { Switch, Route, Redirect } from "react-router";
import isLoggedIn from "./Hooks/isLoggedIn";
import { Router } from "./Router/Router";
import { generateLink, routesConfiguration as routes } from "./Router/routes";
import { Login } from "./Components/Login/Login";
function App() {
  return (
    <div className="App">
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
      </Switch>
      <Router />
    </div>
  );
}

export default App;
