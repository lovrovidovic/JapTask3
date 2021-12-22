import React, { useState } from "react";
import { Header } from "../Shared/Header";
import { Form, Formik, ErrorMessage } from "formik";
import { useMutation } from "react-query";
import { TextField, Button } from "@mui/material";
import { createIngredient } from "../../HttpRequests/IngredientRequests";
import { Select } from "../Shared/Select";
import { SuccessToaster } from "../Shared/SuccessToaster";
import { IngredientSchema } from "../../validationSchemas/ValidationSchemas";
import classes from "./CreateIngredient.module.css";

export const CreateIngredient = () => {
  const [successAlertOpen, setSuccessAlertOpen] = useState(false);
  const submitIngredient = useMutation(createIngredient, {
    onSuccess: () => {
      setSuccessAlertOpen(true);
    },
  });

  const initialValues = {
    name: "",
    normativeQuantity: "",
    normativePrice: "",
    normativeUnit: "",
  };

  const units = ["g", "kg", "ml", "l", "kom"];

  return (
    <>
      <Header title="Create ingredient" />
      {
        <Formik
          enableReinitialize
          initialValues={initialValues}
          onSubmit={(values, { resetForm }) => {
            submitIngredient.mutate(values);
            resetForm();
          }}
          validationSchema={IngredientSchema}>
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

                <TextField
                  label="Normative quantity: "
                  variant="standard"
                  name="normativeQuantity"
                  value={values.normativeQuantity}
                  onChange={handleChange}
                />
                <ErrorMessage name="normativeQuantity" />

                <TextField
                  label="Normative price: "
                  variant="standard"
                  name="normativePrice"
                  value={values.normativePrice}
                  onChange={handleChange}
                />
                <ErrorMessage name="normativePrice" />

                <Select
                  label="Unit type: "
                  value={values.normativeUnit}
                  name="normativeUnit"
                  items={units}
                  onChange={handleChange}
                />
                <ErrorMessage name="normativeUnit" />

                <div className="detailsButtons">
                  <Button variant="contained" sx={{ margin: "30px 0" }} type="submit">
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
    </>
  );
};
