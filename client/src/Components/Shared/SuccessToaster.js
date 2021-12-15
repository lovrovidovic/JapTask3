import React from "react";
import { Alert, Snackbar } from "@mui/material";

export const SuccessToaster = ({ open, setOpen, text }) => {
  return (
    <Snackbar
      open={open}
      autoHideDuration={6000}
      onClose={() => setOpen(!open)}
    >
      <Alert
        onClose={() => setOpen(!open)}
        severity="success"
        sx={{ width: "100%" }}
      >
        {text}
      </Alert>
    </Snackbar>
  );
};
