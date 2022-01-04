import { useState } from "react";
import { Header } from "../Shared/Header";
import { AddIngredientModal } from "../Ingredients/AddIngredientModal";
import {
  FormControl,
  MenuItem,
  Select,
  InputLabel,
  Table,
  TableBody,
  TableCell,
  TableHead,
  TableRow,
  IconButton,
  Alert,
} from "@mui/material";
import DeleteForeverIcon from "@mui/icons-material/DeleteForever";
import classes from "./AddRecipe.module.css";

import { useQuery, useMutation } from "react-query";
import { getAllCategories } from "../../HttpRequests/CategoryRequests";
import { createRecipe } from "../../HttpRequests/RecipeRequests";
import { Form, Formik, ErrorMessage } from "formik";
import { RecipeSchema } from "../../validationSchemas/ValidationSchemas";
import { SuccessToaster } from "../Shared/SuccessToaster";
import { Button } from "../Shared/Button";
import { InputField } from "../Shared/InputField";

export const AddRecipe = () => {
  const [showModal, setShowModal] = useState(false);
  const [recipeIngredients, setRecipeIngredients] = useState([]);
  const [successAlertOpen, setSuccessAlertOpen] = useState(false);

  const {
    data: categories,
    isError: categoryError,
    isLoading: categoryLoading,
  } = useQuery(["getAllCategories"], getAllCategories);

  const submitRecipe = useMutation(createRecipe, {
    onMutate: (variables) => {
      variables.recipeIngredient = recipeIngredients.map(
        ({ normativePrice, normativeQuantity, normativeUnit, ...attributes }) => attributes
      );
      return variables;
    },
    onSuccess: () => {
      setSuccessAlertOpen(true);
      setRecipeIngredients([]);
    },
  });

  const handleShowModal = () => {
    setShowModal(!showModal);
  };

  const addIngredient = (newIngredient) => {
    setRecipeIngredients((prevState) => {
      return [...prevState, newIngredient];
    });
  };

  const deleteIngredient = (id) => {
    setRecipeIngredients((prevState) => {
      return prevState.filter((ingredient) => {
        return ingredient.ingredientId !== id;
      });
    });
  };

  const initialValues = {
    name: "",
    description: "",
    userId: 0,
    categoryId: "",
    recommendedPrice: "",
  };

  return (
    <div>
      <Header title="Add new recipe" />
      {submitRecipe.isError && (
        <Alert severity="error">
          Error! Check if you have filled the entire form or if you are connected to the server.
        </Alert>
      )}
      <Formik
        enableReinitialize
        initialValues={initialValues}
        onSubmit={(values, { resetForm }) => {
          submitRecipe.mutate(values);
          resetForm();
        }}
        validationSchema={RecipeSchema}>
        {({ values, handleChange }) => (
          <Form>
            <div className={classes.container}>
              <div className={classes.form}>
                <AddIngredientModal
                  showModal={showModal}
                  handleShowModal={handleShowModal}
                  handleAddIngredient={addIngredient}
                />

                {!categoryError && !categoryLoading && (
                  <FormControl variant="standard" sx={{ m: 1, minWidth: 120 }}>
                    <InputLabel id="select">Category</InputLabel>
                    <Select
                      name="categoryId"
                      value={values.categoryId}
                      label="Category"
                      onChange={handleChange}>
                      {categories?.map((category) => {
                        return (
                          <MenuItem key={category.id} value={category.id}>
                            {category.name}
                          </MenuItem>
                        );
                      })}
                    </Select>
                  </FormControl>
                )}
                <ErrorMessage name="categoryId" />

                <InputField label="Name:" name="name" />

                <InputField label="Recommended Price:" name="recommendedPrice" />

                <InputField
                  label="Description:"
                  name="description"
                  multiline
                  minRows={2}
                  sx={{ width: "30%" }}
                />

                <Button sx={{ mt: 3 }} onClick={handleShowModal} text="Add ingredient" />

                {recipeIngredients?.length > 0 && (
                  <Table sx={{ maxWidth: 800 }} size="small">
                    <TableHead sx={{ backgroundColor: "darkgrey" }}>
                      <TableRow>
                        <TableCell>Ingredient</TableCell>
                        <TableCell>Ammount</TableCell>
                        <TableCell>Price per unit</TableCell>
                        <TableCell>Remove</TableCell>
                      </TableRow>
                    </TableHead>
                    <TableBody>
                      {recipeIngredients?.map((ingredient) => (
                        <TableRow
                          key={ingredient?.ingredientId}
                          sx={{
                            "&:last-child td, &:last-child th": { border: 0 },
                          }}>
                          <TableCell>{ingredient.name}</TableCell>
                          <TableCell>
                            {ingredient.quantity} {ingredient.unitType}
                          </TableCell>
                          <TableCell>
                            {ingredient.normativePrice}KM /{ingredient.normativeQuantity}{" "}
                            {ingredient.normativeUnit}
                          </TableCell>
                          <TableCell>
                            <IconButton onClick={() => deleteIngredient(ingredient.ingredientId)}>
                              <DeleteForeverIcon />
                            </IconButton>
                          </TableCell>
                        </TableRow>
                      ))}
                    </TableBody>
                  </Table>
                )}
                <Button variant="contained" sx={{ my: 3 }} type="submit" text="Submit" />
              </div>
            </div>
          </Form>
        )}
      </Formik>

      <SuccessToaster
        open={successAlertOpen}
        setOpen={setSuccessAlertOpen}
        text={"Update successful!"}
      />
    </div>
  );
};
