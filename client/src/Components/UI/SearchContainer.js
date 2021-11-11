import { useEffect, useRef, useState } from "react";
import TextField from "@mui/material/TextField";
import _ from "lodash";

export const SearchContainer = ({
  label,
  searchAction,
}) => {
  const inputValue = useRef();
  const [error, setError] = useState(false);
  const [errorMsg, setErrorMsg] = useState("");
  const [input, setInput] = useState("");

  useEffect(() => {
    if (!_.isEmpty(input) && input.trim().length >= 2) {
      setErrorMsg();
      setError(false);
      const timer = setTimeout(() => {
        searchAction(input);
      }, 1000);
      return () => clearTimeout(timer);
    } else if (_.isEmpty(input)) {
      setErrorMsg();
      setError(false);
      searchAction(input);
    } else if (!input.trim()) {
      setError(true);
      setErrorMsg("Search should not contain only empty space!");
    } else if (input.trim().length < 2) {
      setError(true);
      setErrorMsg("Search must contain more than two characters!");
    }
  }, [input, searchAction]);

  const onChangeHandler = (e) => {
    setInput(e.target.value);
  };

  return (
    <TextField
      ref={inputValue}
      variant="standard"
      label={label}
      onChange={onChangeHandler}
      error={error}
      helperText={errorMsg}
    />
  );
};
