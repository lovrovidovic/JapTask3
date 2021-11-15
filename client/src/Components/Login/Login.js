import React, { useState } from "react";
import useHttp from "../../Hooks/useHttp";
import { Button } from "@mui/material";
import { useHistory } from "react-router-dom";
import Paper from "@mui/material/Paper";
import TextField from "@mui/material/TextField";
import isLoggedIn from "../../Hooks/isLoggedIn";

export const Login = () => {
  const [values, setValues] = useState({ username: "", password: "" });
  const history = useHistory();

  const { isLoading, error, sendRequest, responseData } = useHttp();

  const handleFormChange = (e) => {
    setValues((prevState) => {
      return { ...prevState, [e.target.name]: e.target.value };
    });
  };

  const loginHandler = () => {
    sendRequest({ method: "POST", url: "/login", data: values });
    setTimeout(() => onLoginSuccess(), [1000])
  };

  const onLoginSuccess = () => {
    if (isLoggedIn()) history.push("/categories");
  };

  return (
    <Paper>
      <form>
        <TextField
          label="Username: "
          variant="standard"
          name="username"
          value={values.username}
          onChange={handleFormChange}
        />
        <TextField
          label="Password: "
          variant="standard"
          name="password"
          value={values.password}
          onChange={handleFormChange}
        />
        <Button onClick={loginHandler}>Log in</Button>
      </form>
    </Paper>
  );
};
