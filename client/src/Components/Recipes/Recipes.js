import React, { useEffect, useMemo, useState } from "react";
import CircularProgress from "@mui/material/CircularProgress";
import Box from "@mui/material/Box";
import useHttp from "../../Hooks/useHttp";
import Alert from "@mui/material/Alert";
import { Button } from "@mui/material";
import { Header } from "../UI/Header";
import { useParams, useHistory } from "react-router-dom";
import { CustomCard } from "../UI/CustomCard";
import classes from "./Recipes.module.css";
import { generateLink, routesConfiguration as routes } from "../../Router/routes";
import { SearchContainer } from "../UI/SearchContainer";
import IconButton from "@mui/material/IconButton";
import AddCircleIcon from "@mui/icons-material/AddCircle";

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
    history.push(generateLink(routes.RECIPE_CREATE))
  } 

  return (
    <div>
      <>
        <Header title="Recipes" />
        <div>
          <SearchContainer
            label="Search recipes"
            searchAction={setSearchValue}
          />
          <IconButton onClick={addRecipeHandler}>
            <AddCircleIcon />
          </IconButton>
        </div>
        <div className={classes.container}>
          {isLoading && !error && (
            <>
              <Box sx={{ display: "flex" }}>
                <CircularProgress />
              </Box>
            </>
          )}
          {error && (
            <Alert severity="error">
              Error! Cannot get list of recipes for this category.
            </Alert>
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
    </div>
  );
};
