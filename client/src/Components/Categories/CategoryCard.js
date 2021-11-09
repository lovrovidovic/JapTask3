import React from "react";
import Card from "@mui/material/Card";
import CardActions from "@mui/material/CardActions";
import CardContent from "@mui/material/CardContent";
import Button from "@mui/material/Button";
import Typography from "@mui/material/Typography";

export const CategoryCard = ({ name }) => {
  return (
    <Card sx={{ maxWidth: 450, display: "inline-block", margin: "50px" }}>
      <CardContent>
        <Typography variant="body2">{name}</Typography>
      </CardContent>
      <CardActions>
        <Button size="small">Browse recipes</Button>
      </CardActions>
    </Card>
  );
};
