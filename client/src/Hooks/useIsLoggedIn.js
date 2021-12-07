import jwt from "jsonwebtoken";
import { useSelector } from "react-redux";

const useIsLoggedIn = () => {
  const token = useSelector((state) => state.auth.token);
  let isVerified = true;
  if (token == null) return false;
  jwt.verify(token, process.env.REACT_APP_SECRET, function (err, decoded) {
    if (err) {
      isVerified = false;
    }
  });
  return isVerified;
};

export default useIsLoggedIn;
