using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp.Tests.Mock
{
    public class MockDataContext
    {
        public List<Student> Student
        {
            get
            {
                return new List<Student>
			{
				new Student
				{
					id = 1,
					name = "John Doe",
				},
				new Student
				{
					id = 2,
					name = "Victor Sagev",
				},
				new Student
				{
					id = 3,
					name = "Wayne Johnson",
				}
			};
            }
        }
    }
}