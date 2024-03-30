import './App.css';
import {
  BrowserRouter as Router,
  Routes,
  Route
} from "react-router-dom";

import SignUp from './page/Guest/sign_up';
import YourProfile from './page/User/profile';
import RegisteredCourse from './page/User/registered_course';
import ManagedCourseList from './page/Course_Manager/managed_course';
import EditCourse from './page/Course_Manager/edit_course';
import CourseDetails from './page/User/course_details';
import Lesson from './page/User/lesson';
import CreateCourse from './page/Course_Admin/create_course';
import ManageCourse from './page/Admin/manage_course';
import EditProfile from './page/User/edit_profile';
import ManageUser from './page/Admin/manage_user';
import ManageCenter from './page/Admin/manage_center';
import ManagePost from './page/Admin/manage_post';
import PaymentProcess from './page/User/payment_process';
import PaymentComplete from './page/User/payment_complete';

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
          <Route path = "/paymentProcess" element = {<PaymentProcess/>}/>
          <Route path = "/paymentComplete" element = {<PaymentComplete/>}/>

          <Route path = "/createCourse" element = {<CreateCourse/>}/>

          <Route path = "/managedCourseList" element = {<ManagedCourseList/>}/>
          <Route path = "/editCourse" element = {<EditCourse/>}/>

          <Route path = "/manageUser" element = {<ManageUser/>}/>
          <Route path = "/manageCenter" element = {<ManageCenter/>}/>
          <Route path = "/managePost" element = {<ManagePost/>}/>
          <Route path = "/manageCourse" element = {<ManageCourse/>}/>
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
