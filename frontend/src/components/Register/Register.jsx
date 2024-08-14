import React from "react";
import DatePicker from "react-datepicker";
import Button from "../Button/Button";
import Input from "../Input/Input";

const Register = () => {
  return (
    <div className="flex flex-col items-center bg-grey-100 p-10 space-y-5">
      <h1 className="text-3xl font-bold">Register</h1>
      <div className="flex flex-col items-center">
        <form>
          <div className="flex flex-col space-y-5">
            <Input label={"Email:"} />
            <Input label={"Username:"} />
            <Input label={"Name:"} />
            <Input label={"Last Name:"} />
            <Input label={"Password:"} />
            <Input label={"Date of Birth:"} />
            <Input label={"Address:"} />
            <Input label={"Role:"} />
            <Input label={"Image:"} />
          </div>
          <div className="flex justify-end mt-10">
            <Button text={"Register"} />
          </div>
        </form>
      </div>
    </div>
  );
};

export default Register;
