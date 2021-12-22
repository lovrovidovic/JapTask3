import React from "react";
import AppBar from "@mui/material/AppBar";
import { useHistory } from "react-router";
import { useDispatch } from "react-redux";
import Box from "@mui/material/Box";
import Toolbar from "@mui/material/Toolbar";
import Typography from "@mui/material/Typography";
import IconButton from "@mui/material/IconButton";
import Button from "@mui/material/Button";
import { generateLink, routesConfiguration as routes } from "../../Router/routes";
import ArrowBackIosNewIcon from "@mui/icons-material/ArrowBackIosNew";
import { saveToken } from "../../Redux/Actions/auth/auth";
import useIsLoggedIn from "../../Hooks/useIsLoggedIn";

export const Header = ({ title }) => {
  const isLoggedIn = useIsLoggedIn();
  const history = useHistory();
  const dispatch = useDispatch();

  const logoutHandler = () => {
    dispatch(saveToken(null));
    history.push(generateLink(routes.LOGIN));
  };

  const goBackHandler = () => {
    history.goBack();
  };

  return (
    <Box sx={{ flexGrow: 1 }}>
      <AppBar position="static">
        <Toolbar variant="dense">
          <IconButton
            edge="start"
            color="inherit"
            aria-label="menu"
            sx={{ mr: 2 }}
            onClick={goBackHandler}>
            <ArrowBackIosNewIcon />
          </IconButton>
          <Typography variant="h5" component="div" edge="start" sx={{ flexGrow: 1 }}>
            {title}
          </Typography>
          <Box sx={{ display: { xs: "none", md: "flex" }, mr: 3 }}>
            <Button
              onClick={() => history.push(generateLink(routes.CATEGORIES))}
              sx={{ color: "white", display: "block" }}>
              Categories
            </Button>

            {isLoggedIn ? (
              <Button
                onClick={() => history.push(generateLink(routes.INGREDIENTS))}
                sx={{ color: "white", display: "block" }}>
                Ingredients
              </Button>
            ) : (
              <></>
            )}
          </Box>

          <Button variant="outlined" color="inherit" onClick={logoutHandler}>
            {isLoggedIn ? "Logout" : "Login"}
          </Button>
        </Toolbar>
      </AppBar>
    </Box>
  );
};
