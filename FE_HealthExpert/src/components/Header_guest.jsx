import React from "react";
import Logo from "../img/logo.png";

const Header = () => {
  return (
    <header className="border-b py-1.2 px-1.2 sm:px-10 bg-white font-[sans-serif] min-h-[70px]">
      <div className="flex flex-wrap items-center gap-x-2 max-lg:gap-y-6">
        <a href="javascript:void(0)">
          <img src={Logo} alt="logo" className="w-16 h-16 rounded-full" />
        </a>
        <div className="flex lg:ml-6 max-lg:w-full">
          <div className="flex xl:w-80 max-xl:w-full bg-gray-100 px-6 py-3 rounded outline outline-transparent focus-within:outline-[#FFA500]">
            <input
              type="text"
              placeholder="Search something..."
              className="w-full text-sm bg-transparent rounded outline-none pr-2"
            />
            <svg
              xmlns="http://www.w3.org/2000/svg"
              viewBox="0 0 192.904 192.904"
              width="16px"
              className="cursor-pointer fill-gray-400"
            >
              <path d="m190.707 180.101-47.078-47.077c11.702-14.072 18.752-32.142 18.752-51.831C162.381 36.423 125.959 0 81.191 0 36.422 0 0 36.423 0 81.193c0 44.767 36.422 81.187 81.191 81.187 19.688 0 37.759-7.049 51.831-18.751l47.079 47.078a7.474 7.474 0 0 0 5.303 2.197 7.498 7.498 0 0 0 5.303-12.803zM15 81.193C15 44.694 44.693 15 81.191 15c36.497 0 66.189 29.694 66.189 66.193 0 36.496-29.692 66.187-66.189 66.187C44.693 147.38 15 117.689 15 81.193z"></path>
            </svg>
          </div>
        </div>

        <ul
          id="collapseMenu"
          className="lg:!flex lg:ml-14 lg:space-x-5 max-lg:space-y-2 max-lg:hidden max-lg:py-4 max-lg:w-full"
        >
          <li className="max-lg:border-b max-lg:py-2 px-3">
            <a
              href="javascript:void(0)"
              className="lg:hover:text-[#FFA500] text-[#FFA500] block font-semibold text-[15px]"
            >
              Phòng tập
            </a>
          </li>
          <li className="max-lg:border-b max-lg:py-2 px-3">
            <a
              href="#"
              className="lg:hover:text-[#FFA500] text-gray-500 block font-semibold text-[15px]"
            >
              Dịch vụ
            </a>
          </li>
          <li className="max-lg:border-b max-lg:py-2 px-3">
            <a
              href="javascript:void(0)"
              className="lg:hover:text-[#FFA500] text-gray-500 block font-semibold text-[15px]"
            >
              Tranfor
            </a>
          </li>
          <li className="max-lg:border-b max-lg:py-2 px-3">
            <a
              href="javascript:void(0)"
              className="lg:hover:text-[#FFA500] text-gray-500 block font-semibold text-[15px]"
            >
              Lịch học
            </a>
          </li>
          <li className="max-lg:border-b max-lg:py-2 px-3">
            <a
              href="javascript:void(0)"
              className="lg:hover:text-[#FFA500] text-gray-500 block font-semibold text-[15px]"
            >
              Tin tức
            </a>
          </li>
          <li className="max-lg:border-b max-lg:py-2 px-3">
            <a
              href="javascript:void(0)"
              className="lg:hover:text-[#FFA500] text-gray-500 block font-semibold text-[15px]"
            >
              Về chúng tôi
            </a>
          </li>
        </ul>
        <div className="ml-auto flex mr-3">
          <a href="/signin">
            {" "}
            <button className="bg-orange-500 text-white py-2 px-4 rounded transition-opacity hover:bg-opacity-80 mr-1">
              Login
            </button>
          </a>
          <a href="/signup">
            {" "}
            <button className="bg-orange-500 text-white py-2 px-4 rounded transition-opacity hover:bg-opacity-80 ml-4">
              Sign up
            </button>
          </a>
        </div>
      </div>
    </header>
  );
};

export default Header;