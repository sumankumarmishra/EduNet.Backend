﻿using EduNet.Backend.Domain.Entities.Branches;
using EduNet.Backend.Domain.Entities.Students;
using EduNet.Backend.Domain.Entities.Teachers;
using EduNet.Backend.Service.DTOs.Courses.Lessons;
using EduNet.Backend.Service.DTOs.Students.Attendances;
using EduNet.Backend.Service.DTOs.Students.Enrollments;
using EduNet.Backend.Service.DTOs.Teachers.TeacherCourses;

namespace EduNet.Backend.Service.DTOs.Courses.Courses;

public class CourseForResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string StartTime { get; set; }
    public string DurationTime { get; set; }
    public long BranchId { get; set; }
    public Branch Branch { get; set; }
    public short Duration { get; set; }
    public ICollection<LessonForResultDto> Lessons { get; set; }
    public ICollection<EnrollmentForResultDto> Students { get; set; }
    public ICollection<AttendanceForResultDto> Attendances { get; set; }
    public ICollection<TeacherCourseForResultDto> Teachers { get; set; }
}
