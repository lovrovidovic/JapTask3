import React from "react";
import { useHistory } from "react-router-dom";
import Card from "@mui/material/Card";
import CardActions from "@mui/material/CardActions";
import CardContent from "@mui/material/CardContent";
import Button from "@mui/material/Button";
import Typography from "@mui/material/Typography";
import { generateLink } from "../../Router/routes";

export const CustomCard = ({ linkRoute, id, title, buttonText, text }) => {
  const history = useHistory();

  const clickHandler = () => {
    history.push(generateLink(linkRoute, { id: id }));
  };
  return (
    <Card sx={{ maxWidth: 550, display: "inline-block", margin: "50px" }}>
      <CardContent>
        <Typography variant="body1">{title}</Typography>
        <Typography variant="body2">{text}</Typography>
      </CardContent>
      <CardActions>
        <Button size="small" onClick={clickHandler}>
          {buttonText}
        </Button>
      </CardActions>
    </Card>
  );
};
