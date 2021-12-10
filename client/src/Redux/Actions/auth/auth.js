import * as actionTypes from "../../actionTypes";

export const saveToken = (token) => {
  return {
    type: actionTypes.SAVE_TOKEN,
    token,
  };
};
