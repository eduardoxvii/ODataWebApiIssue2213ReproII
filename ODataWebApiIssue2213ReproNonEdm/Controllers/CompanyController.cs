using ODataWebApiIssue2213ReproNonEdm.Data;
using ODataWebApiIssue2213ReproNonEdm.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Educacao;

namespace ODataWebApiIssue2213ReproNonEdm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private InMemoryDbContext _db;

        public CompanyController(InMemoryDbContext db)
        {
            _db = db;
        }

        [EnableQuery]
        public IQueryable<Company> Get()
        {
            return _db.Companies;
        }
    }
}
