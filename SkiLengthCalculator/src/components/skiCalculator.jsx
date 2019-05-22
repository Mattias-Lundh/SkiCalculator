import React, { Component } from "react";
import Title from "./title";
import Form from "./form";
import Result from "./result";

class SkiCalculator extends Component {
  state = {
    calculationResult: "",
    styleOptions: ["classic", "freestyle"],
    style: "classic",
    height: 0,
    age: 0
  };

  handleStyleSelectionChange = event => {
    this.setState({ style: event.target.value });
  };

  handleCalculate = () => {
    const { style, height, age } = this.state;
    const parameters = { style, height, age };
    const urlqueryString = Object.keys(parameters)
      .map(key => key + "=" + parameters[key])
      .join("&");

    fetch(
      window.backendURLBase +
        window.backendURLApiDirectory +
        "?" +
        urlqueryString,
      {
        method: "get"
      }
    )
      .then(response => {
        if (!response.ok) throw Error(response.statusText);
        return response.json();
      })
      .then(data => {
        const result = "Recomended Size: " + data.Value;
        this.setState({ calculationResult: result });
      })
      .catch(error => console.log(error));
  };

  handleAgeChange = event => {
    this.setState({ age: event.target.value });
  };

  handleHeightChange = event => {
    this.setState({ height: event.target.value });
  };

  render() {
    return (
      <React.Fragment>
        <Title />
        <Form
          onCalculate={this.handleCalculate}
          onStyleSelectionChange={this.handleStyleSelectionChange}
          styleOptions={this.state.styleOptions}
          selectedStyle={this.state.style}
          onAgeChange={this.handleAgeChange}
          onHeightChange={this.handleHeightChange}
        />
        <Result text={this.state.calculationResult} />
      </React.Fragment>
    );
  }
}

export default SkiCalculator;
