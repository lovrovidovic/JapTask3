import React from "react";
import { TextField } from "@mui/material";
import { Field, ErrorMessage } from "formik";

export const InputField = ({ name, label }) => {
  return (
    <>
      <Field as={MaterialTextField} name={name} label={label} />
      <ErrorMessage name={name} />
    </>
  );
};

const MaterialTextField = ({ name, label, ...props }) => {
  return <TextField name={name} label={label} variant="standard" {...props} />;
};
