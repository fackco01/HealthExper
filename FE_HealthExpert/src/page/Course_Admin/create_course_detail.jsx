import React, { Fragment, useState } from "react";
import cover from '../../img/course_cover.png';
import Header from "../../components/Header_admin";
import { Tab, Tabs, TabList, TabPanel } from 'react-tabs';
import 'react-tabs/style/react-tabs.css';

function CreateCourseDetail() {
  const [file, setFile] = useState();
  function handleChange(e) {
    console.log(e.target.files);
    setFile(URL.createObjectURL(e.target.files[0]));
  }

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
      <div className="flex h-screen font-[sans-serif]" id="paymentForm">
        <div className="mx-auto mb-auto mt-[150px]">
          <div className="bg-amber-500  border-2 rounded-lg drop-shadow-lg w-[45rem]">
            <div className="p-4">
              <CourseContent />
            </div>
          </div>
        </div>
      </div>
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

function CourseTime() {
  return (
    <>
      <div className="flex font-[sans-serif] mt-10">
        {/* Left */}
        <div className="ml-5 w-1/2">
          <p className="font-bold text-center">Thời hạn khóa học</p>
          <TimeList />
        </div>
        {/* Right */}
        <div className="ml-5 w-1/2 mr-5">
          <img src={cover} className="w-full border-8 rounded-lg border-white" ></img>
        </div>
      </div>
    </>
  );
};

function CourseContent() {

  return (
    <>
      <p className="font-bold text-center my-auto">Nội dung khóa học</p>

      <Tabs className="mt-5" selectedTabClassName="rounded-t border-black border-t border-l border-r bg-[#ffffff]">
        <TabList className="flex" >
          <Tab className="bg-gray-200 rounded-t">
            <p className="mx-2 my-2">
              Tuần 1
            </p>
          </Tab>
          <Tab className="bg-gray-200 rounded-t">
            <p className="mx-2 my-2">
              Ngày 1
            </p>
          </Tab>
        </TabList>

        <TabPanel className="bg-white border-l border-r border-b border-black">
          <h2>Any content 1</h2>
        </TabPanel>
        <TabPanel className="bg-white">
          <h2>Any content 2</h2>
        </TabPanel>
      </Tabs>


      <button
        type="button"
        className="mt-5 text-black bg-white hover:bg-orange-800 border-2 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium w-24 py-2 text-center ml-[585px]"
        onclick="delete()"
      >
        Hoàn tất
      </button>
    </>
  );
};


function TimeList() {

  const [isOpen, setIsOpen] = useState(false);

  const toggleDropdown = () => {
    setIsOpen(!isOpen);
  };

  const closeDropdown = () => {
    setIsOpen(false);
  };

  return (
    <div className="py-2 text-center">
      <div className="relative">
        <button
          type="button"
          className="px-4 py-2 w-full text-black bg-white ring-2 ring-black font-medium rounded-lg text-sm inline-flex items-center"
          onClick={toggleDropdown}
        >
          Chọn thời gian cho khóa học của bạn
          <svg class="w-2.5 h-2.5 ml-9" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 10 6">
            <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="m1 1 4 4 4-4" />
          </svg>
        </button>

        {/* {isOpen && ( */}
        <div className="absolute w-full rounded-lg shadow-lg bg-white ring-1 ring-black ring-opacity-5">
          <ul role="menu" aria-orientation="vertical" aria-labelledby="options-menu">
            <li>
              <a
                href="#"
                className="block px-4 py-2 border-b-2 border-black text-sm text-gray-700 hover:bg-gray-100"
                onClick={closeDropdown}
              >
                1 Tuần
              </a>
            </li>
            <li>
              <a
                href="#"
                className="block px-4 py-2 border-b-2 border-black text-sm text-gray-700 hover:bg-gray-100"
                onClick={closeDropdown}
              >
                2 Tuần
              </a>
            </li>
            <li>
              <a
                href="#"
                className="block px-4 py-2 border-b-2 border-black text-sm text-gray-700 hover:bg-gray-100"
                onClick={closeDropdown}
              >
                3 Tuần
              </a>
            </li>
            <li>
              <a
                href="#"
                className="block px-4 py-2 text-sm text-gray-700 hover:bg-gray-100"
                onClick={closeDropdown}
              >
                12 Tuần
              </a>
            </li>
          </ul>
        </div>
        {/* )} */}
      </div>
    </div>
  )
}

export default CreateCourseDetail;