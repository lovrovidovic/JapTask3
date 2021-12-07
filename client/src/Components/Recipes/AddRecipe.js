import { useState } from "react";
import { useHistory } from "react-router";
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
import getUserId from "../../Hooks/getUserId";
import {
  generateLink,
  routesConfiguration as routes,
} from "../../Router/routes";
import { useQuery, useMutation } from "react-query";
import { getAllCategories } from "../../HttpRequests/CategoryRequests";
import { createRecipe } from "../../HttpRequests/RecipeRequests";

export const AddRecipe = () => {
  const history = useHistory();
  const [showModal, setShowModal] = useState(false);
  const [values, setValues] = useState({
    name: "",
    description: "",
    userId: getUserId(),
    categoryId: "",
    recipeIngredient: [],
  });

  const {
    data: categories,
    isError: categoryError,
    isLoading: categoryLoading,
  } = useQuery(["getAllCategories"], getAllCategories);

  const submitRecipe = useMutation(createRecipe, {
    onMutate: (variables) => {
      variables.recipeIngredient = variables.recipeIngredient.map(
        ({ normativePrice, normativeQuantity, normativeUnit, ...attributes }) =>
          attributes
      );
      return variables;
    },
    onSuccess: () => {
      history.push(generateLink(routes.RECIPES, { id: values.categoryId }));
    },
  });

  const handleFormChange = (e) => {
    setValues((prevState) => {
      return { ...prevState, [e.target.name]: e.target.value };
    });
  };

  const handleShowModal = () => {
    setShowModal(!showModal);
  };

  const addIngredient = (newIngredient) => {
    setValues((prevState) => {
      return {
        ...prevState,
        recipeIngredient: [...prevState.recipeIngredient, newIngredient],
      };
    });
  };

  const deleteIngredient = (id) => {
    setValues((prevState) => {
      return {
        ...prevState,
        recipeIngredient: prevState.recipeIngredient.filter((ingredient) => {
          return ingredient.ingredientId !== id;
        }),
      };
    });
  };

  return (
    <div>
      <Header title="Add new recipe" />
      {submitRecipe.isError && (
        <Alert severity="error">
          Error! Check if you have filled the entire form or if you are
          connected to the server.
        </Alert>
      )}
      <div className={classes.container}>
        <form className={classes.form}>
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
                onChange={handleFormChange}
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
          )}
          <TextField
            size="large"
            label="Name: "
            variant="standard"
            name="name"
            value={values.name}
            onChange={handleFormChange}
          />
          <TextField
            label="Description: "
            variant="standard"
            name="description"
            value={values.description}
            onChange={handleFormChange}
            multiline
            minRows={2}
            style={{ width: "30%" }}
          />

          <Button sx={{ margin: "30px 0" }} onClick={handleShowModal}>
            Add ingredient
          </Button>

          {values?.recipeIngredient?.length > 0 && (
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
                      {ingredient.normativeQuantity} {ingredient.normativeUnit}
                    </TableCell>
                    <TableCell>
                      <IconButton
                        onClick={() =>
                          deleteIngredient(ingredient.ingredientId)
                        }
                      >
                        <DeleteForeverIcon />
                      </IconButton>
                    </TableCell>
                  </TableRow>
                ))}
              </TableBody>
            </Table>
          )}
          <Button
            variant="contained"
            sx={{ margin: "30px 0" }}
            onClick={() => submitRecipe.mutate(values)}
          >
            Submit
          </Button>
        </form>
      </div>
    </div>
  );
};
