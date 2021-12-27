import React, { useState } from "react";
import { Header } from "../Shared/Header";
import { Form, Formik } from "formik";
import { useMutation } from "react-query";
import { createCategory } from "../../HttpRequests/CategoryRequests";
import { SuccessToaster } from "../Shared/SuccessToaster";
import { CategorySchema } from "../../validationSchemas/ValidationSchemas";
import classes from "./AddCategory.module.css";
import { Button } from "../Shared/Button";
import { InputField } from "../Shared/InputField";

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

      <Formik
        enableReinitialize
        initialValues={initialValues}
        onSubmit={(values, { resetForm }) => {
          submitCategory.mutate(values);
          resetForm();
        }}
        validationSchema={CategorySchema}>
        <Form>
          <div className={classes.form}>
            <InputField label="Name:" name="name" />
            <div className={classes.submitContainer}>
              <Button variant="contained" type="submit" text="Submit" />
            </div>
          </div>
        </Form>
      </Formik>

      <SuccessToaster
        open={successAlertOpen}
        setOpen={setSuccessAlertOpen}
        text={"Create successful!"}
      />
    </div>
  );
};
