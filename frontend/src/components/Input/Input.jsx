import React from "react";

const Input = ({ label, type = "text", value, onChange, placeholder }) => {
  return (
    <div className="mb-4 flex flex-row items-center space-x-10">
      {label && (
        <label className="block w-32 text-sm font-semibold mb-2">{label}</label>
      )}
      <input
        type={type}
        value={value}
        onChange={onChange}
        placeholder={placeholder}
        className="w-full bg-gray-900 px-3 py-2 border border-gray-700 rounded-lg shadow-sm focus:outline-none focus:ring-2 focus:ring-yellow-300"
      />
    </div>
  );
};

export default Input;
