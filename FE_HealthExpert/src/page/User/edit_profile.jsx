import React from "react";
import splash from './Asset/center.png';

function EditProfile() {
    return (
      <>
    <base href="./" />
    <meta charSet="utf-8" />
    <meta httpEquiv="X-UA-Compatible" content="IE=edge" />
    <title>Admin - Manage</title>
    {/* Main styles for this application*/}
    {/* idk */}
    <div className="flex flex-col bg-orange-500">
      <img src={splash} alt="" className="object-cover h-20" />
      {/* Form */}
      <div className="relative flex h-screen mt-10 mb-5" id="signUpForm">
        <div className="m-auto">
          <div className="bg-white rounded-lg drop-shadow-lg">
            <div className="p-4">
              <div className="">
                <h1 className="text-4xl mb-3 text-center">
                  <b>SIGN UP</b>
                </h1>
                <br />
                <div className="md:flex">
                  <div className="w-36">
                    <label htmlFor="fname" className="text-left">
                      Username:
                    </label>
                  </div>
                  <div className="w-96">
                    <input
                      type="text"
                      className="w-96 border-2"
                      id="uname"
                      name="uname"
                    />
                    <br />
                    <br />
                  </div>
                </div>
                <div className="md:flex">
                  <div className="w-36">
                    <label htmlFor="fpass" className="text-left">
                      Password:
                    </label>
                  </div>
                  <div className="w-96">
                    <input
                      type="password"
                      className="w-96 border-2"
                      id="pass"
                      name="pass"
                    />
                    <br />
                    <br />
                  </div>
                </div>
                <div className="md:flex">
                  <div className="w-36">
                    <label htmlFor="fpass" className="text-left">
                      Full Name:
                    </label>
                  </div>
                  <div className="w-96">
                    <input
                      type="text"
                      className="w-96 border-2"
                      id="fname"
                      name="fname"
                    />
                    <br />
                    <br />
                  </div>
                </div>
                <div className="md:flex">
                  <div className="w-36">
                    <label htmlFor="fpass" className="text-left">
                      Birthday:
                    </label>
                  </div>
                  <div className="w-96">
                    <input
                      type="text"
                      className="w-96 border-2"
                      id="birth"
                      name="birth"
                    />
                    <br />
                    <br />
                  </div>
                </div>
                <div className="md:flex">
                  <div className="w-36">
                    <label htmlFor="fpass" className="text-left">
                      Phone Number:
                    </label>
                  </div>
                  <div className="w-96">
                    <input
                      type="text"
                      className="w-96 border-2"
                      id="phone"
                      name="phone"
                    />
                    <br />
                    <br />
                  </div>
                </div>
                <div className="md:flex">
                  <div className="w-36">
                    <label htmlFor="fpass" className="text-left">
                      Email:
                    </label>
                  </div>
                  <div className="w-96">
                    <input
                      type="text"
                      className="w-96 border-2"
                      id="email"
                      name="email"
                    />
                    <br />
                    <br />
                  </div>
                </div>
                <div className="md:flex">
                  <div className="w-36">
                    <label htmlFor="fpass" className="text-left">
                      Gender:
                    </label>
                  </div>
                  <div className="w-96">
                    <input
                      type="radio"
                      id="gender"
                      name="gender"
                      defaultValue="m"
                    />
                    <label htmlFor="gender">Male</label>
                    <input
                      type="radio"
                      className="ml-3"
                      id="gender"
                      name="gender"
                      defaultValue="f"
                    />
                    <label htmlFor="gender">Female</label>
                    <input
                      type="radio"
                      className="ml-3"
                      id="gender"
                      name="gender"
                      defaultValue="o"
                    />
                    <label htmlFor="gender">Others</label>
                    <input
                      type="radio"
                      className="ml-3"
                      id="gender"
                      name="gender"
                      defaultValue="u"
                    />
                    <label htmlFor="gender">Prefer to not say</label>
                    <br />
                    <br />
                  </div>
                </div>
                <div className="md:flex">
                  <div className="w-48">
                    <label htmlFor="fpass" className="text-left">
                      Are you signing up as a:
                    </label>
                  </div>
                  <div className="w-64">
                    <input
                      type="radio"
                      id="role"
                      name="role"
                      defaultValue="learner"
                    />
                    <label htmlFor="role" className="font-bold mr-5">
                      Learner
                    </label>
                    or a
                    <input
                      type="radio"
                      className="ml-5"
                      id="role"
                      name="role"
                      defaultValue="teacher"
                    />
                    <label htmlFor="role" className="font-bold mr-3">
                      Teacher
                    </label>
                    ?
                  </div>
                </div>
                <br />
                <div className="flex place-content-center">
                  <button
                    type="button"
                    className="text-white bg-orange-600 hover:bg-orange-800 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium rounded-lg w-28 py-2.5 text-center me-2"
                    onclick="signUp()"
                  >
                    Sign Up
                  </button>
                </div>
              </div>
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
    </div>
    {/* FOOTER */}
  </>
  
    );
};

export default SignUp;