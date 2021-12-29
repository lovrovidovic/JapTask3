import React, { useState } from "react";
import { Modal } from "../Shared/Modal";
import { TextField, FormControl, MenuItem, Select, InputLabel, Autocomplete } from "@mui/material";
import classes from "./AddIngredientModal.module.css";
import { useQuery } from "react-query";
import { getIngredients } from "../../HttpRequests/IngredientRequests";
import { Button } from "../Shared/Button";

export const AddIngredientModal = ({ showModal, handleShowModal, handleAddIngredient }) => {
  const [units, setUnits] = useState(["g", "kg", "ml", "l", "kom"]);

  const [ingredientValues, setIngredientValues] = useState({
    ingredientId: 1,
    name: "",
    quantity: "",
    unitType: "",
    normativePrice: 0,
    normativeQuantity: 0,
    normativeUnit: "",
    unitPrice: 0,
  });

  const { data: ingredients, isError, isLoading } = useQuery(["ingredients"], getIngredients);

  const handleFormChange = (e) => {
    setIngredientValues((prevState) => {
      return { ...prevState, [e.target.name]: e.target.value };
    });
  };

  const handleAutoComplete = (e, value) => {
    if (value) {
      setIngredientValues((prevState) => {
        return {
          ...prevState,
          name: value?.label,
          ingredientId: value?.id,
          normativePrice: value?.normativePrice,
          normativeQuantity: value?.normativeQuantity,
          normativeUnit: value?.normativeUnit,
          unitType: "",
          unitPrice: value?.unitPrice,
        };
      });
      if (value?.normativeUnit === "g" || value?.normativeUnit === "kg") {
        setUnits(["kg", "g"]);
      } else if (value?.normativeUnit === "l" || value?.normativeUnit === "ml") {
        setUnits(["l", "ml"]);
      } else {
        setUnits(["kom"]);
      }
    }
  };

  const submitHandler = () => {
    if (
      ingredientValues.name !== "" &&
      ingredientValues.unitType !== "" &&
      ingredientValues.quantity !== ""
    ) {
      handleAddIngredient(ingredientValues);
      handleShowModal();
    }
  };

  const autoCompleteOptions = ingredients?.map((ingredient) => {
    return {
      label: ingredient.name,
      id: ingredient.id,
      normativeUnit: ingredient.normativeUnit,
      normativePrice: ingredient.normativePrice,
      normativeQuantity: ingredient.normativeQuantity,
      unitPrice: ingredient.unitPrice,
    };
  });

  return (
    <div>
      <Modal handleShowModal={handleShowModal} open={showModal} modalTitle="Create">
        <form className={classes.form}>
          <div className={classes.formElementsContainer}>
            {!isError && !isLoading && (
              <Autocomplete
                style={{ width: "14em" }}
                onChange={handleAutoComplete}
                options={autoCompleteOptions}
                isOptionEqualToValue={(option, value) => option.id === value.id}
                renderInput={(params) => <TextField {...params} label="Search for an ingredient" />}
              />
            )}

            <FormControl variant="standard" sx={{ m: 1, minWidth: 50 }}>
              <InputLabel id="select">Unit</InputLabel>
              <Select
                name="unitType"
                value={ingredientValues.unitType}
                label="Select a measurement unit"
                onChange={handleFormChange}
              >
                {units?.map((unit) => {
                  return (
                    <MenuItem key={unit} value={unit}>
                      {unit}
                    </MenuItem>
                  );
                })}
              </Select>
            </FormControl>
          </div>
          <TextField
            label="Ammount: "
            variant="standard"
            name="quantity"
            value={ingredientValues.quantity}
            onChange={handleFormChange}
          />

          <Button onClick={submitHandler} text="Submit" />
        </form>
      </Modal>
    </div>
  );
};
