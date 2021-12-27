import React, { useState } from "react";
import { Header } from "../Shared/Header";
import { useParams } from "react-router-dom";
import { Form, Formik } from "formik";
import { Typography, Alert } from "@mui/material";
import { useQuery, useMutation } from "react-query";
import { getCategoryDetails, updateCategory } from "../../HttpRequests/CategoryRequests";
import CircularProgress from "@mui/material/CircularProgress";
import Box from "@mui/material/Box";
import { SuccessToaster } from "../Shared/SuccessToaster";
import { CategorySchema } from "../../validationSchemas/ValidationSchemas";
import classes from "./AddCategory.module.css";
import { Button } from "../Shared/Button";
import { InputField } from "../Shared/InputField";

export const CategoryDetails = () => {
  const [successAlertOpen, setSuccessAlertOpen] = useState(false);
  const params = useParams();
  const categoryId = params.id;

  const { data, isError, isLoading } = useQuery(
    ["categoryDetails", categoryId],
    getCategoryDetails
  );

  const submitCategory = useMutation(updateCategory, {
    onSuccess: () => {
      setSuccessAlertOpen(true);
    },
  });

  const initialValues = {
    name: data?.name,
    createdAt: data?.createdAt,
    modifiedAt: data?.modifiedAt,
  };
  console.log(initialValues);
  return (
    <>
      <Header title="Category details" />
      {isLoading && (
        <Box sx={{ display: "flex" }}>
          <CircularProgress />
        </Box>
      )}
      {isError && (
        <Alert severity="error">
          Error! Check if you have filled the entire form or if you are connected to the server.
        </Alert>
      )}
      {!isLoading && (
        <Formik
          enableReinitialize
          initialValues={initialValues}
          onSubmit={(values) => submitCategory.mutate({ id: categoryId, name: values.name })}
          validationSchema={CategorySchema}>
          {({ values }) => (
            <Form>
              <div className={classes.form}>
                <InputField label="Name:" name="name" />
                <Typography sx={{ marginTop: 2 }}>{`Created at: ${values.createdAt}`}</Typography>
                <Typography sx={{ margin: 2 }}>{`Modified at: ${values.modifiedAt}`}</Typography>
                Recipes:
                {data?.recipes?.map((recipe, index) => {
                  return <Typography key={index}>{recipe.name}</Typography>;
                })}
                <div className={classes.submitContainer}>
                  <Button text="Submit" variant="contained" type="submit" />
                </div>
              </div>
            </Form>
          )}
        </Formik>
      )}

      <SuccessToaster
        open={successAlertOpen}
        setOpen={setSuccessAlertOpen}
        text={"Update successful!"}
      />
    </>
  );
};
