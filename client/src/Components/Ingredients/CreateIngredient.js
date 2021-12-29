import React, { useState } from "react";
import { Header } from "../Shared/Header";
import { Form, Formik, ErrorMessage } from "formik";
import { useMutation } from "react-query";
import { createIngredient } from "../../HttpRequests/IngredientRequests";
import { Select } from "../Shared/Select";
import { SuccessToaster } from "../Shared/SuccessToaster";
import { IngredientSchema } from "../../validationSchemas/ValidationSchemas";
import classes from "./CreateIngredient.module.css";
import { Button } from "../Shared/Button";
import { InputField } from "../Shared/InputField";

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
      }
      <SuccessToaster
        open={successAlertOpen}
        setOpen={setSuccessAlertOpen}
        text={"Create successful!"}
      />
    </>
  );
};
