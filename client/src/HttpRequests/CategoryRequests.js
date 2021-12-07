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
