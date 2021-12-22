import axios from "../axios";

export const getCategories = async ({ pageParam = 0 }) => {
  const response = await axios.get("/categories", {
    params: {
      Page: pageParam,
    },
  });
  return response?.data;
};

export const getAllCategories = async () => {
  const response = await axios.get("/categories", {
    params: {
      Page: -1,
    },
  });
  return response?.data.data;
};

export const createCategory = async (data) => {
  return await axios.post("/categories", data);
};

export const getCategoryDetails = async ({ queryKey }) => {
  const categoryId = queryKey[1];
  const response = await axios.get(`categories/${categoryId}`);
  console.log(response?.data.data);
  return response?.data.data;
};

export const updateCategory = async (data) => {
  console.log(data);
  return await axios.put("/categories", data);
};

export const deleteCategory = async (id) => {
  return await axios.delete(`/categories/${id}`);
};
