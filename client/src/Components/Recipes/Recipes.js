import React, { useState, Fragment } from "react";
import { useParams, useHistory } from "react-router-dom";
import {
  generateLink,
  routesConfiguration as routes,
} from "../../Router/routes";
import { Header } from "../Shared/Header";
import { Search } from "../Shared/Search";
import { Card } from "../Shared/Card";
import CircularProgress from "@mui/material/CircularProgress";
import Box from "@mui/material/Box";
import Alert from "@mui/material/Alert";
import Button from "@mui/material/Button";
import IconButton from "@mui/material/IconButton";
import AddCircleIcon from "@mui/icons-material/AddCircle";
import classes from "./Recipes.module.css";
import { useInfiniteQuery } from "react-query";
import { getRecipes } from "../../HttpRequests/RecipeRequests";

export const Recipes = () => {
  const params = useParams();
  const history = useHistory();
  const categoryId = params.id;
  const [search, setSearchValue] = useState("");

  const { data, isError, fetchNextPage, hasNextPage, isLoading } =
    useInfiniteQuery(["recipes", categoryId, search], getRecipes, {
      getNextPageParam: (lastPage) => {
        if (lastPage.count === 10) {
          return lastPage.nextPage;
        } else {
          return false;
        }
      },
    });

  const addRecipeHandler = () => {
    history.push(generateLink(routes.RECIPE_CREATE));
  };

  return (
    <>
      <Header title="Recipes" />
      {isError && (
        <Alert severity="error">
          Error! Cannot get list of recipes for this category.
        </Alert>
      )}
      <div className={classes.actions}>
        <Search label="Search recipes" searchAction={setSearchValue} />
        <IconButton size="large" onClick={addRecipeHandler}>
          <AddCircleIcon fontSize="large" />
        </IconButton>
      </div>
      <div className={classes.container}>
        {isLoading && (
          <Box sx={{ display: "flex" }}>
            <CircularProgress />
          </Box>
        )}

        <div className={classes.categoriesList}>
          {data?.pages.map((group, i) => {
            return (
              <Fragment key={i}>
                {group?.data?.map((recipe) => {
                  return (
                    <Card
                      key={recipe.id}
                      title={recipe.name}
                      linkRoute={routes.RECIPE_DETAILS}
                      id={recipe.id}
                      buttonText="Recipe details"
                      text={`Price: ${recipe.price} KM`}
                    />
                  );
                })}
              </Fragment>
            );
          })}
        </div>

        {hasNextPage ? (
          <Button onClick={() => fetchNextPage()}>Load more</Button>
        ) : (
          ""
        )}
      </div>
    </>
  );
};
