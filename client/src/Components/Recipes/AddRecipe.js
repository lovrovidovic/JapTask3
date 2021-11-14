import { useEffect, useMemo, useState } from "react";
import useHttp from "../../Hooks/useHttp";
import { Header } from "../UI/Header";
import TextField from "@mui/material/TextField";
import MenuItem from "@mui/material/MenuItem";
import Select from "@mui/material/Select";
import InputLabel from "@mui/material/InputLabel";
import { Button } from "@mui/material";
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import { AddIngredientModal } from "../Ingredients/AddIngredientModal";
import IconButton from "@mui/material/IconButton";
import DeleteForeverIcon from "@mui/icons-material/DeleteForever";

export const AddRecipe = () => {
  const [showModal, setShowModal] = useState(false);
  const [ingredientValues, setIngredientValues] = useState([]);
  const [values, setValues] = useState({
    name: "",
    description: "",
    userId: 1,
    categoryId: "",
    recipeIngredient: [],
  });

  const categoryRequestObj = useMemo(() => {
    return { method: "GET", url: "/category" };
  }, []);

  const { isLoading, error, sendRequest, responseData: categories } = useHttp();

  useEffect(() => {
    sendRequest(categoryRequestObj);
  }, [sendRequest, categoryRequestObj]);

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

  const submitHandler = () => {
    console.log(values);
    sendRequest({method:"POST", url: "/recipe", data: values})
  };

  return (
    <div>
      <Header title="Add new recipe" />
      <form>
        <AddIngredientModal
          showModal={showModal}
          handleShowModal={handleShowModal}
          handleAddIngredient={addIngredient}
        />
        <InputLabel id="select">Select recipe category</InputLabel>
        <Select
          name="categoryId"
          value={values.categoryId}
          label="Select recipe category"
          onChange={handleFormChange}
        >
          {categories.map((category) => {
            return (
              <MenuItem key={category.id} value={category.id}>
                {category.name}
              </MenuItem>
            );
          })}
        </Select>
        <TextField
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
        />

        <Button onClick={handleShowModal}>Add ingredient</Button>

        {ingredientValues.length > 0 && (
          <Table sx={{ maxWidth: 800 }} size="small">
            <TableHead>
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
                      onClick={() => deleteIngredient(ingredient.ingredientId)}
                    >
                      <DeleteForeverIcon />
                    </IconButton>
                  </TableCell>
                </TableRow>
              ))}
            </TableBody>
          </Table>
        )}
        <Button onClick={submitHandler}>Submit</Button>
      </form>
    </div>
  );
};

/*
{
  "name": "string",
  "description": "string",
  "userId": 0,
  "categoryId": 0,
  "recipeIngredient": [
    {
      "ingredientId": 0,
      "quantity": 0,
      "unit": "kg"
    }
  ]
}

*/
