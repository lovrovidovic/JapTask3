import axios from "../axios";

export const getIngredients = async () => {
  const response = await axios.get("/ingredients");
  return response?.data.data;
};
