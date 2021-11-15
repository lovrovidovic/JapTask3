import React from "react";
import AppBar from "@mui/material/AppBar";
import { useHistory } from "react-router";
import Box from "@mui/material/Box";
import Toolbar from "@mui/material/Toolbar";
import Typography from "@mui/material/Typography";
import IconButton from "@mui/material/IconButton";
import Button from "@mui/material/Button";
import {
  generateLink,
  routesConfiguration as routes,
} from "../../Router/routes";
import ArrowBackIosNewIcon from "@mui/icons-material/ArrowBackIosNew";

export const Header = ({ title }) => {
  const history = useHistory();
  const logoutHandler = () => {
    localStorage.removeItem("token");
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
            onClick={goBackHandler}
          >
            <ArrowBackIosNewIcon />
          </IconButton>
          <Typography
            variant="h6"
            component="div"
            edge="start"
            sx={{ flexGrow: 1 }}
          >
            {title}
          </Typography>
          <Button color="inherit" onClick={logoutHandler}>
            Logout
          </Button>
        </Toolbar>
      </AppBar>
    </Box>
  );
};
