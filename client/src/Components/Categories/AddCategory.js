import React, {useState} from "react";
import { Header } from "../Shared/Header";
import { Form, Formik } from "formik";
import { TextField, Button } from "@mui/material";
import { useMutation } from "react-query";
import { createCategory } from "../../HttpRequests/CategoryRequests";
import { SuccessToaster } from "../Shared/SuccessToaster";

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
          onSubmit={(values) => submitCategory.mutate(values)}
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
    </div>
  );
};
