import * as actionTypes from "../../actionTypes";

const initialState = {
  token: null,
};

const saveToken = (state, action) => ({
  ...state,
  token: action.token,
});

const reducer = (state = initialState, action) => {
  switch (action.type) {
    case actionTypes.SAVE_TOKEN:
      return saveToken(state, action);
    default:
      return state;
  }
};

export default reducer;
