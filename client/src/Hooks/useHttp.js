import { useState, useCallback } from "react";
import axios from "../axios";

const useHttp = () => {
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState(null);
  const [responseData, setResponseData] = useState([]);

  const sendRequest = useCallback(
    ({ method, url, data, params, returnData, additionalFunc }) => {
      setIsLoading(true);
      setError(null);

      axios({
        method: method ? method : "GET",
        url: url,
        data: data || null,
        params: params,
      })
        .then((response) => {
          if (!returnData) {
            setResponseData(response.data.data);
          }
          setIsLoading(false);
          additionalFunc && additionalFunc(response.data.data);
        })
        .catch((e) => {
          setError(e.message || "Something went wrong!");
          console.error(e);
          setIsLoading(false);
        });
    },
    []
  );

  return {
    isLoading,
    error,
    sendRequest,
    responseData,
  };
};

export default useHttp;
