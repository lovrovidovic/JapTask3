import React from "react";
import { Button as MaterialButton } from "@mui/material";

export const Button = ({ onClick, text, variant, type, size }) => {
  return (
    <MaterialButton onClick={onClick} variant={variant} type={type} size={size}>
      {text}
    </MaterialButton>
  );
};
