import React, { Fragment, useState } from "react";
import { useHistory } from "react-router-dom";
import CircularProgress from "@mui/material/CircularProgress";
import Box from "@mui/material/Box";
import Alert from "@mui/material/Alert";
import classes from "./Categories.module.css";
import { Button } from "@mui/material";
import { Header } from "../Shared/Header";
import {
  generateLink,
  routesConfiguration as routes,
} from "../../Router/routes";
import { useInfiniteQuery, useMutation } from "react-query";
import {
  deleteCategory,
  getCategories,
} from "../../HttpRequests/CategoryRequests";
import useIsLoggedIn from "../../Hooks/useIsLoggedIn";
import IconButton from "@mui/material/IconButton";
import AddCircleIcon from "@mui/icons-material/AddCircle";
import { CategoryCard } from "./CategoryCard";
import { SuccessToaster } from "../Shared/SuccessToaster";

export const Categories = () => {
  const history = useHistory();
  const [successAlertOpen, setSuccessAlertOpen] = useState(false);

  const { data, isError, fetchNextPage, hasNextPage, isLoading, refetch } =
    useInfiniteQuery("categories", getCategories, {
      getNextPageParam: (lastPage) => {
        if (lastPage.count === 10) {
          return lastPage.nextPage;
        } else {
          return false;
        }
      },
    });

  const deleteCategoryMutation = useMutation(deleteCategory, {
    onSuccess: () => {
      setSuccessAlertOpen(true);
      refetch();
    },
  });

  const isLoggedIn = useIsLoggedIn();

  const addRecipeHandler = () => {
    history.push(generateLink(routes.CATEGORY_CREATE));
  };

  const deleteHandler = (id) => {
    if (window.confirm("Are you sure you want to delete this?")) {
      deleteCategoryMutation.mutate(id);
      refetch();
    }
  };
  return (
    <>
      <Header title="Categories" />
      {isError && (
        <Alert severity="error">
          Error! Cannot get list of recipe categories.
        </Alert>
      )}
      {isLoggedIn ? (
        <IconButton size="large" onClick={addRecipeHandler}>
          <AddCircleIcon fontSize="large" />
        </IconButton>
      ) : (
        <></>
      )}
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
                {group?.data?.map((category) => {
                  return (
                    <CategoryCard
                      key={category.id}
                      title={category.name}
                      id={category.id}
                      deleteHandler={deleteHandler}
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
      <SuccessToaster
        open={successAlertOpen}
        setOpen={setSuccessAlertOpen}
        text={"Action successful!"}
      />
    </>
  );
};
