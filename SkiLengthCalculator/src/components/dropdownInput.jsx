import React from "react";

const Dropdowninput = props => {
  return (
    <React.Fragment>
      <div className="input-group mb-3">
        <div className="input-group-prepend">
          <label className="input-group-text" htmlFor="inputGroupSelect01">
            {props.label}
          </label>
        </div>
        <select
          value={props.selected}
          className="custom-select"
          id="inputGroupSelect01"
          onChange={props.onChange}
        >
          {props.options.map(option => (
            <option key={option} value={option}>
              {option}
            </option>
          ))}
        </select>
      </div>
    </React.Fragment>
  );
};

export default Dropdowninput;
