import React from "react";

const ceteredImgStyle = {
  margin: "auto",
  width: "40rem",
  position: "relative",
  textAlign: "center",
  color: "red"
};

const imageTextStyle = {
  position: "absolute",
  top: "80%",
  left: "20%",
  fontSize: "2em"
};

const Result = props => {
  return (
    <div>
      <div style={ceteredImgStyle}>
        <img src="display-result.jpg" height="350" alt="nothing to see here" />
        <div style={imageTextStyle}>{props.text}</div>
      </div>
    </div>
  );
};

export default Result;
