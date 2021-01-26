using CleanArch.Application.ViewModels;
using CleanArch.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();

        Course GetCourseById(int courseId);
    }
}
