using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentApp.Repository;
using StudentApp.Tests.Mock;
using StudentApp.Services;

namespace StudentApp.Tests.Services
{
    [TestClass]
    public class StudentServiceTest
    {
	    IUnitOfWork _uow;
	    StudentService _studentService;

	    [TestInitialize]
	    public void SetUp()
	    {
		    _uow = new MockUnitOfWork<MockDataContext>();
		    _studentService = new StudentService(_uow);
	    }

	    [TestCleanup]
	    public void TearDown()
	    {
		    // Clean resources
	    }

	    [TestMethod]
	    public void TestGetStudentJohnDoe()
	    {
		    var student = _studentService.GetStudentByID(1);
		    Assert.AreEqual(student.name, "John Doe");
	    }
	
	    [TestMethod]
	    public void TestDeleteStudentJohnDoe()
	    {
		    try
		    {
			    _studentService.DeleteStudentByID(1);
		    }
		    catch(Exception ex)
		    {
			    Assert.Fail("Expected no exception, but got: " + ex.Message);
		    }
	    }
    }
}