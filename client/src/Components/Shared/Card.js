import React from "react";
import { Card as MaterialCard } from "@mui/material";
import CardActions from "@mui/material/CardActions";
import CardContent from "@mui/material/CardContent";
import Typography from "@mui/material/Typography";

export const Card = ({ title, text, children }) => {
  return (
    <MaterialCard
      sx={{ maxWidth: 550, display: "inline-block", margin: "70px" }}
    >
      <CardContent>
        <Typography variant="body1">{title}</Typography>
        <Typography variant="body2">{text}</Typography>
      </CardContent>
      <CardActions>{children}</CardActions>
    </MaterialCard>
  );
};
