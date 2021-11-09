import React from "react";
import AppBar from "@mui/material/AppBar";
import Box from "@mui/material/Box";
import Toolbar from "@mui/material/Toolbar";
import Typography from "@mui/material/Typography";
import IconButton from "@mui/material/IconButton";
import Button from "@mui/material/Button";

export const Header = ({ title }) => {
  const logoutHandler = () => {
    console.log("logged out")
  }

  return (
    <Box sx={{ flexGrow: 1 }}>
      <AppBar position="static">
        <Toolbar variant="dense">
          <IconButton
            edge="start"
            color="inherit"
            aria-label="menu"
            sx={{ mr: 2 }}
          ></IconButton>
          <Typography
            variant="h6"
            component="div"
            edge="start"
            sx={{ flexGrow: 1 }}
          >
            {title}
          </Typography>
          <Button color="inherit" onClick={logoutHandler}>Logout</Button>
        </Toolbar>
      </AppBar>
    </Box>
  );
};
