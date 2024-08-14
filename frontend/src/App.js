import { BrowserRouter, Route, Routes } from "react-router-dom";
import "./App.css";
import "./index";

import Header from "./Layout/header";
import Login from "./components/Login/Login";
import Register from "./components/Register/Register";
function App() {
  return (
    <BrowserRouter>
      <div className="App">
        <Header />
        <Routes>
          <Route path="/" exact Component={Login} />
          <Route path="/register" Component={Register} />
        </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;
