import React, { useEffect, useMemo, useState } from "react";
import { useParams, useHistory } from "react-router-dom";
import Typography from "@mui/material/Typography";
import useHttp from "../../Hooks/useHttp";
import { Header } from "../UI/Header";
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import CircularProgress from "@mui/material/CircularProgress";
import Box from "@mui/material/Box";
import Alert from "@mui/material/Alert";
import classes from './RecipeDetails.module.css'

export const RecipeDetails = () => {
  const params = useParams();
  const recipeId = params.id;
  const {
    isLoading,
    error,
    sendRequest: getRecipeDetails,
    responseData: recipe,
  } = useHttp();

  const requestObj = useMemo(() => {
    return {
      url: `recipe/${recipeId}`,
    };
  }, [recipeId]);

  useEffect(() => {
    getRecipeDetails(requestObj);
  }, [getRecipeDetails, requestObj]);

  return (
    <div>
      <Header title="Recipe" />

      {isLoading && !error && (
        <>
          <Box sx={{ display: "flex" }}>
            <CircularProgress />
          </Box>
        </>
      )}
      {error && (
        <Alert severity="error">
          Error! Cannot get details for this recipe.
        </Alert>
      )}
      {!isLoading && !error && (
        <Box className={classes.content}>
          <Typography variant="h6">Name:</Typography>
          <Typography variant="body1">{recipe.name}</Typography>
          <Typography variant="h6">Description:</Typography>
          <Typography variant="body1">{recipe.description}</Typography>

          <Typography className={classes.tableLabel} variant="h6">Ingredients:</Typography>
          <Table sx={{ maxWidth: 800 }} size="small" aria-label="a dense table">
            <TableHead>
              <TableRow className={classes.highlightedCell}>
                <TableCell>Ingredient</TableCell>
                <TableCell>Ammount</TableCell>
                <TableCell>Price</TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {recipe.ingredients?.map((ingredient) => (
                <TableRow
                  key={ingredient.name}
                  sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
                >
                  <TableCell component="th" scope="row">
                    {ingredient.name}
                  </TableCell>
                  <TableCell>{ingredient.quantity + ingredient.unit}</TableCell>
                  <TableCell>{ingredient.price}KM</TableCell>
                </TableRow>
              ))}
              <TableRow>
                <TableCell className={classes.highlightedCell} colSpan={2}>TOTAL PRICE OF INGREDIENTS</TableCell>
                <TableCell >{recipe.totalPrice}</TableCell>
              </TableRow>
            </TableBody>
          </Table>
        </Box>
      )}
    </div>
  );
};
