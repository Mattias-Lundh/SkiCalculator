import "bootstrap/dist/css/bootstrap.css";
import "./index.css";
import React from "react";
import ReactDOM from "react-dom";
import App from "./App";
import registerServiceWorker from "./registerServiceWorker";

window.backendURLBase = "https://skicalculatorapi.azurewebsites.net/";
window.backendURLApiDirectory = "api/calculator";

const rootElement = document.getElementById("root");

ReactDOM.render(<App />, rootElement);

registerServiceWorker();
