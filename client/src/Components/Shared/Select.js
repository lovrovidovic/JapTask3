import React from "react";
import { FormControl, MenuItem, Select as MaterialSelect, InputLabel } from "@mui/material";

export const Select = ({ size = 100, label, value, name, items, onChange }) => {
  return (
    <FormControl variant="standard" sx={{ minWidth: size, m: 1 }}>
      <InputLabel id="select">{label}</InputLabel>
      <MaterialSelect value={value} onChange={onChange} name={name}>
        {items?.map((item) => {
          return (
            <MenuItem key={item} value={item}>
              {item}
            </MenuItem>
          );
        })}
      </MaterialSelect>
    </FormControl>
  );
};
