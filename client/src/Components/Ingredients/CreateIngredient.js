import React, { useState } from "react";
import { Header } from "../Shared/Header";
import { Form, Formik } from "formik";
import { useMutation } from "react-query";
import { TextField, Button, Typography, Alert } from "@mui/material";
import { createIngredient } from "../../HttpRequests/IngredientRequests";
import { Select } from "../Shared/Select";
import { SuccessToaster } from "../Shared/SuccessToaster";

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
          onSubmit={(values) => submitIngredient.mutate(values)}
        >
          {({ values, handleChange }) => (
            <Form>
              <TextField
                size="large"
                label="Name: "
                variant="standard"
                name="name"
                value={values.name}
                onChange={handleChange}
              />
              <TextField
                size="large"
                label="Normative quantity: "
                variant="standard"
                name="normativeQuantity"
                value={values.normativeQuantity}
                onChange={handleChange}
              />
              <TextField
                size="large"
                label="Normative price: "
                variant="standard"
                name="normativePrice"
                value={values.normativePrice}
                onChange={handleChange}
              />
              <Select
                label="Unit type: "
                value={values.normativeUnit}
                name="normativeUnit"
                items={units}
                onChange={handleChange}
              />
              <div className="detailsButtons">
                <Button
                  variant="contained"
                  sx={{ margin: "30px 0" }}
                  type="submit"
                >
                  Submit
                </Button>
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
