import React, { useEffect, useMemo, useState } from "react";
import CircularProgress from "@mui/material/CircularProgress";
import Box from "@mui/material/Box";
import useHttp from "../../Hooks/useHttp";
import Alert from "@mui/material/Alert";
import classes from "./Categories.module.css";
import { CustomCard } from "../UI/CustomCard";
import { Button } from "@mui/material";
import { Header } from "../UI/Header";
import { routesConfiguration as routes } from "../../Router/routes";

export const Categories = () => {
  const [displayed, setDisplayed] = useState(10);
  const {
    isLoading,
    error,
    sendRequest: getCategories,
    responseData: categories,
  } = useHttp();

  const requestObj = useMemo(() => {
    return { url: "/category", params: { n: displayed } };
  }, [displayed]);

  useEffect(() => {
    getCategories(requestObj);
  }, [getCategories, requestObj]);

  const loadMoreHandler = () => {
    setDisplayed((prevState) => {
      setDisplayed(prevState + 10);
    });
  };

  return (
    <>
      <Header title="Categories" />
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
            Error! Cannot get list of recipe categories.
          </Alert>
        )}
        <div className={classes.categoriesList}>
          {categories?.map((category) => {
            return (
              <CustomCard
                key={category.id}
                title={category.name}
                linkRoute={routes.RECIPES}
                id={category.id}
                buttonText="Browse recipes"
              />
            );
          })}
        </div>

        {categories.length >= displayed ? (
          <Button onClick={loadMoreHandler}>Load more</Button>
        ) : (
          ""
        )}
      </div>
    </>
  );
};
