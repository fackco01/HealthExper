import React, { useState } from "react";
import cover from '../../img/course_cover.png';
import Header from "../../components/Header_user";

function CreateCourseSimple() {
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
      <div class="grid gap-4 ml-16 mr-16">
        <div class="">
          <div className="font-medium px-3 py-4">
            <h2 className="font-bold p-1 text-yellow-900">
              Go Back
            </h2>
          </div>
        </div>
        {/* two columns */}
        <p class="ml-3 mt-3 font-bold text-lg">Tạo khóa học mới:</p>
        <div className="ml-3 mt-3">
          {/* Title */}
        <div>
          <div className="ml-5">
            <label htmlFor="fname" className="text-left">
              Course Title:
            </label>
          </div>
          <div className="ml-5 mt-1 mr-48">
            <input type="text" className="border-2 w-full" id="cid" name="cid" />
            <br />
            <br />
          </div>
        </div>
        {/* Title End */}
        {/* Content */}
        <div>
          <div className="ml-5">
            <label htmlFor="fname" className="text-left">
              Content:
            </label>
          </div>
          <div className="ml-5 mt-1 mr-48">
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
        {/* Content End */}
        {/* Image */}
        <div>
          <div className="ml-5">
            <label htmlFor="fname" className="text-left">
              Image:
            </label>
          </div>
          <div className="ml-5 mt-1">
            <input type="file" onChange={handleChange} />
            <img src={file} />
            <br />
            <br />
          </div>
        </div>
        {/* Image End */}

        <div className="md:flex">
          <button
            type="button"
            className="text-black bg-white hover:bg-orange-800 border-2 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium w-28 py-1 text-center ml-5"
            onClick="#"
          >
            Go Back
          </button>
          <button
            type="button"
            className="text-white bg-orange-600 hover:bg-orange-800 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium py-1 text-center w-40 ml-5"
            onclick="#"
          >
            Create Course
          </button>
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

export default CreateCourseSimple;