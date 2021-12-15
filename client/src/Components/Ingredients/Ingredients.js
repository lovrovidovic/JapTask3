import React, { useState } from "react";
import { useHistory } from "react-router-dom";
import {
  TextField,
  Table,
  TableBody,
  TableCell,
  TableHead,
  TableRow,
  IconButton,
  Button,
  Alert,
} from "@mui/material";
import {
  generateLink,
  routesConfiguration as routes,
} from "../../Router/routes";
import {
  deleteIngredient,
  getPagedIngredients,
} from "../../HttpRequests/IngredientRequests";
import { useQuery, useMutation } from "react-query";
import { Header } from "../Shared/Header";
import NavigateNextIcon from "@mui/icons-material/NavigateNext";
import NavigateBeforeIcon from "@mui/icons-material/NavigateBefore";
import { Select } from "../Shared/Select";
import AddCircleIcon from "@mui/icons-material/AddCircle";
import EditIcon from "@mui/icons-material/Edit";
import DeleteForeverIcon from "@mui/icons-material/DeleteForever";
import { SuccessToaster } from "../Shared/SuccessToaster";

export const Ingredients = () => {
  const history = useHistory();
  const [successAlertOpen, setSuccessAlertOpen] = useState(false);
  const [values, setValues] = useState({
    page: 0,
    pageSize: 5,
    sortBy: "",
    sortOrder: "ASC",
    filters: {
      name: "",
      minQuantity: "",
      maxQuantity: "",
      unitType: "",
    },
  });

  const { refetch, data } = useQuery(
    ["ingredients", values],
    () => getPagedIngredients(values),
    { keepPreviousData: true }
  );

  const deleteRecipe = useMutation(deleteIngredient, {
    onSuccess: () => {
      setSuccessAlertOpen(true);
    },
  });

  const previousPage = () => {
    if (values.page > 0)
      setValues((prevState) => {
        return { ...prevState, page: prevState.page - 1 };
      });
  };

  const nextPage = () => {
    if (data?.length === values.pageSize)
      setValues((prevState) => {
        return { ...prevState, page: prevState.page + 1 };
      });
  };

  const increasePageSize = (e) => {
    setValues((prevState) => {
      return { ...prevState, page: 0, pageSize: e.target.value };
    });
  };

  const handleChange = (e) => {
    setValues((prevState) => {
      return { ...prevState, [e.target.name]: e.target.value };
    });
  };

  const handleFiltersChange = (e) => {
    setValues((prevState) => {
      return {
        ...prevState,
        filters: { ...prevState.filters, [e.target.name]: e.target.value },
      };
    });
  };

  const addIngredientHandler = () => {
    history.push(generateLink(routes.INGREDIENTS_CREATE));
  };

  const editIngredientHandler = (id) => {
    history.push(generateLink(routes.INGREDIENTS_EDIT, { id }));
  };

  const deleteIngredientHandler = (id) => {
    if (window.confirm("Are you sure you want to delete this?")) {
      deleteRecipe.mutate(id);
      refetch();
    }
  };

  const pageSizes = [5, 10, 15, 25, 50, 100];
  const sortBy = [
    "name",
    "normativePrice",
    "normativeUnit",
    "normativeQuantity",
    "unitPrice",
  ];
  const sortOrder = ["ASC", "DESC"];
  const units = ["g", "kg", "ml", "l", "kom"];

  return (
    <>
      <Header title="Ingredients" />
      <IconButton size="large" onClick={addIngredientHandler}>
        <AddCircleIcon fontSize="large" />
      </IconButton>
      <IconButton size="small" onClick={previousPage}>
        <NavigateBeforeIcon />
      </IconButton>
      {values.page + 1}
      <IconButton size="small" onClick={nextPage}>
        <NavigateNextIcon />
      </IconButton>

      <Select
        label="Page size: "
        value={values.pageSize}
        name="pageSize"
        items={pageSizes}
        onChange={increasePageSize}
      />
      <Select
        label="Sort by: "
        value={values.sortBy}
        name="sortBy"
        items={sortBy}
        onChange={handleChange}
      />
      <Select
        label="Sort order: "
        value={values.sortOrder}
        name="sortOrder"
        items={sortOrder}
        onChange={handleChange}
      />

      <TextField
        size="large"
        label="Name: "
        variant="standard"
        name="name"
        value={values.filters.name}
        onChange={handleFiltersChange}
      />
      <TextField
        size="large"
        label="Min Quantity: "
        variant="standard"
        name="minQuantity"
        value={values.filters.minQuantity}
        onChange={handleFiltersChange}
      />
      <TextField
        size="large"
        label="Max Quantity: "
        variant="standard"
        name="maxQuantity"
        value={values.filters.maxQuantity}
        onChange={handleFiltersChange}
      />
      <Select
        label="Unit type: "
        value={values.filters.unitType}
        name="unitType"
        items={units}
        onChange={handleFiltersChange}
      />

      <Table sx={{ maxWidth: 800 }} size="small">
        <TableHead sx={{ backgroundColor: "darkgrey" }}>
          <TableRow>
            <TableCell>Name</TableCell>
            <TableCell>Normative price</TableCell>
            <TableCell>Normative quantity</TableCell>
            <TableCell>Normative unit</TableCell>
            <TableCell>Unit price</TableCell>
            <TableCell>Actions</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {data?.map((ingredient) => (
            <TableRow
              key={ingredient?.id}
              sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
            >
              <TableCell component="th" scope="row">
                {ingredient.name}
              </TableCell>
              <TableCell>{ingredient.normativePrice}</TableCell>
              <TableCell>{ingredient.normativeQuantity}</TableCell>
              <TableCell>{ingredient.normativeUnit}</TableCell>
              <TableCell>{ingredient.unitPrice}</TableCell>
              <TableCell>
                <IconButton
                  size="small"
                  onClick={() => editIngredientHandler(ingredient.id)}
                >
                  <EditIcon fontSize="small" />
                </IconButton>
                <IconButton
                  size="small"
                  onClick={() => deleteIngredientHandler(ingredient.id)}
                >
                  <DeleteForeverIcon fontSize="small" />
                </IconButton>
              </TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
      <SuccessToaster
        open={successAlertOpen}
        setOpen={setSuccessAlertOpen}
        text={"Create successful!"}
      />
    </>
  );
};
