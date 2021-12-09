import React from "react";
import { useHistory } from "react-router-dom";
import { Card as MaterialCard } from "@mui/material";
import CardActions from "@mui/material/CardActions";
import CardContent from "@mui/material/CardContent";
import Button from "@mui/material/Button";
import Typography from "@mui/material/Typography";

export const Card = ({ linkRoute, title, buttonText, text }) => {
  const history = useHistory();

  const clickHandler = () => {
    history.push(linkRoute);
  };
  return (
    <MaterialCard
      sx={{ maxWidth: 550, display: "inline-block", margin: "70px" }}
    >
      <CardContent>
        <Typography variant="body1">{title}</Typography>
        <Typography variant="body2">{text}</Typography>
      </CardContent>
      <CardActions>
        <Button size="small" onClick={clickHandler}>
          {buttonText}
        </Button>
      </CardActions>
    </MaterialCard>
  );
};
