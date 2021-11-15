import React, { useState } from "react";
import { useHistory } from "react-router";
import useHttp from "../../Hooks/useHttp";
import { Button, Typography, Box, CircularProgress } from "@mui/material";
import Paper from "@mui/material/Paper";
import TextField from "@mui/material/TextField";
import classes from "./Login.module.css";
import {
  generateLink,
  routesConfiguration as routes,
} from "../../Router/routes";

export const Login = () => {
  const history = useHistory();
  const [values, setValues] = useState({ username: "", password: "" });
  const { isLoading, error, sendRequest, responseData } = useHttp();

  const handleFormChange = (e) => {
    setValues((prevState) => {
      return { ...prevState, [e.target.name]: e.target.value };
    });
  };

  const onLoginSuccess = (data) => {
    localStorage.setItem("token", JSON.stringify(data));
    history.push(generateLink(routes.CATEGORIES));
  };

  const loginHandler = () => {
    sendRequest({
      method: "POST",
      url: "/login",
      data: values,
      additionalFunc: onLoginSuccess,
    });
  };

  return (
    <Paper className={classes.paper}>
      <form className={classes.form}>
        <Typography variant="h5" sx={{ textAlign: "center" }}>
          LOGIN
        </Typography>
        <TextField
          label="Username: "
          variant="standard"
          name="username"
          value={values.username}
          onChange={handleFormChange}
        />
        <TextField
          type="password"
          label="Password: "
          variant="standard"
          name="password"
          value={values.password}
          onChange={handleFormChange}
        />
        {error && (
          <Typography
            variant="body2"
            sx={{ textAlign: "center", color: "red" }}
          >
            Invalid credentials
          </Typography>
        )}
        <Button onClick={loginHandler}>Log in</Button>
      </form>
      {isLoading && !error && (
        <Box sx={{ display: "flex" }}>
          <CircularProgress />
        </Box>
      )}
    </Paper>
  );
};
