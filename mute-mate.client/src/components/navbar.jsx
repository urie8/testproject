

import React from "react";
import { NavLink } from "react-router-dom";
import logo from "../images/MuteMateLogo.png";
import vines from "../images/vines.png";

import "../navbar.css";
import Hamburger from "hamburger-react";
import { useClickAway } from "react-use";
import { useRef } from "react";
import { useState } from "react";
import { AnimatePresence, motion } from "framer-motion";

function Navbar() {
  const [isOpen, setOpen] = useState(false);

  const ref = useRef(null);

  // Close the menu when clicking outside of it
  useClickAway(ref, () => setOpen(false));

  return (
    <>

      <div className="navbar-wrapper" ref={ref}>
        <NavLink to="/">
          <img src={logo} alt="Logo" className="navbar-logo" />
        </NavLink>
        {/* <img src={logo} alt="Logo" className="navbar-logo" /> */}
        <div className="mute-mate-text">MUTE MATE</div>
        <Hamburger
          toggled={isOpen}
          toggle={setOpen}
          className="hamburger-react"
        />
        <AnimatePresence>
          {isOpen && (
            <motion.div
              className="dropdown-menu"
              initial={{ opacity: 0, y: -20 }}
              animate={{ opacity: 1, y: 0 }}
              exit={{ opacity: 0, y: -20 }}
            >
              <NavLink
                to="/login"
                className="dropdown-link"
                onClick={() => setOpen(false)}
              >
                Register
              </NavLink>
              <NavLink
                to="/categoryQuiz"
                className="dropdown-link"
                onClick={() => setOpen(false)}
              >
                Quiz
              </NavLink>
              <NavLink
                to="/categoryPractise"
                className="dropdown-link"
                onClick={() => setOpen(false)}
              >
                Practice
              </NavLink>
              <NavLink
                to="/about"
                className="dropdown-link"
                onClick={() => setOpen(false)}
              >
                About
              </NavLink>
              <NavLink
                to="/myPage"
                className="dropdown-link"
                onClick={() => setOpen(false)}
              >
                Profile
              </NavLink>

              {/* TODO: profile ska bara synas om man är inloggad */}
            </motion.div>
          )}
        </AnimatePresence>
      </div>
n
    </>
  );

}

export default Navbar;
