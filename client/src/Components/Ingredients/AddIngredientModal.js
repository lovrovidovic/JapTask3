import React, { useState, useMemo, useEffect } from "react";
import { Modal } from "../Shared/Modal";
import {
  TextField,
  FormControl,
  MenuItem,
  Select,
  InputLabel,
  Button,
  Autocomplete,
} from "@mui/material";
import useHttp from "../../Hooks/useHttp";
import classes from "./AddIngredientModal.module.css";

export const AddIngredientModal = ({
  showModal,
  handleShowModal,
  handleAddIngredient,
}) => {
  const [units, setUnits] = useState(["g", "kg", "ml", "l", "kom"]);

  const [ingredientValues, setIngredientValues] = useState({
    ingredientId: 1,
    name: "",
    quantity: "",
    unit: "",
    normativePrice: 0,
    normativeQuantity: 0,
    normativeUnit: "",
  });

  const ingredientsRequestObj = useMemo(() => {
    return {
      method: "GET",
      url: "/ingredient",
    };
  }, []);

  const {
    isLoading,
    error,
    sendRequest: getIngredients,
    responseData: ingredients,
  } = useHttp();

  useEffect(() => {
    getIngredients(ingredientsRequestObj);
  }, [getIngredients, ingredientsRequestObj]);

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
          unit: "",
        };
      });
      if (value?.normativeUnit === "g" || value?.normativeUnit === "kg") {
        setUnits(["kg", "g"]);
      } else if (
        value?.normativeUnit === "l" ||
        value?.normativeUnit === "ml"
      ) {
        setUnits(["l", "ml"]);
      } else {
        setUnits("kom");
      }
    }
  };

  const submitHandler = () => {
    if (
      ingredientValues.name !== "" &&
      ingredientValues.unit !== "" &&
      ingredientValues.quantity !== ""
    ) {
      handleAddIngredient(ingredientValues);
      handleShowModal();
    }
  };

  return (
    <div>
      <Modal
        handleShowModal={handleShowModal}
        open={showModal}
        modalTitle="Create"
      >
        <form className={classes.form}>
          <div className={classes.formElementsContainer}>
            {!error && !isLoading && (
              <Autocomplete
                style={{ width: "14em" }}
                onChange={handleAutoComplete}
                options={ingredients.map((ingredient) => {
                  return {
                    label: ingredient.name,
                    id: ingredient.id,
                    normativeUnit: ingredient.normativeUnit,
                    normativePrice: ingredient.normativePrice,
                    normativeQuantity: ingredient.normativeQuantity,
                  };
                })}
                isOptionEqualToValue={(option, value) => option.id === value.id}
                renderInput={(params) => (
                  <TextField {...params} label="Search for an ingredient" />
                )}
              />
            )}

            <FormControl variant="standard" sx={{ m: 1, minWidth: 50 }}>
              <InputLabel id="select">Unit</InputLabel>
              <Select
                name="unit"
                value={ingredientValues.unit}
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

          <Button onClick={submitHandler}>Submit</Button>
        </form>
      </Modal>
    </div>
  );
};
