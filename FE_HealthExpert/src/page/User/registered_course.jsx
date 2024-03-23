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
            <span>
              <span className="align-middle inline-block fill-yellow-900">
                <svg xmlns="http://www.w3.org/2000/svg" x="0px" y="0px" width="24" height="24" viewBox="0 0 24 24">
                  <path fill-rule="evenodd" d="M13.83 19a1 1 0 0 1-.78-.37l-4.83-6a1 1 0 0 1 0-1.27l5-6a1 1 0 0 1 1.54 1.28L10.29 12l4.32 5.36a1 1 0 0 1-.78 1.64z"></path>
                </svg></span>
              <span className=" ml-1 align-middle inline-block font-bold p-1 text-yellow-900">Go Back</span>
            </span>
          </div>
        </div>
        {/* two columns */}
        <p class="ml-3 mt-3 font-bold">Các khóa học bạn đã đăng ký</p>
        <div className="ml-3 mt-3">
          <div class="flex border rounded shadow-2xl columns-2 gap-4 mb-14">
            {/* left column:*/}
            <div class="flex-auto w-4/5">
              <br />
              {/* one course example */}
              <div class="flex px-2 ml-6 mb-7">
                <img src={cover} alt="" class="rounded object-scale-down w-48" />
                <div class="">
                  <p className='text-xl font-bold ml-8'>my COURSE???</p>
                  <p className="text-ellipsis overflow-hidden line-clamp-4 ml-8 mr-5">my desc???</p>
                </div>
              </div>
              {/* one course example ends */}
            </div>
            {/* right column:*/}
            <div class="flex-auto w-1/5">
              <button
                type="button"
                className="text-black bg-orange-400 hover:bg-orange-800 border-2 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium rounded w-44 h-14 py-1 text-center mt-14"

              >
                Xem khóa học
              </button>
            </div>
          </div>


          <div class="flex border rounded shadow-2xl columns-2 gap-4 mb-14">
            {/* left column:*/}
            <div class="flex-auto w-4/5">
              <br />
              {/* one course example */}
              <div class="flex px-2 ml-6 mb-7">
                <img src={cover} alt="" class="rounded object-scale-down w-48" />
                <div class="">
                  <p className='text-xl font-bold ml-8'>my COURSE???</p>
                  <p className="text-ellipsis overflow-hidden line-clamp-4 ml-8 mr-5">my desc???</p>
                </div>
              </div>
              {/* one course example ends */}
            </div>
            {/* right column:*/}
            <div class="flex-auto w-1/5">
              <button
                type="button"
                className="text-black bg-orange-400 hover:bg-orange-800 border-2 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium rounded w-44 h-14 py-1 text-center mt-14"

              >
                Xem khóa học
              </button>
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

export default RegisteredCourse;