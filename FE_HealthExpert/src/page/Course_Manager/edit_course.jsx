import React from "react";
import cover from '../../img/course_cover.png';
import Header from "../../components/Header_user";
import quiz_icon from "../../img/quiz_icon.png";
import vid_icon from "../../img/video_icon.png";
import read_icon from "../../img/read_icon.png";

function EditCourse() {
    return (
        <>
            <base href="./" />
            <meta charSet="utf-8" />
            <meta httpEquiv="X-UA-Compatible" content="IE=edge" />
            <div className="flex flex-col h-screen">
                <Header />
                {/* Content Start */}

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
                                        <img src={vid_icon} alt="logo" className="w-5 h-5" />
                                        <p className="ms-3">A Video</p>
                                    </a>
                                </li>
                                <li>
                                    <a className="flex items-center p-1 text-yellow-900 rounded-lg group">
                                        <img src={read_icon} alt="logo" className="w-5 h-5" />
                                        <p className="ms-3">A Read</p>
                                    </a>
                                </li>
                                <li>
                                    <a className="flex items-center p-1 text-yellow-900 rounded-lg group">
                                        <img src={quiz_icon} alt="logo" className="w-5 h-5" />
                                        <p className="ms-3">A Test</p>
                                    </a>
                                </li>
                            </ul>
                            <button
                                type="button"
                                className="text-black border-dashed border-orange-400 hover:bg-orange-400 hover:text-white hover:border-white hover:fill-white border-2 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium rounded w-10/12 h-10 py-1 text-center ml-8"

                            >
                                <span>
                                <span className="align-middle inline-block">  
                                <svg xmlns="http://www.w3.org/2000/svg" x="0px" y="0px" width="24" height="24" viewBox="0 0 24 24">
                                    <path fill-rule="evenodd" d="M 11 2 L 11 11 L 2 11 L 2 13 L 11 13 L 11 22 L 13 22 L 13 13 L 22 13 L 22 11 L 13 11 L 13 2 Z"></path>
                                </svg></span>
                                <span className=" ml-1 align-middle inline-block">Add New Lesson</span>
                                </span>
                            </button>
                        </div>
                    </aside>
                    <main className="w-3/4 overflow-y-auto">
                        <div className="mt-16 ml-9">
                            <p className="text-5xl">AS VIDEO</p>
                            <br />
                            <iframe width="420" height="315"
                                src="https://www.youtube.com/embed/Q_YwajWURu8">
                            </iframe>
                            <br />

                            <p className="text-5xl">AS TEXT</p>
                            <div className="mt-5 ml-11">
                                b
                            </div>
                            <br />

                            <p className="text-5xl">AS TEST</p>
                            <br />

                        </div>
                    </main>
                </div>
                {/* Content End */}
            </div>
        </>
    );
};

export default EditCourse;