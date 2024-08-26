import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import "../categoryPractise.css";

function CategoryPractiseQuiz({message, linkTo}) {
    const [category, setCategory] = useState([]);
    const navigate = useNavigate();


 function handleImageClick() {
   //Måste kolla vilken bild som klickats

   navigate("/practice");
 }
  return (
    <>
      <div className="page-wrapper">
        {/* <div className="app-name-text">
          <h1 className="head-text">Mute</h1>
          <h1 className="head-text">Mate</h1>
        </div> */}
        <h2 className="choose-text">{message}</h2>
        <div className="option-img-container">
          <img
            className="option-img"
            src="MiiaImages/color-wheel.png"
            onClick={() => handleImageClick("colors")}
          />

          <img
            className="option-img"
            src="MiiaImages/abc.png"
            onClick={() => handleImageClick("letters")}
          />

          <img
            className="option-img"
            src="MiiaImages/livestock.png"
            onClick={() => handleImageClick("animals")}
          />
        </div>
      </div>
    </>
  );
}

export default CategoryPractiseQuiz;
