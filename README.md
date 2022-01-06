# JapTask3
Repository with the third and final JAP Task. It holds the frontend and backend of Normative Calculator App. The frontend is made in React and its placed in the client folder. The backend is made in .Net and its placed in the services folder.

# Starting the app using Docker
The entire app (frontend, backend, database, elasticsearch, kibana) is dockerized. You will only need to install docker desktop to launch the app. After installing it, open a terminal in the root directory of the project. There should be a file named `docket-compose.yml` there. After that just run the following command:
```
docker compose up -d
```
You will need to wait some time for the requiered images to be pulled or built. After that is done, open `http://localhost:5000/swagger/index.html` to access swagger for the API. The frontend is running on `http://localhost:3001`

# Things I would like to change in the app
- add more detailed form validation on front and backend
- implement OAuth2
- create custom React components for inputs and tables to clean up code on the frontend
