import React, { useState } from "react";
import { useDispatch } from "react-redux";
import { useHistory } from "react-router";
import { Button, Typography, Box, CircularProgress } from "@mui/material";
import Paper from "@mui/material/Paper";
import TextField from "@mui/material/TextField";
import classes from "./Login.module.css";
import {
  generateLink,
  routesConfiguration as routes,
} from "../../Router/routes";
import { useMutation } from "react-query";
import { login } from "../../HttpRequests/LoginRequests";
import { saveToken } from "../../Redux/Actions/auth/auth";
import { Header } from "../Shared/Header";

export default function Login() {
  const history = useHistory();
  const dispatch = useDispatch();
  const [values, setValues] = useState({ username: "", password: "" });

  const submitLogin = useMutation(login, {
    onSuccess: (data) => {
      dispatch(saveToken(data.data));
      history.push(generateLink(routes.CATEGORIES));
    },
  });

  const handleFormChange = (e) => {
    setValues((prevState) => {
      return { ...prevState, [e.target.name]: e.target.value };
    });
  };

  return (
    <>
      <Header title="" />
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
          {submitLogin.isError && (
            <Typography
              variant="body2"
              sx={{ textAlign: "center", color: "red" }}
            >
              Invalid credentials
            </Typography>
          )}
          <Button
            onClick={() => {
              submitLogin.mutate(values);
            }}
          >
            Log in
          </Button>
        </form>
        {submitLogin.isLoading && (
          <Box sx={{ display: "flex" }}>
            <CircularProgress />
          </Box>
        )}
      </Paper>
    </>
  );
}
