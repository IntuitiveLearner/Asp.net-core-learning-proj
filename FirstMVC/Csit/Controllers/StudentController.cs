using Microsoft.AspNetCore.Mvc;
namespace Csit.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        // ViwBag.Name = "Sachin Raut";
        // ViewBag.Address = "Itabhatta, Jhapa";
        Student st = new Student();
        st.name = "Sachin Raut";
        st.address= "Itabhatta, Jhapa";
        return View(st);
    }
}

//Where will i see the output of this code?
//You will see the output of this code when you run your ASP.NET Core application and navigate to the route associated with the StudentController. By default, if you have not specified a route, you can access it by going to `http://localhost:5000/Student` (or the appropriate port your application is running on). When you visit that URL, you should see the text "Hello from StudentController!" displayed in your web browser.

// now listening to:  http://localhost:5263
// now where do i see the output of this code?
// You will see the output of this code when you run your ASP.NET Core application and navigate to the route associated with the StudentController. Since your application is now listening on `http://localhost:5263`, you can access the output by going to `http://localhost:5263/Student` in your web browser. When you visit that URL, you should see the text "Hello from StudentController!" displayed in your web browser.