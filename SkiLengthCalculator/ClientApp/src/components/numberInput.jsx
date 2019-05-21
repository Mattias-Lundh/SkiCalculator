import React from "react";

const Numberinput = props => {
  return (
    <React.Fragment>
      <div className="input-group mb-3">
        <div className="input-group-prepend">
          <span className="input-group-text">{props.label}</span>
        </div>
        <input
          type="number"
          className="form-control"
          onChange={props.onChange}
        />
      </div>
    </React.Fragment>
  );
};

export default Numberinput;
