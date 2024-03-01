import logo from './logo.svg';
import './App.css';
import {
  BrowserRouter as Router,
  Routes,
  Route
} from "react-router-dom";

import CreateCourse from './page/Course_Admin/create_course';
import AdminCourseHome from './page//Course_Admin/course_admin_manage';
import SignUp from './page/Guest/sign_up';
import ManageUser from './page/Admin/manage_user';
import ManageCenter from './page/Admin/manage_center';
import ManagePost from './page/Admin/manage_post';

/* IMPORT END */

function Root() {
  return(
    <>
        <Routes>
          <Route path = "/" element = {<AdminCourseHome/>}/>
          <Route path = "/signUp" element = {<SignUp/>}/>

          <Route path = "/createCourse" element = {<CreateCourse/>}/>
          <Route path = "/adminCourseHome" element = {<AdminCourseHome/>}/>

          <Route path = "/manageUser" element = {<ManageUser/>}/>
          <Route path = "/manageCenter" element = {<ManageCenter/>}/>
          <Route path = "/managePost" element = {<ManagePost/>}/>
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
