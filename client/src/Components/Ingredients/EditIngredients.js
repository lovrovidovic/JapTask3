import React, { useState } from "react";
import { Header } from "../Shared/Header";
import { useParams } from "react-router-dom";
import { Form, Formik, Field } from "formik";
import { useQuery, useMutation } from "react-query";
import { TextField, Button } from "@mui/material";
import {
  getIngredientDetails,
  updateIngredient,
} from "../../HttpRequests/IngredientRequests";
import { Select } from "../Shared/Select";
import { SuccessToaster } from "../Shared/SuccessToaster";

export const EditIngredient = () => {
  const params = useParams();
  const ingredientId = params.id;

  const [successAlertOpen, setSuccessAlertOpen] = useState(false);

  const { isLoading, data } = useQuery(
    ["ingredientsDetails", ingredientId],
    () => getIngredientDetails(ingredientId)
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
      <Header title="Create ingredient" />
      {!isLoading && (
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
      )}
      <SuccessToaster
        open={successAlertOpen}
        setOpen={setSuccessAlertOpen}
        text={"Action successful!"}
      />
    </>
  );
};
