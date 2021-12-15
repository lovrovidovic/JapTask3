import React, { useState } from "react";
import { Header } from "../Shared/Header";
import { Form, Formik, ErrorMessage } from "formik";
import { TextField, Button } from "@mui/material";
import { useMutation } from "react-query";
import { createCategory } from "../../HttpRequests/CategoryRequests";
import { SuccessToaster } from "../Shared/SuccessToaster";
import { CategorySchema } from "../../validationSchemas/ValidationSchemas";
import classes from "./AddCategory.module.css";

export const AddCategory = () => {
  const initialValues = { name: "" };
  const [successAlertOpen, setSuccessAlertOpen] = useState(false);

  const submitCategory = useMutation(createCategory, {
    onSuccess: () => {
      setSuccessAlertOpen(true);
    },
  });

  return (
    <div>
      <Header title="Add new category" />
      {
        <Formik
          enableReinitialize
          initialValues={initialValues}
          onSubmit={(values, { resetForm }) => {
            submitCategory.mutate(values);
            resetForm();
          }}
          validationSchema={CategorySchema}
        >
          {({ values, handleChange }) => (
            <Form>
              <div className={classes.form}>
                <TextField
                  label="Name: "
                  variant="standard"
                  name="name"
                  value={values.name}
                  onChange={handleChange}
                />
                <ErrorMessage name="name" />

                <div className="detailsButtons">
                  <Button
                    variant="contained"
                    sx={{ margin: "30px 0" }}
                    type="submit"
                  >
                    Submit
                  </Button>
                </div>
              </div>
            </Form>
          )}
        </Formik>
      }
      <SuccessToaster
        open={successAlertOpen}
        setOpen={setSuccessAlertOpen}
        text={"Create successful!"}
      />
    </div>
  );
};
