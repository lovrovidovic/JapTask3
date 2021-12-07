import React, { Fragment } from "react";
import CircularProgress from "@mui/material/CircularProgress";
import Box from "@mui/material/Box";
import Alert from "@mui/material/Alert";
import classes from "./Categories.module.css";
import { Card } from "../Shared/Card";
import { Button } from "@mui/material";
import { Header } from "../Shared/Header";
import { routesConfiguration as routes } from "../../Router/routes";
import { useInfiniteQuery } from "react-query";
import { getCategories } from "../../HttpRequests/CategoryRequests";

export const Categories = () => {
  const { data, isError, fetchNextPage, hasNextPage, isLoading } =
    useInfiniteQuery("categories", getCategories, {
      getNextPageParam: (lastPage) => {
        if (lastPage.count === 10) {
          return lastPage.nextPage;
        } else {
          return false;
        }
      },
    });

  return (
    <>
      <Header title="Categories" />
      {isError && (
        <Alert severity="error">
          Error! Cannot get list of recipe categories.
        </Alert>
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
                    <Card
                      key={category.id}
                      title={category.name}
                      linkRoute={routes.RECIPES}
                      id={category.id}
                      buttonText="Browse recipes"
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
