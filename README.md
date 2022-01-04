# JapTask3
Repository with the third and final JAP Task. It holds the frontend and backend of Normative Calculator App. The frontend is made in React and its placed in the client folder. The backend is made in .Net and its placed in the services folder.

# Starting the frontend
To start the React frontend, you have to open the client folder in Visual Studio Code. Then you will open a terminal (make sure the terminal is pointing to the client folder) and run the following command:
`npm install`.
This installs all the necessary node modules. After that create a file named `.env` in the client folder. There you will paste this:
```
REACT_APP_SECRET = "ThisIsMySuperSecretKeyThatNoOneKnows"
REACT_APP_API_BASE_URL = "http://localhost:5000/api"
```
This is the secret key that is used to verify your Json Web Token. After doing this just run `npm start` in the terminal and the app should start in a new browser window. To shut down the app, press `ctrl + c` in the terminal and type `y` when prompted.

# Starting the backend
To start the .Net API you need Visual Studio 2019. You will also need a local postgresSQL server running on port 5432. Open the RecipesAPI.sln file found in the services folder. Apply the `AddedRecommendedPrice` migration using `RecipesDbContext` context. In launchSettings.json change the applicationUrl to `"http://localhost:5000"` and add `"launchUrl": "swagger"` to the RecipeAPI object.\

This version uses Elasticsearch and Kibana inside Docker for logging. You will need Docker installed on your machine. Open a terminal and cd into the docker folder. There you should see a file named `docker-compose.yml`. Just run the following command in your terminal to start Elasticsearch and Kibana:
```
docker-compose up -d
```
After doing this, Elasticsearch should be running on localhost:9200 and Kibana should be running on localhost:5601.

You can launch the app after that.

# Things I would like to change in the app
- add more detailed form validation on front and backend
- implement OAuth2
- create custom React components for inputs and tables to clean up code on the frontend
