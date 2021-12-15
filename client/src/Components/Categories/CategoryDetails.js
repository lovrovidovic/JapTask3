import React, { useState } from "react";
import { Header } from "../Shared/Header";
import { useParams } from "react-router-dom";
import { Form, Formik, ErrorMessage } from "formik";
import { TextField, Button, Typography, Alert } from "@mui/material";
import { useQuery, useMutation } from "react-query";
import {
  getCategoryDetails,
  updateCategory,
} from "../../HttpRequests/CategoryRequests";
import CircularProgress from "@mui/material/CircularProgress";
import Box from "@mui/material/Box";
import { SuccessToaster } from "../Shared/SuccessToaster";
import { CategorySchema } from "../../validationSchemas/ValidationSchemas";
import classes from "./AddCategory.module.css";

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
          Error! Check if you have filled the entire form or if you are
          connected to the server.
        </Alert>
      )}
      {!isLoading && (
        <Formik
          enableReinitialize
          initialValues={initialValues}
          onSubmit={(values) =>
            submitCategory.mutate({ id: categoryId, name: values.name })
          }
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

                <TextField
                  label="Created at: "
                  variant="standard"
                  name="createdAt"
                  value={values.createdAt}
                  disabled
                />
                <TextField
                  label="Modified at: "
                  variant="standard"
                  name="modifiedAt"
                  value={values.modifiedAt}
                  disabled
                />
                
                Recipes:
                {data?.recipes?.map((recipe) => {
                  return (
                    <Typography key={recipe.name}>{recipe.name}</Typography>
                  );
                })}

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
      )}

      <SuccessToaster
        open={successAlertOpen}
        setOpen={setSuccessAlertOpen}
        text={"Update successful!"}
      />
    </>
  );
};
