import "./App.css";
import { Routes, Route } from "react-router-dom";

import Home from "./page/Home";
import SignIn from "./page/Auth/SignIn";

import { useRoutes } from "react-router-dom";
import { Navigate } from "react-router-dom";
import SignUp from "./page/Auth/SignUp";

export default function App() {
  return (
    <Routes>
      {/* <Route path="/" element={<Layout />}> */}
      <Route path="/home" element={<Home />} />
      <Route path="/signin" element={<SignIn />} />
      <Route path="/signup" element={<SignUp />} />

      {/* <Route path="blogs" element={<Blogs />} />
          <Route path="contact" element={<Contact />} />
        <Route path="*" element={<NoPage />} /> */}
      {/* </Route> */}
    </Routes>
  );
}
