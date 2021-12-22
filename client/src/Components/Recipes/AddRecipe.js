import { useState } from "react";
import { Header } from "../Shared/Header";
import { AddIngredientModal } from "../Ingredients/AddIngredientModal";
import {
  TextField,
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
  Button,
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
      console.log(variables);
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

                <TextField
                  label="Name: "
                  variant="standard"
                  name="name"
                  value={values.name}
                  onChange={handleChange}
                />
                <ErrorMessage name="name" />

                <TextField
                  label="Recommended Price: "
                  variant="standard"
                  name="recommendedPrice"
                  value={values.recommendedPrice}
                  onChange={handleChange}
                />
                <ErrorMessage name="recommendedPrice" />

                <TextField
                  label="Description: "
                  variant="standard"
                  name="description"
                  value={values.description}
                  onChange={handleChange}
                  multiline
                  minRows={2}
                  style={{ width: "30%" }}
                />
                <ErrorMessage name="description" />

                <Button sx={{ margin: "30px 0" }} onClick={handleShowModal}>
                  Add ingredient
                </Button>

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
                          <TableCell component="th" scope="row">
                            {ingredient.name}
                          </TableCell>
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
                <Button variant="contained" sx={{ margin: "30px 0" }} type="submit">
                  Submit
                </Button>
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
