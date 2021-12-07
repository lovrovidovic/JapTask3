import * as actionTypes from "../../actionTypes";

export const saveToken = (token) => {
  console.log(token)
  return {
    type: actionTypes.SAVE_TOKEN,
    token,
  };
};
