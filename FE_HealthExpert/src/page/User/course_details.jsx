import React from "react";
import {
  useNavigate
} from "react-router-dom";
import Header from "../../components/Header_user";
import cover from '../../img/course_cover.png';
import quiz_icon from "../../img/quiz_icon.png";
import vid_icon from "../../img/video_icon.png";
import read_icon from "../../img/read_icon.png";

function CourseDetails() {
  const navigate = useNavigate();

  const navigateToManageUser = () => {
    navigate('/manageUser');
  };

  return (
    <>
      <base href="./" />
      <meta charSet="utf-8" />
      <meta httpEquiv="X-UA-Compatible" content="IE=edge" />
      <title>Create New Course</title>
      {/* Main styles for this application*/}
      {/* SIDEBAR */}
      <div className="flex flex-col h-screen">
        <Header />
        <div className="flex flex-row h-[calc(100vh-5rem)] font-[sans-serif]">
          { /* Week List */}
          <aside className="w-1/4 overflow-y-auto border-r-4">
            <div className="h-full overflow-y-auto">
              <div className="font-medium px-3 py-4">
                <h2 className="font-bold p-1 text-yellow-900">
                  Go Back
                </h2>
              </div>
              <hr />
              <ul className="font-medium px-3 py-4 ml-8">
                <li>
                  <a className="font-bold p-1 text-yellow-900">
                    <img src={null} alt="logo" className="w-5 h-5" />
                    <p className="ms-3">WEEK 1</p>
                  </a>
                </li>
                <li>
                  <a className="font-bold p-1 text-yellow-900">
                    <img src={null} alt="logo" className="w-5 h-5" />
                    <p className="ms-3">WEEK 2</p>
                  </a>
                </li>
                <li>
                  <a className="font-bold p-1 text-yellow-900">
                    <img src={null} alt="logo" className="w-5 h-5" />
                    <p className="ms-3">WEEK 3</p>
                  </a>
                </li>
              </ul>
            </div>
          </aside>
          { /* Main Stuff */}
          <main className="w-3/4 overflow-y-auto">
            { /* Course Name */}
            <div className="mt-10 ml-9 mr-9">
              <div class="flex columns-2 gap-4">
                <div class="flex-auto w-3/4">
                  <p className="font-bold text-3xl">
                    COURSE NAME
                  </p>
                  <br />
                  <p>
                    Course descriptions
                  </p>
                </div>
                <div className="flex-auto w-1/4">
                    <img src={cover} alt="course_cover" className="w-15" />
                </div>
              </div>
            </div>
            { /* Course Details */}
            <div className="mt-5 ml-9 mr-9 border rounded shadow-2xl flex-auto">
              <ul className="font-medium px-3 py-4 ml-8">
                <h2 className="font-bold p-1 text-yellow-900">
                  Course Title
                </h2>
                <li>
                  <a className="flex items-center p-1 text-yellow-900 rounded-lg group ml-12 hover:bg-slate-200 hover:underline-offset-1 hover:text-yellow-400 hover:cursor-pointer">
                    <img src={vid_icon} alt="logo" className="w-5 h-5" />
                    <p className="ms-3">Lesson Name<br/>
                    <p className="text-sm whitespace">Lesson Description</p>
                    </p>
                  </a>
                </li>
                <li>
                  <a className="flex items-center p-1 text-yellow-900 rounded-lg group ml-12 hover:bg-slate-200 hover:underline-offset-1 hover:text-yellow-400 hover:cursor-pointer">
                    <img src={read_icon} alt="logo" className="w-5 h-5" />
                    <p className="ms-3">Lesson Name<br/>
                    <p className="text-sm whitespace">Lesson Description</p>
                    </p>
                  </a>
                </li>
                <li>
                  <a className="flex items-center p-1 text-yellow-900 rounded-lg group ml-12 hover:bg-slate-200 hover:underline-offset-1 hover:text-yellow-400 hover:cursor-pointer">
                    <img src={quiz_icon} alt="logo" className="w-5 h-5" />
                    <p className="ms-3">Lesson Name<br/>
                    <p className="text-sm whitespace">Lesson Description</p>
                    </p>
                  </a>
                </li>
              </ul>
            </div>
          </main>
        </div>
      </div>
    </>

  );
};

export default CourseDetails;