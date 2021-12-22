import React, { useState, Fragment } from "react";
import { useParams, useHistory } from "react-router-dom";
import { generateLink, routesConfiguration as routes } from "../../Router/routes";
import { Header } from "../Shared/Header";
import { Search } from "../Shared/Search";
import CircularProgress from "@mui/material/CircularProgress";
import Box from "@mui/material/Box";
import Alert from "@mui/material/Alert";
import Button from "@mui/material/Button";
import IconButton from "@mui/material/IconButton";
import AddCircleIcon from "@mui/icons-material/AddCircle";
import classes from "./Recipes.module.css";
import { useInfiniteQuery, useMutation } from "react-query";
import { deleteRecipe, getRecipes } from "../../HttpRequests/RecipeRequests";
import useIsLoggedIn from "../../Hooks/useIsLoggedIn";
import { RecipeCard } from "./RecipeCard";
import { SuccessToaster } from "../Shared/SuccessToaster";

export const Recipes = () => {
  const params = useParams();
  const categoryId = params.id;
  const isLoggedIn = useIsLoggedIn();
  const history = useHistory();
  const [successAlertOpen, setSuccessAlertOpen] = useState(false);
  const [search, setSearchValue] = useState("");

  const { data, isError, fetchNextPage, hasNextPage, isLoading, refetch } = useInfiniteQuery(
    ["recipes", categoryId, search],
    getRecipes,
    {
      getNextPageParam: (lastPage) => {
        if (lastPage.count === 10) {
          return lastPage.nextPage;
        } else {
          return false;
        }
      },
    }
  );

  const deleteRecipeMutation = useMutation(deleteRecipe, {
    onSuccess: () => {
      setSuccessAlertOpen(true);
      refetch();
    },
  });

  const addRecipeHandler = () => {
    history.push(generateLink(routes.RECIPE_CREATE));
  };

  const deleteHandler = (id) => {
    if (window.confirm("Are you sure you want to delete this?")) {
      deleteRecipeMutation.mutate(id);
      refetch();
    }
  };

  return (
    <>
      <Header title="Recipes" />
      {isError && (
        <Alert severity="error">Error! Cannot get list of recipes for this category.</Alert>
      )}
      <div className={classes.actions}>
        <Search label="Search recipes" searchAction={setSearchValue} />
        {isLoggedIn ? (
          <IconButton size="large" onClick={addRecipeHandler}>
            <AddCircleIcon fontSize="large" />
          </IconButton>
        ) : (
          <></>
        )}
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
                    <RecipeCard
                      key={recipe.id}
                      title={recipe.name}
                      id={recipe.id}
                      buttonText="Recipe details"
                      text={`Price: ${recipe.price} KM`}
                      deleteHandler={deleteHandler}
                    />
                  );
                })}
              </Fragment>
            );
          })}
        </div>

        {hasNextPage ? <Button onClick={() => fetchNextPage()}>Load more</Button> : ""}
      </div>
      <SuccessToaster
        open={successAlertOpen}
        setOpen={setSuccessAlertOpen}
        text={"Create successful!"}
      />
    </>
  );
};
