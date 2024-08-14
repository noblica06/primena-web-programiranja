import React from "react";
import { Link } from "react-router-dom";
import Button from "../Button/Button";
import Input from "../Input/Input";

const Login = () => {
  return (
    <div className="flex flex-col items-center p-10 space-y-20">
      <h1 className="text-3xl font-bold">Login</h1>
      <div className="flex flex-col items-center">
        <form>
          <div>
            <Input label={"Email:"} />
            <Input label={"Password:"} />
          </div>
          <div className="flex justify-between items-center">
            <Link
              to="/register"
              className="text-sm italic hover:text-gray-300 hover:scale-110"
            >
              Not registered?
            </Link>
            <Button text={"Log in"} />
          </div>
        </form>
      </div>
    </div>
  );
};

export default Login;
