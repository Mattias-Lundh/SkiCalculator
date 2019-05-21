import React, { Component } from "react";
import SkiCalculator from "./components/skiCalculator";

export default class App extends Component {
  displayName = App.name;

  render() {
    return <SkiCalculator />;
  }
}
