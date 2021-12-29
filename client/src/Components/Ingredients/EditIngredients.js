import React, { useState } from "react";
import { Header } from "../Shared/Header";
import { useParams } from "react-router-dom";
import { Form, Formik, ErrorMessage } from "formik";
import { useQuery, useMutation } from "react-query";
import { getIngredientDetails, updateIngredient } from "../../HttpRequests/IngredientRequests";
import { Select } from "../Shared/Select";
import { SuccessToaster } from "../Shared/SuccessToaster";
import { IngredientSchema } from "../../validationSchemas/ValidationSchemas";
import classes from "./CreateIngredient.module.css";
import { Button } from "../Shared/Button";
import { InputField } from "../Shared/InputField";

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
                <InputField name="name" label="Name: " />

                <InputField name="normativeQuantity" label="Normative quantity: " />

                <InputField name="normativePrice" label="Normative price: " />

                <Select
                  label="Unit type: "
                  value={values.normativeUnit}
                  name="normativeUnit"
                  items={units}
                  onChange={handleChange}
                />
                <ErrorMessage name="normativeUnit" />

                <Button sx={{ my: 3 }} variant="contained" type="submit" text="Submit" />
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
