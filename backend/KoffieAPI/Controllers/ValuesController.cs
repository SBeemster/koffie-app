using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient; 
using System.Data;

namespace KoffieAPI.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly string connectionString = "Server=tcp:koffiedata.database.windows.net,1433;Initial Catalog=koffiedata;Persist Security Info=False;User ID=KoffieWeb;Password=K0Ff13W3b!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; 
        private SqlConnection sqlConnection;

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {

                String queryString = "SELECT * FROM tblTest";
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, sqlConnection);
                DataSet test = new DataSet();
                adapter.Fill(test, "Test");

                return new string[] { test.Tables["Test"].Rows[0]["test"].ToString(), test.Tables["Test"].Rows[0]["test2"].ToString() };
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
