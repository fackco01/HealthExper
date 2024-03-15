import React from "react";
import cover from '../../img/course_cover.png';
import Header from "../../components/Header_user";

function RegisteredCourse() {
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
        <div class="flex columns-2 gap-4">
          {/* left column:*/}
          <div class="flex-auto w-4/5">
            <p class="ml-3 mt-3 font-bold">Các khóa học đã đăng ký</p>
            <br />
            {/* one course example */}
            <div class="flex px-2 ml-6 mb-7">
              <img src={cover} alt="" class="rounded object-scale-down w-48" />
              <div class="">
                <p className='text-xl font-bold ml-8'>my COURSE???</p>
                <p className="text-ellipsis overflow-hidden line-clamp-4 ml-8 mr-5">my desc???</p>
              </div>
            </div>
            <hr />
            <br />
            {/* one course example ends */}
            {/* dummy data */}
            <div class="flex px-2 ml-6 mb-7">
              <img src={cover} alt="" class="rounded object-scale-down w-48" />
              <div class="">
                <p className='text-xl font-bold ml-8'>my COURSE???</p>
                <p class="text-ellipsis overflow-hidden line-clamp-4 ml-8 mr-5">
                  Pizza Hut was launched on May 31, 1958, by two brothers, Dan and Frank Carney, both Wichita State
                  students, as a single location in Wichita, Kansas. Six months later they opened a second outlet, and
                  within a year they were operating six locations.</p>
              </div>
            </div>
            <hr />
            <br />
          </div>
          {/* right column:*/}
          <div class="flex-auto w-1/5">
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

export default RegisteredCourse;