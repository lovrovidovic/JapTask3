import { useState } from "react";
import { useParams } from "react-router-dom";
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
} from "@mui/material";
import DeleteForeverIcon from "@mui/icons-material/DeleteForever";
import { useQuery, useMutation } from "react-query";
import { getAllCategories } from "../../HttpRequests/CategoryRequests";
import { Form, Formik } from "formik";
import {
  getRecipeDetails,
  updateRecipe,
} from "../../HttpRequests/RecipeRequests";
import { SuccessToaster } from "../Shared/SuccessToaster";
import { Header } from "../Shared/Header";

export const EditRecipe = () => {
  const params = useParams();
  const [showModal, setShowModal] = useState(false);
  const [newIngredients, setNewIngredients] = useState([]);
  const recipeId = params.id;
  const [successAlertOpen, setSuccessAlertOpen] = useState(false);

  const { data, isError, isLoading } = useQuery(
    ["recipeDetails", recipeId],
    getRecipeDetails
  );

  const {
    data: categories,
    isError: categoryError,
    isLoading: categoryLoading,
  } = useQuery(["getAllCategories"], getAllCategories);

  const submitRecipe = useMutation(updateRecipe, {
    onMutate: (variables) => {
      console.log("a", variables.recipeIngredient);
      console.log("new", newIngredients);
      variables.recipeIngredient = [
        ...variables.recipeIngredient,
        ...newIngredients,
      ];
      console.log("b", variables.recipeIngredient);

      variables.recipeIngredient = variables.recipeIngredient.map(
        ({
          normativePrice,
          normativeQuantity,
          normativeUnit,
          name,
          price,
          unitPrice,
          ...attributes
        }) => attributes
      );
      console.log("c", variables.recipeIngredient);

      return variables;
    },
    onSuccess: () => {
      setSuccessAlertOpen(true);
    },
  });

  const handleShowModal = () => {
    setShowModal(!showModal);
  };

  const initialValues = {
    id: recipeId,
    name: data?.name,
    description: data?.description,
    categoryId: data?.categoryId,
    recommendedPrice: data?.recommendedPrice,
    recipeIngredient: data?.ingredients,
  };

  const addIngredient = (newIngredient) => {
    setNewIngredients((prevState) => {
      return [...prevState, newIngredient];
    });
    console.log(newIngredients);
  };

  const deleteIngredient = (id, ingredients, setFieldValue) => {
    const filteredIngredients = ingredients.filter((ingredient) => {
      return ingredient.ingredientId !== id;
    });

    setFieldValue("recipeIngredient", filteredIngredients);
  };

  return (
    <>
      <Header title="Edit recipe" />
      {!categoryError && !categoryLoading && !isLoading && (
        <Formik
          enableReinitialize
          initialValues={initialValues}
          onSubmit={(values) => submitRecipe.mutate(values)}
        >
          {({ values, handleChange, setFieldValue }) => (
            <Form>
              <AddIngredientModal
                showModal={showModal}
                handleShowModal={handleShowModal}
                handleAddIngredient={addIngredient}
              />

              <FormControl variant="standard" sx={{ m: 1, minWidth: 120 }}>
                <InputLabel id="select">Category</InputLabel>
                <Select
                  name="categoryId"
                  value={values?.categoryId}
                  label="Category"
                  onChange={handleChange}
                >
                  {categories?.map((category) => {
                    return (
                      <MenuItem key={category.id} value={category.id}>
                        {category.name}
                      </MenuItem>
                    );
                  })}
                </Select>
              </FormControl>

              <TextField
                size="large"
                label="Name: "
                variant="standard"
                name="name"
                value={values.name}
                onChange={handleChange}
              />
              <TextField
                label="Description: "
                variant="standard"
                name="description"
                multiline
                minRows={2}
                value={values.description}
                onChange={handleChange}
              />
              <TextField
                size="large"
                label="Recommended price: "
                variant="standard"
                name="recommendedPrice"
                value={values.recommendedPrice}
                onChange={handleChange}
              />

              <Button sx={{ margin: "30px 0" }} onClick={handleShowModal}>
                Add ingredient
              </Button>

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
                  {values?.recipeIngredient?.map((ingredient) => (
                    <TableRow
                      key={ingredient?.ingredientId}
                      sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
                    >
                      <TableCell component="th" scope="row">
                        {ingredient.name}
                      </TableCell>
                      <TableCell>
                        {ingredient.quantity} {ingredient.unitType}
                      </TableCell>
                      <TableCell>
                        {ingredient.normativePrice}KM /
                        {ingredient.normativeQuantity}{" "}
                        {ingredient.normativeUnit}
                      </TableCell>
                      <TableCell>
                        <IconButton
                          onClick={() =>
                            deleteIngredient(
                              ingredient.ingredientId,
                              values.recipeIngredient,
                              setFieldValue
                            )
                          }
                        >
                          <DeleteForeverIcon />
                        </IconButton>
                      </TableCell>
                    </TableRow>
                  ))}
                </TableBody>
              </Table>

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
        text={"Update successful!"}
      />
    </>
  );
};
