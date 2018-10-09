using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web.Configuration;
using System.Data.SqlClient; 
using System.Data;

namespace KoffieAPI.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        SqlConnection con = new SqlConnection(
        WebConfigurationManager.ConnectionStrings["connKoffieData"].ConnectionString);

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
           
            String queryString = "SELECT * FROM tblTest";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, con);  
            DataSet test = new DataSet();  
            adapter.Fill(test, "Test");  
            
            return new string[] { test.Tables("Test").Rows(0).Item("test"),  test.Tables("Test").Rows(0).Item("test2") };
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
