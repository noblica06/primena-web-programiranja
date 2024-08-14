import React from "react";
import { Link } from "react-router-dom";

const Header = () => {
  return (
    <div className="bg-gray-900 h-[100px] flex flex-row items-center mb-2 p-2 space-x-4">
      <div className="bg-yellow-300 rounded-lg p-3">
        <Link to="/" className="text-4xl text-semibold text-gray-900">
          TaxiApp
        </Link>
      </div>
    </div>
  );
};

export default Header;
