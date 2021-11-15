import { useEffect, useState } from "react";
import { useHistory } from "react-router";
import useHttp from "../../Hooks/useHttp";
import { Header } from "../UI/Header";
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

export const AddRecipe = () => {
  const history = useHistory();
  const [showModal, setShowModal] = useState(false);
  const [ingredientValues, setIngredientValues] = useState([]);
  const [values, setValues] = useState({
    name: "",
    description: "",
    userId: getUserId(),
    categoryId: "",
    recipeIngredient: [],
  });

  const {
    isLoading: isLoadingCategory,
    error: errorCategory,
    sendRequest: getCategories,
    responseData: categories,
  } = useHttp();
  const {
    isLoading,
    error,
    sendRequest: postRecipe,
    responseData: postedRecipe,
  } = useHttp();

  useEffect(() => {
    getCategories({ method: "GET", url: "/category" });
  }, [getCategories]);

  const handleFormChange = (e) => {
    setValues((prevState) => {
      return { ...prevState, [e.target.name]: e.target.value };
    });
  };

  const handleShowModal = () => {
    setShowModal(!showModal);
  };

  const addIngredient = (newIngredient) => {
    setIngredientValues((prevState) => {
      return [...prevState, newIngredient];
    });
    setValues((prevState) => {
      return {
        ...prevState,
        recipeIngredient: [
          ...prevState.recipeIngredient,
          {
            ingredientId: newIngredient.ingredientId,
            quantity: newIngredient.quantity,
            unit: newIngredient.unit,
          },
        ],
      };
    });
  };

  const deleteIngredient = (id) => {
    setIngredientValues(
      ingredientValues.filter((ingredient) => {
        return ingredient.ingredientId !== id;
      })
    );
    setValues((prevState) => {
      return {
        ...prevState,
        recipeIngredient: prevState.recipeIngredient.filter((ingredient) => {
          return ingredient.ingredientId !== id;
        }),
      };
    });
  };

  const onSubmitSuccess = () => {
    history.push(generateLink(routes.RECIPES, { id: values.categoryId }));
  };

  const submitHandler = () => {
    postRecipe({
      method: "POST",
      url: "/recipe",
      data: values,
      returnData: false,
      additionalFunc: onSubmitSuccess,
    });
  };

  return (
    <div>
      <Header title="Add new recipe" />
      {error && (
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
          {!isLoadingCategory && !errorCategory && (
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

          {ingredientValues.length > 0 && (
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
                {ingredientValues?.map((ingredient) => (
                  <TableRow
                    key={ingredient?.ingredientId}
                    sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
                  >
                    <TableCell component="th" scope="row">
                      {ingredient.name}
                    </TableCell>
                    <TableCell>
                      {ingredient.quantity} {ingredient.unit}
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
            onClick={submitHandler}
          >
            Submit
          </Button>
        </form>
      </div>
    </div>
  );
};
