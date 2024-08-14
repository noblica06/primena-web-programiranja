import React from "react";

const Button = ({ text, onClick }) => (
  <button
    onClick={onClick}
    className="bg-yellow-300 hover:bg-gray-700 hover:text-yellow-300 text-gray-900 font-bold py-2 px-4 rounded shadow-lg transition duration-100 ease-in-out transform hover:scale-110"
  >
    {text}
  </button>
);

export default Button;
