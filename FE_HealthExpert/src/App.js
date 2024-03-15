import './App.css';
import {
  BrowserRouter as Router,
  Routes,
  Route
} from "react-router-dom";

import SignUp from './page/Guest/sign_up';
import YourProfile from './page/User/profile';
import RegisteredCourse from './page/User/registered_course';
import CourseDetails from './page/User/course_details';
import Lesson from './page/User/lesson';
import CreateCourse from './page/Course_Admin/create_course';
import AdminCourseHome from './page/Course_Admin/course_admin_manage';
import EditProfile from './page/User/edit_profile';
import ManageUser from './page/Admin/manage_user';
import ManageCenter from './page/Admin/manage_center';
import ManagePost from './page/Admin/manage_post';

/* IMPORT END */

function Root() {
  return(
    <>
        <Routes>
          <Route path = "/" element = {<YourProfile/>}/>
          <Route path = "/signUp" element = {<SignUp/>}/>
          <Route path = "/yourProfile" element = {<YourProfile/>}/>
          <Route path = "/editProfile" element = {<EditProfile/>}/>
          <Route path = "/registeredCourse" element = {<RegisteredCourse/>}/>
          <Route path = "/courseDetails" element = {<CourseDetails/>}/>
          <Route path = "/lesson" element = {<Lesson/>}/>

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
