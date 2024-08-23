import React from "react";
import { useNavigate } from "react-router-dom";
//import './Home.css'; // Import the CSS file

function home() {
  const navigate = useNavigate();
  const handleRegisterClick = () => {
    navigate("/register");
  };

import React, { useState, useEffect } from 'react';
import "../Styles/Home.css";

function home() {

  return (
    <>
      <div className="container">
        <div className='text-container'>
          <div><h1 className="title">Mute <br />Mate</h1></div>
          <div><h1 className="tagline">Say Less, Express More</h1></div>
        </div>
        <div className="img-homepage"></div>
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
