import React from "react";
import {
  useNavigate
} from "react-router-dom";
import Header from "../../components/Header_user";
import vid from "../../img/YTCPVideo10.mp4";

function Lesson() {
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
          <aside className="w-1/4 overflow-y-auto border-r-4">
            <div className="h-full overflow-y-auto">
              <div className="font-medium px-3 py-4">
                <h2 className="font-bold p-1 text-yellow-900">
                  Go Back
                </h2>
              </div>
              <hr />
              <ul className="font-medium px-3 py-4 ml-8">
                <h2 className="font-bold p-1 text-yellow-900">
                  Chapter 1: To Create a Title
                </h2>
                <li>
                  <a className="flex items-center p-1 text-yellow-900 rounded-lg group">
                    <svg
                      className="w-5 h-5"
                      aria-hidden="true"
                      fill="currentColor"
                      viewBox="0 0 22 21"
                    />
                    <span className="ms-3">A Video</span>
                  </a>
                </li>
                <li>
                  <a className="flex items-center p-1 text-yellow-900 rounded-lg group">
                    <svg
                      className="w-5 h-5"
                      aria-hidden="true"
                      fill="currentColor"
                      viewBox="0 0 22 21"
                    />
                    <span className="ms-3">A Read</span>
                  </a>
                </li>
                <li>
                  <a className="flex items-center p-1 text-yellow-900 rounded-lg group">
                    <svg
                      className="w-5 h-5"
                      aria-hidden="true"
                      fill="currentColor"
                      viewBox="0 0 22 21"
                    />
                    <span className="ms-3">A Test</span>
                  </a>
                </li>
              </ul>
            </div>
          </aside>
          <main className="w-3/4 overflow-y-auto">
            <div className="mt-16 ml-9">
              <p className="text-5xl">AS VIDEO</p>
              <video width="320" height="240" controls="controls">
                <source src={vid} type="video/mp4" />
              </video>
              <br/>
              <iframe width="420" height="315"
                src="https://www.youtube.com/embed/Q_YwajWURu8">
              </iframe>
              <br/>

              <p className="text-5xl">AS TEXT</p>
              <div className="mt-5 ml-11">
                b
              </div>
              <br/>
              
              <p className="text-5xl">AS TEST</p>
              <br/>

            </div>
          </main>
        </div>
      </div>
    </>

  );
};

export default Lesson;