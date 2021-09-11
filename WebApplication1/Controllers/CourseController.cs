using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class CourseController:Controller
    {
        private readonly Courseservice _Courseservice;
        private readonly IConfiguration _configuration;

        public CourseController(Courseservice courser, IConfiguration config)
        {
            _Courseservice = courser;
            _configuration = config;

        }

        public IActionResult Index()
        {
            IEnumerable<Course> _course_list = _Courseservice.GetCourses();
            return View(_course_list);
        }

    }
}
