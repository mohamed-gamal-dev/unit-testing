using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public interface IRedirectTo
    {
        public ActionResult RedirectToAction(string employees);
    }

    public class RedirectTo : IRedirectTo
    {
        public ActionResult RedirectToAction(string employees)
        {
            return new RedirectResult();
        }
    }
}
