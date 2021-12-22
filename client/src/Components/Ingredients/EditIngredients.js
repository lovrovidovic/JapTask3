import React, { useState } from "react";
import { Header } from "../Shared/Header";
import { useParams } from "react-router-dom";
import { Form, Formik, ErrorMessage } from "formik";
import { useQuery, useMutation } from "react-query";
import { TextField, Button } from "@mui/material";
import { getIngredientDetails, updateIngredient } from "../../HttpRequests/IngredientRequests";
import { Select } from "../Shared/Select";
import { SuccessToaster } from "../Shared/SuccessToaster";
import { IngredientSchema } from "../../validationSchemas/ValidationSchemas";
import classes from "./CreateIngredient.module.css";

export const EditIngredient = () => {
  const params = useParams();
  const ingredientId = params.id;

  const [successAlertOpen, setSuccessAlertOpen] = useState(false);

  const { isLoading, data } = useQuery(["ingredientsDetails", ingredientId], () =>
    getIngredientDetails(ingredientId)
  );

  const submitIngredient = useMutation(updateIngredient, {
    onSuccess: () => {
      setSuccessAlertOpen(true);
    },
  });

  const initialValues = {
    id: ingredientId,
    name: data?.name,
    normativeQuantity: data?.normativeQuantity,
    normativePrice: data?.normativePrice,
    normativeUnit: data?.normativeUnit,
  };

  const units = ["g", "kg", "ml", "l", "kom"];

  return (
    <>
      <Header title="Edit ingredient" />
      {!isLoading && (
        <Formik
          enableReinitialize
          initialValues={initialValues}
          onSubmit={(values) => submitIngredient.mutate(values)}
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
      )}
      <SuccessToaster
        open={successAlertOpen}
        setOpen={setSuccessAlertOpen}
        text={"Action successful!"}
      />
    </>
  );
};
