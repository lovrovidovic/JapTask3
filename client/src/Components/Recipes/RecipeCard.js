import React from "react";
import { Card } from "../Shared/Card";
import Button from "@mui/material/Button";
import { IconButton } from "@mui/material";
import { useHistory } from "react-router-dom";
import { generateLink, routesConfiguration as routes } from "../../Router/routes";
import DeleteForeverIcon from "@mui/icons-material/DeleteForever";

export const RecipeCard = ({ title, text, id, deleteHandler }) => {
  const history = useHistory();

  const clickDeleteHandler = () => {
    deleteHandler(id);
  };
  return (
    <Card title={title} text={text}>
      <Button
        size="small"
        onClick={() => history.push(generateLink(routes.RECIPE_DETAILS, { id }))}>
        Recipe Details
      </Button>
      <Button size="small" onClick={() => history.push(generateLink(routes.RECIPE_EDIT, { id }))}>
        Edit
      </Button>
      <IconButton size="small" onClick={() => clickDeleteHandler()}>
        <DeleteForeverIcon fontSize="small" />
      </IconButton>
    </Card>
  );
};
