import React from "react";
import splash from '../../img/bg.png';
import pfp from '../../img/pfp.png';
import cover from '../../img/course_cover.png';

function YourProfile() {
  return (
    <>
      <base href="./" />
      <meta charSet="utf-8" />
      <meta httpEquiv="X-UA-Compatible" content="IE=edge" />
      {/* Main styles for this application*/}
      {/* idk */}
      <div class="grid gap-4 ml-16 mr-16">
        {/* banner and pfp hijinx */}
        <div class="">
          <img src={splash} alt="" class="relative object-cover w-full h-96 z-0" />
          <div className="flex">
            <div class="flex ml-5 -mt-28 z-10 px-2">
              <img src={pfp} alt="" class="z-10 object-scale-down w-48" />
              <p className='text-xl font-bold ml-8 mt-32'>my NAME???</p>
            </div>
          </div>
        </div>
        {/* two columns */}
        <div class="flex columns-2 gap-4">
          {/* left column: about */}
          <div class="flex-auto border rounded shadow-2xl w-2/5">
            <p class="ml-3 mt-3 font-bold">Giới thiệu</p>
            <br />
            <p class="ml-3 text-center">hi i'm a placeholder</p>
            <br />
            <hr />
            <p class="ml-3 text-center">i'm a different placeholder</p>
          </div>
          {/* right column: joined courses */}
          <div class="flex-auto border rounded shadow-2xl w-3/5">
            <p class="ml-3 mt-3 font-bold">Các khóa học đã tham gia</p>
            <br />
            {/* section for one course begins */}
            <div class="flex px-2 ml-6 mb-7">
              <img src={cover} alt="" class="rounded object-scale-down w-48" />
              <div class="">
                <p className='text-xl font-bold ml-8'>my COURSE???</p>
                <p className="text-ellipsis overflow-hidden line-clamp-4 ml-8 mr-5">my desc???</p>
              </div>
            </div>
            <hr />
            <br />
            {/* section for one course ends */}
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

export default YourProfile;