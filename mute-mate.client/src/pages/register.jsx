import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { ENDPOINTS } from "../api/apiEndpoints";
import { NavLink } from "react-router-dom";
import "../Styles/register.css";

function Register() {
  // state variables for email and passwords
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");
  const navigate = useNavigate();

  // state variable for error messages
  const [error, setError] = useState("");

  const handleLoginClick = () => {
    navigate("/login");
  };

  // handle change events for input fields
  const handleChange = (e) => {
    const { name, value } = e.target;
    if (name === "email") setEmail(value);
    if (name === "password") setPassword(value);
    if (name === "confirmPassword") setConfirmPassword(value);
  };

  // handle submit event for the form
  const handleSubmit = (e) => {
    e.preventDefault();
    // validate email and passwords
    if (!email || !password || !confirmPassword) {
      setError("Please fill in all fields.");
    } else if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email)) {
      setError("Please enter a valid email address.");
    } else if (password !== confirmPassword) {
      setError("Passwords do not match.");
    } else {
      // clear error message
      setError("");
      // post data to the /register api
      fetch(ENDPOINTS.REGISTER, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          email: email,
          password: password,
        }),
      })
        //.then((response) => response.json())
        .then((data) => {
          // handle success or error from the server
          console.log(data);
          if (data.ok) setError("Successful register.");
          else setError("Error registering.");
        })
        .catch((error) => {
          // handle network error
          console.error(error);
          setError("Error registering.");
        });
    }
  };

  return (
    <div className="register-container">
      <div className="containerbox">
        <div className="logoName">
          Mute <br /> Mate
        </div>
        {/* <div className="img-container"></div> */}
        <div className="image-container"></div>

        <h3 className="register-text">Register</h3>
        <div className="form-container">
          <form onSubmit={handleSubmit}>
            <div>
              <label className="register-label-text" htmlFor="email">
                Email:
              </label>
            </div>
            <div>
              <input
                type="email"
                id="email"
                name="email"
                value={email}
                onChange={handleChange}
              />
            </div>
            <div>
              <label className="register-label-text" htmlFor="password">
                Password:
              </label>
            </div>
            <div>
              <input
                type="password"
                id="password"
                name="password"
                value={password}
                onChange={handleChange}
              />
            </div>
            <div>
              <label className="register-label-text" htmlFor="confirmPassword">
                Confirm Password:
              </label>
            </div>
            <div>
              <input
                type="password"
                id="confirmPassword"
                name="confirmPassword"
                value={confirmPassword}
                onChange={handleChange}
              />
            </div>
            {error && <p className="error">{error}</p>}

            <div className="register-btn-container">
              {" "}
              <div>
                <button className="register-button" type="submit">
                  Register
                </button>
              </div>
              <div>
                {/* <button onClick={handleLoginClick}>Go to Login</button> */}
                <NavLink to="/login" className="register-login">
                  Already have an account? Log in.
                </NavLink>
              </div>
            </div>
          </form>
        </div>
      </div>
    </div>
  );
}

export default Register;
