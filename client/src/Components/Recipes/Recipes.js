import React, { useEffect, useMemo, useState } from "react";
import { useParams, useHistory } from "react-router-dom";
import useHttp from "../../Hooks/useHttp";
import {
  generateLink,
  routesConfiguration as routes,
} from "../../Router/routes";
import { Header } from "../UI/Header";
import { SearchContainer } from "../UI/SearchContainer";
import { CustomCard } from "../UI/CustomCard";
import CircularProgress from "@mui/material/CircularProgress";
import Box from "@mui/material/Box";
import Alert from "@mui/material/Alert";
import Button from "@mui/material/Button";
import IconButton from "@mui/material/IconButton";
import AddCircleIcon from "@mui/icons-material/AddCircle";
import classes from "./Recipes.module.css";

export const Recipes = () => {
  const params = useParams();
  const history = useHistory();
  const categoryId = params.id;
  const [displayed, setDisplayed] = useState(10);
  const [searchValue, setSearchValue] = useState("");
  const {
    isLoading,
    error,
    sendRequest: getRecipes,
    responseData: recipes,
  } = useHttp();

  const requestObj = useMemo(() => {
    return {
      method: "GET",
      url: "/recipe",
      params: { search: searchValue, n: displayed, categoryId },
    };
  }, [displayed, categoryId, searchValue]);

  useEffect(() => {
    getRecipes(requestObj);
  }, [getRecipes, requestObj]);

  const loadMoreHandler = () => {
    setDisplayed((prevState) => {
      setDisplayed(prevState + 10);
    });
  };

  const addRecipeHandler = () => {
    history.push(generateLink(routes.RECIPE_CREATE));
  };

  return (
    <>
      <Header title="Recipes" />
      {error && (
        <Alert severity="error">
          Error! Cannot get list of recipes for this category.
        </Alert>
      )}
      <div className={classes.actions}> 
        <SearchContainer label="Search recipes" searchAction={setSearchValue} />
        <IconButton size="large" onClick={addRecipeHandler} >
          <AddCircleIcon fontSize="large" />
        </IconButton>
      </div>
      <div className={classes.container}>
        {isLoading && !error && (
          <Box sx={{ display: "flex" }}>
            <CircularProgress />
          </Box>
        )}

        <div className={classes.categoriesList}>
          {recipes?.map((recipe) => {
            return (
              <CustomCard
                key={recipe.id}
                title={recipe.name}
                linkRoute={routes.RECIPE_DETAILS}
                id={recipe.id}
                buttonText="Recipe details"
                text={`Price: ${recipe.price}KM`}
              />
            );
          })}
        </div>

        {recipes.length >= displayed ? (
          <Button onClick={loadMoreHandler}>Load more</Button>
        ) : (
          ""
        )}
      </div>
    </>
  );
};
