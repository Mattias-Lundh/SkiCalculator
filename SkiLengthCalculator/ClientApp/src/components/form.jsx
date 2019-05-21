import React from "react";
import DropdownInput from "./dropdownInput";
import NumberInput from "./numberInput";

const ceteredDivStyle = {
  margin: "auto",
  width: "30rem"
};

const Form = props => {
  return (
    <React.Fragment>
      <div style={ceteredDivStyle}>
        <div className="card text-center">
          <div className="card-header">Enter personal details</div>
          <div className="card-body">
            <DropdownInput
              options={props.styleOptions}
              onChange={props.onStyleSelectionChange}
              selected={props.selectedStyle}
              label="Style"
            />
            <NumberInput label="Heigth (cm)" onChange={props.onHeightChange} />
            <NumberInput label="Age" onChange={props.onAgeChange} />
            <button className="btn btn-danger" onClick={props.onCalculate}>
              Calculate
            </button>
          </div>
        </div>
      </div>
    </React.Fragment>
  );
};

export default Form;
