import { Button } from "@mui/material";
import { useHistory } from "react-router-dom";
import React from "react";

export const Login = () => {
  const history = useHistory();
  const loginHandler = () => {
    history.push("/categories");
  };

  return (
    <div>
      <Button onClick={loginHandler}>Log in</Button>
    </div>
  );
};
