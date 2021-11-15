import jwt from "jsonwebtoken";

const getUserId = () => {
  const token = JSON.parse(localStorage.getItem("token"));
  const decoded = jwt.decode(token);

  return decoded.userId;
};

export default getUserId;
