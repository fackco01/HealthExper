import React, { useEffect, useState } from "react";
import Logo from "../img/logo.png";
import pfp from '../img/pfp.png';

const Header = () => {
  const [isOpen, setOpen] = useState(false);

  const handleDropDown = () => {
    setOpen(!isOpen);
  };

  return (
    <header className="border-b py-1.2 px-1.2 sm:px-10 bg-white font-[sans-serif] min-h-[70px] shrink-0">
      <div className="flex flex-wrap items-center gap-x-2 max-lg:gap-y-6">
        <a href="javascript:void(0)">
          <img src={Logo} alt="logo" className="w-16 h-16 rounded-full" />
        </a>
        <div className="ml-auto mr-3">
          {/* User menu dropdown */}
          <img id="avatarButton" type="button" class="w-10 h-10 rounded-full cursor-pointer" src={pfp} alt="User dropdown" onClick={handleDropDown} />

          <div
            id="dropdown"
            className={`z-10 absolute right-12 mt-3 bg-white divide-y divide-gray-100 rounded-lg shadow w-44 dark:bg-gray-700 dark:divide-gray-600 ${isOpen ? "block" : "hidden"}`}
          >
            <div class="px-4 py-3 text-gray-900 dark:text-white">
              <div>Username</div>
              <div class="font-medium truncate">mail?</div>
            </div>
            <ul className="py-2 text-sm text-gray-700 dark:text-gray-200">
              <li>
                <a href="#" className="block px-4 py-2 hover:bg-gray-100 dark:hover:bg-gray-600 dark:hover:text-white">
                  Dashboard
                </a>
              </li>
              <li>
                <a href="#" className="block px-4 py-2 hover:bg-gray-100 dark:hover:bg-gray-600 dark:hover:text-white">
                  Setting
                </a>
              </li>
            </ul>    
            <div class="py-1">
              <a href="#" class="block px-4 py-2 text-sm text-gray-700 hover:bg-gray-100 dark:hover:bg-gray-600 dark:text-gray-200 dark:hover:text-white">
                Đăng xuất
                </a>
            </div>
          </div>
        </div>
      </div>
    </header>
  );
};

export default Header;