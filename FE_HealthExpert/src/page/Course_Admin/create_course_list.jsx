import React, { Fragment, useState } from "react";
import cover from '../../img/course_cover.png';
import Header from "../../components/Header_admin";
import weighlight from "../../img/weight_light.png";
import Slider from "react-slick";
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";

import "../../custom_slider.css";

function CreateCourseList() {

  const settings = {
    dots: true,
    arrows: true,
    infinite: true,
    speed: 500,
    slidesToShow: 1,
    slidesToScroll: 1
  };

  return (
    <>
      <base href="./" />
      <meta charSet="utf-8" />
      <meta httpEquiv="X-UA-Compatible" content="IE=edge" />
      {/* Main styles for this application*/}
      {/* idk */}
      <div className="home-page">
        <Header />
      </div>
      <p className="font-[sans-serif] ml-14 mt-7 font-bold text-2xl">Lộ trình học</p>
      <p className="font-[sans-serif] ml-14 w-6/12">Tập trung vào việc tối ưu hóa trải nghiệm tập luyện và tương tác trực tuyến. Đảm bảo giao diện thân thiện, dễ sử dụng.</p>

      {/* Slider */}

      <Slider {...settings} className="mb-6">
        <Content/>
        <Content/>
        <Content/>
        <Content/>
        <Content/>
        <Content/>
      </Slider>

      {/* Slider Ends */}

      <div className="mt-auto">
        <footer className="bg-white">
          <br />
          <hr />
          <br />
          <div>HealtExpert © 2024</div>
        </footer>
      </div>
      {/* FOOTER */}
    </>
  );
};

function Content() {
  return (
    <>
      {/* start one row */}
      <div className="flex mt-[55px]">
        {/* box */}
        <div className="font-[sans-serif] ml-[22px] w-1/3 mr-[22px]" id="course">
          <div className="">
            <div className="flex border-4 border-[#FFA500] rounded-lg drop-shadow-lg">
              {/* left */}
              <div className="p-4 w-3/4">
                <div className="font-bold">
                  Lộ trình giảm cân
                </div>
                <div className="text-xs mt-2">
                  Lộ trình giảm cân là một hành trình tích hợp nhiều yếu tố như chế độ ăn uống, hoạt động thể chất và thay đổi lối sống để đạt được mục tiêu giảm cân một cách hiệu quả và bền vững.
                </div>
                <button
                  type="button"
                  className="mt-5 text-xs text-black rounded-lg bg-[#FFA500] hover:bg-orange-800 font-medium w-36 py-2 text-center"
                  onclick="delete()"
                >
                  Tạo khóa học
                </button>
              </div>
              {/* right */}
              <div className="relative w-1/4 mr-4 mt-2">
                <img src={weighlight} className="w-20 ml-2" />
              </div>
            </div>
          </div>
        </div>
        {/* box ends */}

        {/* box */}
        <div className="font-[sans-serif] ml-[22px] w-1/3 mr-[22px]" id="course">
          <div className="">
            <div className="flex border-4 border-[#FFA500] rounded-lg drop-shadow-lg">
              {/* left */}
              <div className="p-4 w-3/4">
                <div className="font-bold">
                  Lộ trình giảm cân
                </div>
                <div className="text-xs mt-2">
                  Lộ trình giảm cân là một hành trình tích hợp nhiều yếu tố như chế độ ăn uống, hoạt động thể chất và thay đổi lối sống để đạt được mục tiêu giảm cân một cách hiệu quả và bền vững.
                </div>
                <button
                  type="button"
                  className="mt-5 text-xs text-black rounded-lg bg-[#FFA500] hover:bg-orange-800 font-medium w-36 py-2 text-center"
                  onclick="delete()"
                >
                  Tạo khóa học
                </button>
              </div>
              {/* right */}
              <div className="relative w-1/4 mr-4 mt-2">
                <img src={weighlight} className="w-20 ml-2" />
              </div>
            </div>
          </div>
        </div>
        {/* box ends */}
        {/* box */}
        <div className="font-[sans-serif] ml-[22px] w-1/3 mr-[22px]" id="course">
          <div className="">
            <div className="flex border-4 border-[#FFA500] rounded-lg drop-shadow-lg">
              {/* left */}
              <div className="p-4 w-3/4">
                <div className="font-bold">
                  Lộ trình giảm cân
                </div>
                <div className="text-xs mt-2">
                  Lộ trình giảm cân là một hành trình tích hợp nhiều yếu tố như chế độ ăn uống, hoạt động thể chất và thay đổi lối sống để đạt được mục tiêu giảm cân một cách hiệu quả và bền vững.
                </div>
                <button
                  type="button"
                  className="mt-5 text-xs text-black rounded-lg bg-[#FFA500] hover:bg-orange-800 font-medium w-36 py-2 text-center"
                  onclick="delete()"
                >
                  Tạo khóa học
                </button>
              </div>
              {/* right */}
              <div className="relative w-1/4 mr-4 mt-2">
                <img src={weighlight} className="w-20 ml-2" />
              </div>
            </div>
          </div>
        </div>
        {/* box ends */}
      </div>
      {/* end one row */}

      {/* start one row */}
      <div className="flex mt-[35px]">
        {/* box */}
        <div className="font-[sans-serif] ml-[22px] w-1/3 mr-[22px]" id="course">
          <div className="">
            <div className="flex border-4 border-[#FFA500] rounded-lg drop-shadow-lg">
              {/* left */}
              <div className="p-4 w-3/4">
                <div className="font-bold">
                  Lộ trình giảm cân
                </div>
                <div className="text-xs mt-2">
                  Lộ trình giảm cân là một hành trình tích hợp nhiều yếu tố như chế độ ăn uống, hoạt động thể chất và thay đổi lối sống để đạt được mục tiêu giảm cân một cách hiệu quả và bền vững.
                </div>
                <button
                  type="button"
                  className="mt-5 text-xs text-black rounded-lg bg-[#FFA500] hover:bg-orange-800 font-medium w-36 py-2 text-center"
                  onclick="delete()"
                >
                  Tạo khóa học
                </button>
              </div>
              {/* right */}
              <div className="relative w-1/4 mr-4 mt-2">
                <img src={weighlight} className="w-20 ml-2" />
              </div>
            </div>
          </div>
        </div>
        {/* box ends */}

        {/* box */}
        <div className="font-[sans-serif] ml-[22px] w-1/3 mr-[22px]" id="course">
          <div className="">
            <div className="flex border-4 border-[#FFA500] rounded-lg drop-shadow-lg">
              {/* left */}
              <div className="p-4 w-3/4">
                <div className="font-bold">
                  Lộ trình giảm cân
                </div>
                <div className="text-xs mt-2">
                  Lộ trình giảm cân là một hành trình tích hợp nhiều yếu tố như chế độ ăn uống, hoạt động thể chất và thay đổi lối sống để đạt được mục tiêu giảm cân một cách hiệu quả và bền vững.
                </div>
                <button
                  type="button"
                  className="mt-5 text-xs text-black rounded-lg bg-[#FFA500] hover:bg-orange-800 font-medium w-36 py-2 text-center"
                  onclick="delete()"
                >
                  Tạo khóa học
                </button>
              </div>
              {/* right */}
              <div className="relative w-1/4 mr-4 mt-2">
                <img src={weighlight} className="w-20 ml-2" />
              </div>
            </div>
          </div>
        </div>
        {/* box ends */}
        {/* box */}
        <div className="font-[sans-serif] ml-[22px] w-1/3 mr-[22px]" id="course">
          <div className="">
            <div className="flex border-4 border-[#FFA500] rounded-lg drop-shadow-lg">
              {/* left */}
              <div className="p-4 w-3/4">
                <div className="font-bold">
                  Lộ trình giảm cân
                </div>
                <div className="text-xs mt-2">
                  Lộ trình giảm cân là một hành trình tích hợp nhiều yếu tố như chế độ ăn uống, hoạt động thể chất và thay đổi lối sống để đạt được mục tiêu giảm cân một cách hiệu quả và bền vững.
                </div>
                <button
                  type="button"
                  className="mt-5 text-xs text-black rounded-lg bg-[#FFA500] hover:bg-orange-800 font-medium w-36 py-2 text-center"
                  onclick="delete()"
                >
                  Tạo khóa học
                </button>
              </div>
              {/* right */}
              <div className="relative w-1/4 mr-4 mt-2">
                <img src={weighlight} className="w-20 ml-2" />
              </div>
            </div>
          </div>
        </div>
        {/* box ends */}
      </div>
      {/* end one row */}
    </>
  )
}

export default CreateCourseList;