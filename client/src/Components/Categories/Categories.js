import React, { useEffect, useMemo, useState } from "react";
import CircularProgress from "@mui/material/CircularProgress";
import Box from "@mui/material/Box";
import useHttp from "../../Hooks/useHttp";
import Alert from "@mui/material/Alert";
import classes from "./Categories.module.css";
import { CategoryCard } from "./CategoryCard";
import { Button } from "@mui/material";
import { Header } from "../UI/Header"

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
      {isLoading && !error && (<>
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
          return <CategoryCard key={category.id} name={category.name} />;
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
