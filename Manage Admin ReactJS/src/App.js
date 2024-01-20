import logo from './logo.svg';
import './App.css';
import './custom.css';
import {openDelete} from './manage.js';
import deletei from './sprite/delete.png';
import editi from './sprite/edit.png';

function App() {
  return (<>
    <base href="./" />
    <meta charSet="utf-8" />
    <meta httpEquiv="X-UA-Compatible" content="IE=edge" />
    <script src="./manage.js"></script>
    <title>Admin - Manage</title>
    {/* Main styles for this application*/}
    {/* SIDEBAR */}
    <aside
      id="logo-sidebar"
      className="fixed flex flex-col min-h-screen top-0 left-0 z-40 w-64 h-screen transition-transform -translate-x-full sm:translate-x-0"
      aria-label="Sidebar"
    >
      <div className="h-full overflow-y-auto bg-amber-500">
        <ul className="space-y-2 font-medium">
          <li>
            <a
              href="#"
              className="flex items-center p-7 text-yellow-900 group bg-yellow-600"
            ></a>
          </li>
          <li>
            <a
              href="#"
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
              href="admin_customer.html"
              className="flex items-center p-2 text-yellow-900 rounded-lg group"
            >
              <svg
                className="w-5 h-5"
                aria-hidden="true"
                fill="currentColor"
                viewBox="0 0 22 21"
              ></svg>
              <span className="ms-3">Customer</span>
            </a>
          </li>
          <li>
            <a
              href="#"
              className="flex items-center p-2 text-yellow-900 rounded-lg group"
            >
              <svg
                className="w-5 h-5"
                aria-hidden="true"
                fill="currentColor"
                viewBox="0 0 22 21"
              ></svg>
              <span className="ms-3">Company</span>
            </a>
          </li>
          <li>
            <a
              href="#"
              className="flex items-center p-2 text-yellow-900 rounded-lg group"
            >
              <svg
                className="w-5 h-5"
                aria-hidden="true"
                fill="currentColor"
                viewBox="0 0 22 21"
              ></svg>
              <span className="ms-3">Post</span>
            </a>
          </li>
          <li>
            <a href="#" className="flex items-center p-2 text-yellow-900 group">
              <svg
                className="w-5 h-5"
                aria-hidden="true"
                fill="currentColor"
                viewBox="0 0 22 21"
              ></svg>
              <span className="ms-3">Category</span>
            </a>
          </li>
        </ul>
        <footer className="fixed inset-x-0 bottom-0 items-center p-8 text-yellow-900 group bg-yellow-600"></footer>
      </div>
    </aside>
    <div className="flex flex-col h-screen p-4 sm:ml-64">
      {/* HEADER */}
      <header className="ml-5 h-10 header text-neutral-500">
        <nav className="flex justify-start gap-x-5">
          <a className="nav-link" href="#">
            Dashboard
          </a>
          <a className="nav-link" href="#">
            Users
          </a>
          <a className="nav-link" href="#">
            Settings
          </a>
        </nav>
      </header>
      <hr />
      <br />
      {/* Breadcrumb */}
      <nav className="ml-5 h-10 w-full rounded-md">
        <ol className="list-reset flex">
          <li>
            <a
              href="#"
              className="text-primary transition duration-150 ease-in-out text-blue-600 underline hover:text-primary-600 focus:text-primary-600 active:text-primary-700"
            >
              Manage
            </a>
          </li>
          <li>
            <span className="mx-2 text-neutral-500">/</span>
          </li>
          <li className="text-neutral-500">Company</li>
        </ol>
      </nav>
      <hr />
      {/* MAIN CONTENT */}
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
      {/* Manage Table */}
      <table className="text-left">
        <thead>
          <tr>
            <td style={{ width: "10%" }}>Company ID</td>
            <td style={{ width: "7%" }}>User ID</td>
            <td style={{ width: "15%" }}>Company Name</td>
            <td style={{ width: "20%" }}>Address</td>
            <td style={{ width: "10%" }}>Date Created</td>
            <td style={{ width: "25%" }}>Email</td>
            <td style={{ width: "7%" }}>Status</td>
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
              <div className="flex">
                <a onclick="openEdit()">
                  <img src={editi}/>
                </a>
                <a onclick="openDelete()">
                  <img src={deletei}/>
                </a>
              </div>
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
              <div className="flex">
                <a onclick="openEdit()">
                  <img src={editi}/>
                </a>
                <a onclick="openDelete()">
                  <img src={deletei}/>
                </a>
              </div>
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
      {/* Popup / Edit */}
      <div
        className="hidden fixed top-0 right-0 left-0 z-50 h-screen justify-center items-center w-full md:inset-0 h-[calc(100%-1rem)] max-h-full bg-gray-700/50"
        id="editForm"
      >
        <div className="relative p-4 max-w-md flex h-screen inset-0 m-auto max-h-full items-center justify-center">
          <div className="m-auto">
            <div className="relative bg-white rounded-lg shadow">
              <div className="p-4 text-center">
                <h1 className="text-lg mb-3">
                  <b>Edit</b>
                </h1>
                <div className="w-full max-w-96">
                  <div className="md:flex">
                    <div className="md:w-1/3">
                      <label htmlFor="fname" className="text-left">
                        Company ID:
                      </label>
                    </div>
                    <div className="md:w-2/3">
                      <input
                        type="text"
                        className="border-2"
                        id="cid"
                        name="cid"
                      />
                      <br />
                      <br />
                    </div>
                  </div>
                  <div className="md:flex">
                    <div className="md:w-1/3">
                      <label htmlFor="lname" className="text-left">
                        User ID:
                      </label>
                    </div>
                    <div className="md:w-2/3">
                      <input
                        type="text"
                        className="border-2"
                        id="uid"
                        name="uid"
                      />
                      <br />
                      <br />
                    </div>
                  </div>
                  <div className="md:flex">
                    <div className="md:w-1/3">
                      <label htmlFor="cnamel" className="text-left">
                        Company Name:
                      </label>
                    </div>
                    <div className="md:w-2/3">
                      <input
                        type="text"
                        className="border-2"
                        id="cname"
                        name="cname"
                      />
                      <br />
                      <br />
                    </div>
                  </div>
                  <div className="md:flex">
                    <div className="md:w-1/3">
                      <label htmlFor="addl" className="text-left">
                        Address:
                      </label>
                    </div>
                    <div className="md:w-2/3">
                      <input
                        type="text"
                        className="border-2"
                        id="address"
                        name="address"
                      />
                      <br />
                      <br />
                    </div>
                  </div>
                  <div className="md:flex">
                    <div className="md:w-1/3">
                      <label htmlFor="datel" className="text-left">
                        Date Created:
                      </label>
                    </div>
                    <div className="md:w-2/3">
                      <input
                        type="text"
                        className="border-2"
                        id="date"
                        name="date"
                      />
                      <br />
                      <br />
                    </div>
                  </div>
                  <div className="md:flex">
                    <div className="md:w-1/3">
                      <label htmlFor="maill" className="text-left">
                        Email:
                      </label>
                    </div>
                    <div className="md:w-2/3">
                      <input
                        type="text"
                        className="border-2"
                        id="email"
                        name="email"
                      />
                      <br />
                      <br />
                    </div>
                  </div>
                </div>
                <div className="flex">
                  <button
                    type="button"
                    className="text-white bg-amber-500 hover:bg-amber-800 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium rounded-lg items-center px-5 py-2.5 text-center me-2"
                    onclick="closeEdit()"
                  >
                    Edit
                  </button>
                  <button
                    type="button"
                    className="text-gray-500 bg-white hover:bg-gray-100 focus:ring-4 focus:outline-none focus:ring-gray-200 font-medium rounded-lg border border-gray-200 text-sm px-5 py-2.5 hover:text-yellow-900 focus:z-10"
                    onclick="closeEdit()"
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
}

export default App;