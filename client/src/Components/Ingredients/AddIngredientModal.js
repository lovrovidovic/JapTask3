import React, { useState, useMemo, useEffect } from "react";
import { Modal } from "../UI/Modal/Modal";
import MenuItem from "@mui/material/MenuItem";
import Select from "@mui/material/Select";
import TextField from "@mui/material/TextField";
import useHttp from "../../Hooks/useHttp";
import Autocomplete from "@mui/material/Autocomplete";
import { Button } from "@mui/material";

export const AddIngredientModal = ({ showModal, handleShowModal, handleAddIngredient }) => {
  const [ingredientValues, setIngredientValues] = useState({
    ingredientId: 1,
    name: "",
    quantity: 0,
    unit: "",
    normativePrice: 0,
    normativeQuantity: 0,
    normativeUnit: "",
  });
  const units = ["g", "kg", "ml", "l", "kom"];

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
    setIngredientValues((prevState) => {
      return {
        ...prevState,
        name: value.label,
        ingredientId: value.id,
        normativePrice: value.normativePrice,
        normativeQuantity: value.normativeQuantity,
        normativeUnit: value.normativeUnit,
      };
    });
  };

  const submitHandler = () => {
    handleAddIngredient(ingredientValues);
    handleShowModal();
  };

  return (
    <div>
      <Modal
        handleShowModal={handleShowModal}
        open={showModal}
        modalTitle="Create"
      >
        <form>
          <Select
            name="unit"
            value={ingredientValues.unit}
            label="Select a measurement unit"
            onChange={handleFormChange}
          >
            {units.map((unit) => {
              return (
                <MenuItem key={unit} value={unit}>
                  {unit}
                </MenuItem>
              );
            })}
          </Select>
          <TextField
            label="Ammount: "
            variant="standard"
            name="quantity"
            value={ingredientValues.quantity}
            onChange={handleFormChange}
          />
          <Autocomplete
            disablePortal
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
          <Button onClick={submitHandler} >Submit</Button>
        </form>
      </Modal>
    </div>
  );
};
