import jwt from "jsonwebtoken";
import { useSelector } from "react-redux";

const useIsAdmin = () => {
  const token = useSelector((state) => state.auth.token);
  var decodedToken = jwt.decode(token, { complete: true });
  if (decodedToken.payload.Role === "Admin") return true;

  return false;
};

export default useIsAdmin;
