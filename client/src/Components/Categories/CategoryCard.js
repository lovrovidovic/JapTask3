import React from "react";
import { Card } from "../Shared/Card";
import { useHistory } from "react-router-dom";
import { generateLink, routesConfiguration as routes } from "../../Router/routes";
import { IconButton } from "@mui/material";
import DeleteForeverIcon from "@mui/icons-material/DeleteForever";
import { Button } from "../Shared/Button";

export const CategoryCard = ({ title, text, id, deleteHandler }) => {
  const history = useHistory();
  const clickDeleteHandler = () => {
    deleteHandler(id);
  };

  return (
    <Card title={title} text={text}>
      <Button
        text="Browse recipes"
        size="small"
        onClick={() => history.push(generateLink(routes.RECIPES, { id }))}
      />
      <Button
        text="Edit category"
        size="small"
        onClick={() => history.push(generateLink(routes.CATEGORY_DETAILS, { id }))}
      />
      <IconButton size="small" onClick={() => clickDeleteHandler()}>
        <DeleteForeverIcon fontSize="small" />
      </IconButton>
    </Card>
  );
};
