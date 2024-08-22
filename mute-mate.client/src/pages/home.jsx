import React from "react";
import { useNavigate } from "react-router-dom";
//import './Home.css'; // Import the CSS file

function home() {
  const navigate = useNavigate();
  const handleRegisterClick = () => {
    navigate("/register");
  };

  return (
    <>
      <div className="container">
        <h1 className="title">Mute Mate</h1>
        <p className="tagline">Say Less, Express More</p>
        <div className="img-homepage">{/*Insert image here*/}</div>
        <div className="button-container">
          <button className="button">Play</button>
          <button className="button" onClick={handleRegisterClick}>
            Sign up
          </button>
        </div>
      </div>
    </>
  );
}

export default home;
