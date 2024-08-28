import React, { useState, useEffect } from "react";
import "../Styles/myPage.css";
import banana from "../images/banan1.png";
import vines from "../images/vines.png";
import { useNavigate } from "react-router-dom";
import colorwheel from "/public/MiiaImages/color-wheel.png";
import alphabet from "/public/MiiaImages/abc.png";
import livestock from "/public/MiiaImages/livestock.png";

//Import från API, användaruppgifter och poäng.

function myPage() {
  return (
    <>
      <div className="Container-profile">
        <div className="title-profile-container">
          <h1 className="title-profile">
            PROFILE PAGE
            {/* <div className="picture-container">
            <img src={vines} alt="vines" className="vines-1" />
            <img src={vines} alt="vines" className="vines-1" />
          </div> */}
          </h1>
        </div>

        {/*Container för category.
        Container under för att se alla bananer /kategori */}
        <div className="userNameContainer">
          <div className="display-userName">username </div>
          {/* Username ska hämtas här */}
        </div>
      </div>

      <div className="banana-display">
        <img src={banana} alt="banan" className="banana1" />
        <div className="banana-point">Hämta bananer här från API</div>
        <div className="banana-text">Your collected bananas!</div>
      </div>
      <div className="score-display">
        <div className="Category-ColorWheel">
          <img
            src={colorwheel}
            alt="colorwheel"
            className="colorwheel-profile"
          />
        </div>
        <div className="Category-alphabet">
          <img src={alphabet} alt="alphabet" className="alphabet-profile" />
          Collected bananas in this category:
        </div>
        <div className="Category-ColorWheel">
          <img src={livestock} alt="animals" className="colorwheel-animals" />
        </div>
      </div>
    </>
  );
}

export default myPage;
