import jwt from "jsonwebtoken";

const isLoggedIn = () => {
  let isVerified = true;
  const token = JSON.parse(localStorage.getItem("token"));
  if (!token) return false;
  jwt.verify(token, process.env.REACT_APP_SECRET, function (err, decoded) {
    if (err) {
      isVerified = false;
    }
  });
  console.log(isVerified, "no verify")
  return isVerified;
};

export default isLoggedIn