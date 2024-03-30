import React, { Fragment, useState } from "react";
import {
  useNavigate
} from "react-router-dom";
import Header from "../../components/Header_admin";
import weighlight from "../../img/weight_light.png";
import { Button, Modal } from 'antd'

import Slider from "react-slick";
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";

import "../../custom_slider.css";

export default function CreateCourseList() {
  const [isModalOpen, setIsModalOpen] = useState(false);
  const showModal = () => {
    setIsModalOpen(true);
  };
  const handleOk = () => {
    setIsModalOpen(false);
  };
  const handleCancel = () => {
    setIsModalOpen(false);
  };
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
        <Content />
        <Content />
        <Content />
        <Content />
        <Content />
        <Content />
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
  const navigate = useNavigate();

  const navigateToManageCourse = () => {
    navigate('/adminCourseHome');
  };

  const [isModalOpen, setIsModalOpen] = useState(false);
  const showModal = () => {
    setIsModalOpen(true);
  };
  const handleOk = () => {
    setIsModalOpen(false);
  };
  const handleCancel = () => {
    setIsModalOpen(false);
  };
  
  return (
    <>
      {/* start one row */}
      <div className="flex mt-[55px]">
        {/* box 1 */}
        <div className="font-[sans-serif] ml-[22px] w-1/3 mr-[22px]" id="course">
          <div className="">
            <div className="flex border-4 border-[#FFA500] rounded-lg drop-shadow-lg">
              {/* left */}
              <div className="p-4 w-3/4">
                <div className="font-bold">
                  Test
                </div>
                <div className="text-xs mt-2">
                  Lộ trình giảm cân là một hành trình tích hợp nhiều yếu tố như chế độ ăn uống, hoạt động thể chất và thay đổi lối sống để đạt được mục tiêu giảm cân một cách hiệu quả và bền vững.
                </div>
                <Button
                  className="mt-5 text-xs text-black rounded-lg bg-[#FFA500] hover:bg-orange-800 font-medium w-36 py-2 text-center" type="primary" 
                  onClick={showModal}>
                  Tạo khóa học
                </Button>
                <Modal className="" title="" open={isModalOpen} onCancel={handleCancel} cancelButtonProps={{ style: { display: 'none' } }} okButtonProps={{ style: { display: 'none' } }}>
                  <p className="ml-5 mb-5 text-2xl">CREATE COURSE</p>
                  <hr />
                  {/* MAIN CONTENT */}
                  <br />
                  <div className="md:flex ">
                    <div className="">
                      <div className="ml-5">
                        <label htmlFor="fname" className="text-left">
                          Course Code:
                        </label>
                      </div>
                      <div className="ml-5">
                        <input type="text" className="border-2 w-[11rem]" id="cid" name="cid" />
                        <br />
                        <br />
                      </div>
                    </div>
                    <div>
                      <div className="ml-5">
                        <label htmlFor="fname" className="text-left">
                          Course Name:
                        </label>
                      </div>
                      <div className="ml-5">
                        <input type="text" className="border-2 w-[16rem]" id="cid" name="cid" />
                        <br />
                        <br />
                      </div>
                    </div>
                  </div>
                  <div className="md:flex">
                    <div>
                      <div className="ml-5">
                        <label htmlFor="fname" className="text-left">
                          Programme:
                        </label>
                      </div>
                      <div className="ml-5">
                        <input type="text" className="border-2 w-[14rem]" id="cid" name="cid" />
                        <br />
                        <br />
                      </div>
                    </div>
                    <div>
                      <div className="ml-5">
                        <label htmlFor="fname" className="text-left">
                          Course Manager:
                        </label>
                      </div>
                      <div className="ml-5">
                        <input type="text" className="border-2 w-[13rem]" id="cid" name="cid" />
                        <br />
                        <br />
                      </div>
                    </div>
                  </div>
                  <div>
                    <div className="ml-5">
                      <label htmlFor="fname" className="text-left">
                        Co-course Manager:
                      </label>
                    </div>
                    <div className="ml-5">
                      <textarea
                        type="text"
                        className="border-2 w-full"
                        id="cid"
                        name="cid"
                        defaultValue={""}
                      />
                      <br />
                      <br />
                    </div>
                  </div>
                  <div className="md:flex">
                    <div>
                      <div className="ml-5">
                        <label htmlFor="fname" className="text-left">
                          Course Type:
                        </label>
                      </div>
                      <div className="ml-5">
                        <input type="text" className="border-2 w-64" id="cid" name="cid" />
                        <br />
                        <br />
                      </div>
                    </div>
                    <div>
                      <div className="ml-5">
                        <label htmlFor="fname" className="text-left">
                          Course Size:
                        </label>
                      </div>
                      <div className="ml-5">
                        <input type="text" className="border-2 w-50" id="cid" name="cid" />
                        <br />
                        <br />
                      </div>
                    </div>
                  </div>
                  <div className="md:flex">
                    <div>
                      <div className="ml-5">
                        <label htmlFor="fname" className="text-left">
                          Member Course Fee ($):
                        </label>
                      </div>
                      <div className="ml-5">
                        <input type="text" className="border-2 w-55" id="cid" name="cid" />
                        <br />
                        <br />
                      </div>
                    </div>
                    <div>
                      <div className="ml-5">
                        <label htmlFor="fname" className="text-left">
                          Non-member Course Fee ($):
                        </label>
                      </div>
                      <div className="ml-5">
                        <input type="text" className="border-2 w-52" id="cid" name="cid" />
                        <br />
                        <br />
                      </div>
                    </div>
                  </div>
                  <div className="flex justify-between">
                    <button
                      type="button"
                      className="text-black bg-white hover:bg-orange-800 border-2 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium w-28 py-1 text-center ml-5"
                      onClick={handleCancel}
                    >
                      Previous
                    </button>
                    <button
                      type="button"
                      className="text-black bg-orange-400 hover:bg-orange-800 border-2 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium w-28 py-1 text-center ml-5"
                      onclick="signUp()"
                    >
                      Next
                    </button>
                  </div>
                </Modal>
              </div>
              {/* right */}
              <div className="relative w-1/4 mr-4 mt-2">
                <img src={weighlight} className="w-20 ml-2" />
              </div>
            </div>
          </div>
        </div>
        {/* box ends */}

        {/* box 2 */}
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
                <Button
                  className="mt-5 text-xs text-black rounded-lg bg-[#FFA500] hover:bg-orange-800 font-medium w-36 py-2 text-center"
                  onClick={showModal}>
                  Tạo khóa học
                </Button>
              </div>
              {/* right */}
              <div className="relative w-1/4 mr-4 mt-2">
                <img src={weighlight} className="w-20 ml-2" />
              </div>
            </div>
          </div>
        </div>
        {/* box ends */}

        {/* box 3 */}
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
                <Button
                  className="mt-5 text-xs text-black rounded-lg bg-[#FFA500] hover:bg-orange-800 font-medium w-36 py-2 text-center"
                  onClick={showModal}>
                  Tạo khóa học
                </Button>
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
        {/* box 4 */}
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
                <Button
                  className="mt-5 text-xs text-black rounded-lg bg-[#FFA500] hover:bg-orange-800 font-medium w-36 py-2 text-center"
                  onClick={showModal}>
                  Tạo khóa học
                </Button>
              </div>
              {/* right */}
              <div className="relative w-1/4 mr-4 mt-2">
                <img src={weighlight} className="w-20 ml-2" />
              </div>
            </div>
          </div>
        </div>
        {/* box ends */}

        {/* box 5 */}
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
                <Button
                  className="mt-5 text-xs text-black rounded-lg bg-[#FFA500] hover:bg-orange-800 font-medium w-36 py-2 text-center"
                  onClick={showModal}>
                  Tạo khóa học
                </Button>
              </div>
              {/* right */}
              <div className="relative w-1/4 mr-4 mt-2">
                <img src={weighlight} className="w-20 ml-2" />
              </div>
            </div>
          </div>
        </div>
        {/* box ends */}
        
        {/* box 6 */}
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
                <Button
                  className="mt-5 text-xs text-black rounded-lg bg-[#FFA500] hover:bg-orange-800 font-medium w-36 py-2 text-center"
                  onClick={showModal}>
                  Tạo khóa học
                </Button>
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

