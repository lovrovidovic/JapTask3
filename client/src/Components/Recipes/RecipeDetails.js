import React from "react";
import { useParams } from "react-router-dom";
import Typography from "@mui/material/Typography";
import { Header } from "../Shared/Header";
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import CircularProgress from "@mui/material/CircularProgress";
import Box from "@mui/material/Box";
import Alert from "@mui/material/Alert";
import classes from "./RecipeDetails.module.css";
import { useQuery } from "react-query";
import { getRecipeDetails } from "../../HttpRequests/RecipeRequests";

export const RecipeDetails = () => {
  const params = useParams();
  const recipeId = params.id;

  const { data, isError, isLoading } = useQuery(["recipeDetails", recipeId], getRecipeDetails);

  return (
    <div>
      <Header title="Recipe" />
      {isLoading && (
        <Box sx={{ display: "flex" }}>
          <CircularProgress />
        </Box>
      )}
      {isError && <Alert severity="error">Error! Cannot get details for this recipe.</Alert>}
      {!isLoading && !isError && (
        <Box className={classes.content}>
          <Typography variant="h6">Name:</Typography>
          <Typography variant="body1">{data.name}</Typography>
          <Typography variant="h6">Description:</Typography>
          <Typography variant="body1">{data.description}</Typography>

          <Typography className={classes.tableLabel} variant="h6">
            Ingredients:
          </Typography>
          <Table sx={{ maxWidth: 800 }} size="small">
            <TableHead>
              <TableRow className={classes.highlightedCell}>
                <TableCell>Ingredient</TableCell>
                <TableCell>Ammount</TableCell>
                <TableCell>Price</TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {data?.ingredients?.map((ingredient) => (
                <TableRow
                  key={ingredient.name}
                  sx={{ "&:last-child td, &:last-child th": { border: 0 } }}>
                  <TableCell component="th" scope="row">
                    {ingredient.name}
                  </TableCell>
                  <TableCell>
                    {ingredient.quantity} {ingredient.unitType}
                  </TableCell>
                  <TableCell>{ingredient.price} KM</TableCell>
                </TableRow>
              ))}
              <TableRow>
                <TableCell className={classes.highlightedCell} colSpan={2}>
                  TOTAL PRICE OF INGREDIENTS
                </TableCell>
                <TableCell>{data.totalPrice} KM</TableCell>
              </TableRow>
            </TableBody>
          </Table>
        </Box>
      )}
    </div>
  );
};
