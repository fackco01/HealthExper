import React from "react";
import {
  useNavigate
} from "react-router-dom";
import Header from "../../components/Header_admin";

function ManageCenter() {

  const navigate = useNavigate();

  const navigateToManageCourse = () => {
    navigate('/adminCourseHome');
  };

  const navigateToManageUser = () => {
    navigate('/manageUser');
  };

  const navigateToManageCenter = () => {
    navigate('/manageCenter');
  };

  const navigateToManagePost = () => {
    navigate('/managePost');
  };

    return (
      <>
      
      <base href="./" />
      <meta charSet="utf-8" />
      <meta httpEquiv="X-UA-Compatible" content="IE=edge" />
      <title>Admin Course</title>
      {/* Main styles for this application*/}
      {/* idk */}
      <style
        dangerouslySetInnerHTML={{
          __html:
            "\n    table {\n      width: 100%;\n    }\n\n    table,\n    th,\n    td {\n      border: 1px solid black;\n    }\n\n    "
        }}
      />
      {/* SIDEBAR */}
      <aside
        id="logo-sidebar"
        className="fixed flex flex-col min-h-screen top-0 left-0 z-40 w-64 h-screen transition-transform -translate-x-full sm:translate-x-0"
        aria-label="Sidebar"
      >    <div className="h-full overflow-y-auto bg-amber-500">
      <ul className="space-y-2 font-medium">
        <li>
          <a
            className="flex items-center p-7 text-yellow-900 group bg-yellow-600"
          ></a>
        </li>
        <li>
          <a
            className="flex items-center p-2 text-yellow-900 rounded-lg group"
          >
            <svg
              className="w-5 h-5"
              aria-hidden="true"
              fill="currentColor"
              viewBox="0 0 22 21"
            ></svg>
            <span className="ms-3">Dashboard</span>
          </a>
        </li>
        <h2 className="px-3 py-4 text-yellow-900">MANAGE</h2>
        <li>
          <a
            onClick = {navigateToManageUser}
            className="flex items-center p-2 text-yellow-900 rounded-lg group hover:bg-yellow-200"
          >
            <svg
              className="w-5 h-5"
              aria-hidden="true"
              fill="currentColor"
              viewBox="0 0 22 21"
            ></svg>
            <span className="ms-3">MANAGE LEARNER</span>
          </a>
        </li>
        <li>
          <a
            onClick = {navigateToManageCourse}
            className="flex items-center p-2 text-yellow-900 rounded-lg group hover:bg-yellow-200"
          >
            <svg
              className="w-5 h-5"
              aria-hidden="true"
              fill="currentColor"
              viewBox="0 0 22 21"
            ></svg>
            <span className="ms-3">MANAGE COURSE</span>
          </a>
        </li>
        <li>
          <a
            onClick = {navigateToManageCenter}
            className="flex items-center p-2 text-yellow-900 rounded-lg group hover:bg-yellow-200"
          >
            <svg
              className="w-5 h-5"
              aria-hidden="true"
              fill="currentColor"
              viewBox="0 0 22 21"
            ></svg>
            <span className="ms-3">MANAGE CENTER</span>
          </a>
        </li>
        <li>
          <a
            onClick = {navigateToManagePost}
            className="flex items-center p-2 text-yellow-900 rounded-lg group hover:bg-yellow-200"
          >
            <svg
              className="w-5 h-5"
              aria-hidden="true"
              fill="currentColor"
              viewBox="0 0 22 21"
            ></svg>
            <span className="ms-3">MANAGE POST</span>
          </a>
        </li>
      </ul>
      <footer className="fixed inset-x-0 bottom-0 items-center p-8 text-yellow-900 group bg-yellow-600"></footer>
    </div>
      </aside>
      <div className="flex flex-col h-screen p-4 sm:ml-64">
        {/* HEADER */}
        <Header />
        <hr />
        <br />
        {/* Breadcrumb */}
        ADMIN MANAGE USER
        <hr />
        <br />
        {/* Search Bar */}
        <div className="flex">
          <input
            type="search"
            className="relative w-screen border border-solid border-neutral-300 px-3 py-[0.25rem] "
            placeholder="Search..."
          />
          <span
            className="input-group-text flex items-center whitespace-nowrap rounded px-3 py-1.5 text-center text-base font-normal text-neutral-700 dark:text-neutral-200"
            id="basic-addon2"
          >
            <svg
              xmlns="http://www.w3.org/2000/svg"
              viewBox="0 0 20 20"
              fill="currentColor"
              className="h-5 w-5"
            >
              <path
                fillRule="evenodd"
                d="M9 3.5a5.5 5.5 0 100 11 5.5 5.5 0 000-11zM2 9a7 7 0 1112.452 4.391l3.328 3.329a.75.75 0 11-1.06 1.06l-3.329-3.328A7 7 0 012 9z"
                clipRule="evenodd"
              />
            </svg>
          </span>
        </div>
        <br />

        <button
                  type="button"
                  className="text-black bg-white hover:bg-orange-300 border-2 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium w-36 py-1 text-center"
                  id="showButton"
        >
          Show Data
        </button>
        <br />
        
        {/* Manage Table */}
        <table className="text-left">
          <thead>
            <tr>
              <td>Username</td>
              <td>Password</td>
              <td>Email</td>
              <td>Phone</td>
              <td>Full Name</td>
              <td>Gender</td>
              <td>Birthday</td>
              <td style={{ width: "6%" }} />
            </tr>
          </thead>
          {/* Backend stuff ? */}
          <tbody>
            <tr>
              <th>1</th>
              <th>1</th>
              <th>1</th>
              <th>1</th>
              <th>1</th>
              <th>1</th>
              <th>ACTIVE</th>
              <th>
                <button
                  type="button"
                  className="text-black bg-white hover:bg-orange-800 border-2 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium w-14 py-1 text-center"
                  onclick="delete()"
                >
                  Delete
                </button>
              </th>
            </tr>
            <tr>
              <th>Company ID</th>
              <th>User ID</th>
              <th>Company Name</th>
              <th>Address</th>
              <th>Date Created</th>
              <th>Email</th>
              <th>Status</th>
              <th>
                <button
                  type="button"
                  className="text-black bg-white hover:bg-orange-800 border-2 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium w-14 py-1 text-center"
                  onclick="delete()"
                >
                  Delete
                </button>
              </th>
            </tr>
          </tbody>
        </table>
        {/* Popup / Delete */}
        <div
          className="hidden fixed top-0 right-0 left-0 z-50 h-screen justify-center items-center w-full md:inset-0 h-[calc(100%-1rem)] max-h-full bg-gray-700/50"
          id="deleteForm"
        >
          <div className="relative p-4 max-w-md flex h-screen inset-0 m-auto max-h-full items-center justify-center">
            <div className="m-auto">
              <div className="relative bg-white rounded-lg shadow">
                <div className="p-4 text-center">
                  {/* What's inside the box start here */}
                  <h1 className="text-lg mb-3">
                    <b>Delete</b>
                  </h1>
                  <p>Are you sure you want to delete this?</p>
                  <br />
                  <div className="flex">
                    <button
                      type="button"
                      className="text-white bg-red-600 hover:bg-red-800 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium rounded-lg items-center px-5 py-2.5 text-center me-2"
                      onclick="closeDelete()"
                    >
                      Delete
                    </button>
                    <button
                      type="button"
                      className="text-gray-500 bg-white hover:bg-gray-100 focus:ring-4 focus:outline-none focus:ring-gray-200 font-medium rounded-lg border border-gray-200 text-sm px-5 py-2.5 hover:text-yellow-900 focus:z-10"
                      onclick="closeDelete()"
                    >
                      Cancel
                    </button>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        {/* FOOTER */}
        <div className="mt-auto">
          <hr />
          <br />
          <footer className="bg-white">
            <div>HealtExpert © 2024</div>
          </footer>
        </div>
      </div>
    </>

    );
};

export default ManageCenter;