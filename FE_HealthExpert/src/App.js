import logo from './logo.svg';
import './App.css';
import {
  BrowserRouter as Router,
  Routes,
  Route,
  useNavigate
} from "react-router-dom";

import CreateCourse from './Course_Admin/create_course';
import AdminCourseHome from './Course_Admin/course_admin_manage';
import SignUp from './Guest/sign_up';
import ManageUser from './Admin/manage_user';

/* IMPORT END */

function Root() {
  return(
    <>
        <Routes>
          <Route
          path = "/"
          element = {<AdminCourseHome/>}
          />
          
          <Route
          path = "/createCourse"
          element = {<CreateCourse/>}
          />

          <Route
          path = "/adminCourseHome"
          element = {<AdminCourseHome/>}
          />

          <Route 
          path = "/signUp"
          element = {<SignUp/>}
          />

          <Route 
          path = "/manageUser"
          element = {<ManageUser/>}
          />
        </Routes>
    </>
  )
}

function App() {
  return (
    <Router>
      <Root />
    </Router>
  );
}

export default App;
