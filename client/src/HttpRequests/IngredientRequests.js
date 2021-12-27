import axios from "../axios";

export const getIngredients = async () => {
  const response = await axios.get("/ingredients");
  return response?.data.data;
};

export const getPagedIngredients = async (values) => {
  const response = await axios.get("/ingredients/paged", {
    params: {
      page: values.page,
      pageSize: values.pageSize,
      sortBy: values.sortBy,
      sortOrder: values.sortOrder,
      "filters.name": values.filters.name || null,
      "filters.minQuantity": values.filters.minQuantity || null,
      "filters.maxQuantity": values.filters.maxQuantity || null,
      "filters.unitType": values.filters.unitType || null,
    },
  });

  return response?.data.data;
};

export const createIngredient = async (data) => {
  return await axios.post("/ingredients", data);
};

export const updateIngredient = async (data) => {
  return await axios.put("/ingredients", data);
};

export const deleteIngredient = async (id) => {
  return await axios.delete(`/ingredients/${id}`);
};

export const getIngredientDetails = async (id) => {
  const response = await axios.get(`/ingredients/${id}`);
  return response?.data.data;
};
