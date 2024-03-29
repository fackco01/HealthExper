﻿using BussinessObject.Model.ModelCourse;
using DataAccess.DAO;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CourseRepository : ICourseRepository
    {
        public void AddCourse(Course course)
        {
            CourseDAO.AddCourse(course);
        }

        public void DeleteCourse(string courseId)
        {
            CourseDAO.DeleteCourse(courseId);
        }

        public List<Course> GetCourses()
        {
            return CourseDAO.GetCourses();
        }

        public Course GetCourseById(string courseId)
        {
            return CourseDAO.GetCourseById(courseId);
        }

        public void AddCourseManagerByEmail(string email, string courseId)
        {
            CourseDAO.AddCourseManagerByEmail(email, courseId);
        }

        public void UpdateCourse(Course updateCourse)
        {
            Course existingCourse = CourseDAO.GetCourseById(updateCourse.courseId);
            if(existingCourse != null)
            {
                existingCourse.courseId = updateCourse.courseId;
                existingCourse.courseName = updateCourse.courseName;
                existingCourse.price = updateCourse.price;
                existingCourse.rating = updateCourse.rating;
                existingCourse.description = updateCourse.description;
                existingCourse.studentNumber = updateCourse.studentNumber;
                existingCourse.certificate = updateCourse.certificate;
                existingCourse.createBy = updateCourse.createBy;
                existingCourse.dateUpdate = updateCourse.dateUpdate;
                existingCourse.language = updateCourse.language;
                existingCourse.bmiMin = updateCourse.bmiMin;
                existingCourse.bmiMax = updateCourse.bmiMax;
                existingCourse.typeId = updateCourse.typeId;

                CourseDAO.UpdateCourse(existingCourse);
            }
            else
            {
                throw new Exception("Course not found");
            }
        }
    }
}
