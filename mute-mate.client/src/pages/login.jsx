import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { ENDPOINTS } from "../api/apiEndpoints";
import "../Styles/login.css";

function Login() {
  // state variables for email and password
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [rememberme, setRememberme] = useState(false);
  // state variable for error messages
  const [error, setError] = useState("");
  const navigate = useNavigate();

  // handle change events for input fields
  const handleChange = (e) => {
    const { name, value, type, checked } = e.target;
    if (name === "email") setEmail(value);
    if (name === "password") setPassword(value);
    if (name === "rememberme") setRememberme(checked);
  };

  const handleRegisterClick = () => {
    navigate("/register");
  };

  // handle submit event for the form
  const handleSubmit = (e) => {
    e.preventDefault();
    // validate email and password
    if (!email || !password) {
      setError("Please fill in all fields.");
    } else {
      // clear error message
      setError("");
      // post data to the /login api
      const loginurl = rememberme
        ? `${ENDPOINTS.LOGIN}?useCookies=true`
        : `${ENDPOINTS.LOGIN}?useSessionCookies=true`;

      fetch(loginurl, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          email: email,
          password: password,
        }),
      })
        .then((response) => {
          // handle success or error from the server
          if (response.ok) {
            setError("Successful Login.");
            window.location.href = "/";
          } else {
            setError("Error Logging In.");
          }
        })
        .catch((error) => {
          // handle network error
          console.error(error);
          setError("Error Logging in.");
        });
    }
  };

  return (
    <div className="containerbox">
      <h3 className="login-text">Login</h3>
      <div className="img-container"></div>
      <form onSubmit={handleSubmit}>
        <div>
          <label className="forminput" htmlFor="email">
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
          <label htmlFor="password">Password:</label>
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
          <input
            type="checkbox"
            id="rememberme"
            name="rememberme"
            checked={rememberme}
            onChange={handleChange}
          />
        </div>
        <span>Remember Me</span>
        <div className="btn-container">
        <div>
          <button type="submit">Login</button>
        </div>
        <div>
          <button type="button" onClick={handleRegisterClick}>
            Register
          </button>
        </div>
        </div>

      </form>
      {error && <p className="error">{error}</p>}
    </div>
  );
}

export default Login;
