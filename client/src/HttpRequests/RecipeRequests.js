import axios from "../axios";

export const getRecipes = async ({ pageParam = 0, queryKey }) => {
  const response = await axios.get("/recipes", {
    params: {
      Page: pageParam,
      categoryId: queryKey[1],
      search: queryKey[2],
    },
  });
  return response?.data;
};

export const getRecipeDetails = async ({ queryKey }) => {
  const recipeId = queryKey[1];
  const response = await axios.get(`recipes/${recipeId}`);
  console.log(response?.data.data);
  return response?.data.data;
};

export const createRecipe = async (data) => {
  return await axios.post("/recipes", data);
};

export const updateRecipe = async (data) => {
  return await axios.put("/recipes", data);
};

export const deleteRecipe = async (id) => {
  return await axios.delete(`/recipes/${id}`);
};
