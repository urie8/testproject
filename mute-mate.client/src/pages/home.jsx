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
          <button>Play</button>
          <button>Sign up</button>
        </div>
      </div>

      
    </>
  );
 
}

export default home;
