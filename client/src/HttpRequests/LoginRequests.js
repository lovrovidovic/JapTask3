import axios from "../axios";

export const login = async (data) => {
  const response = await axios.post("/login", data);
  return response?.data;
};
