import React from "react";
import { Card } from "../Shared/Card";
import Button from "@mui/material/Button";
import { useHistory } from "react-router-dom";
import { generateLink, routesConfiguration as routes } from "../../Router/routes";
import { IconButton } from "@mui/material";
import DeleteForeverIcon from "@mui/icons-material/DeleteForever";

export const CategoryCard = ({ title, text, id, deleteHandler }) => {
  const history = useHistory();
  const clickDeleteHandler = () => {
    deleteHandler(id);
  };

  return (
    <Card title={title} text={text}>
      <Button size="small" onClick={() => history.push(generateLink(routes.RECIPES, { id }))}>
        Browse recipes
      </Button>
      <Button
        size="small"
        onClick={() => history.push(generateLink(routes.CATEGORY_DETAILS, { id }))}>
        Edit category
      </Button>
      <IconButton size="small" onClick={() => clickDeleteHandler()}>
        <DeleteForeverIcon fontSize="small" />
      </IconButton>
    </Card>
  );
};
