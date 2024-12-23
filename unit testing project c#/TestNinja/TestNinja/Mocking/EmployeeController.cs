using System.Data.Entity;

namespace TestNinja.Mocking
{
    public class EmployeeController
    {
        private IEmployeeStorage _storage;
        private readonly IRedirectTo _redirect;

        public EmployeeController(IEmployeeStorage storage,IRedirectTo redirect=null)
        {
            _storage = storage;
            _redirect = redirect?? new RedirectTo();
        }

        public ActionResult DeleteEmployee(int id)
        {
           _storage.DeleteEmployee(id);
            return _redirect.RedirectToAction("Employees");
        }

       
    }

    public class ActionResult { }
 
    public class RedirectResult : ActionResult { }
    
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public void SaveChanges()
        {
        }
    }

    public class Employee
    {
    }
}