using CoffeeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Data.Common;

namespace CoffeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly CoffeeContext _context;
        public ReportsController(CoffeeContext context)
        {
            _context = context;
        }


        // GET: api/OrderLines/report/topserver

        [HttpGet]
        [Route("topserver")]
        public IActionResult GetTopServers(DateTime? begintijd = null, DateTime? eindtijd = null)
        {
            List<object> topServer = new List<object>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                string sqlCommand = getTopServer(begintijd, eindtijd);
                command.CommandText = sqlCommand;
                // command.CommandType = System.Data.CommandType.StoredProcedure;
                _context.Database.OpenConnection();
                DbDataReader row = command.ExecuteReader();

                while (row.Read())
                {
                    int aantal = Int32.Parse(row[0].ToString());
                    string server = row[1].ToString();
                    topServer.Add(new { Aantal = aantal, Server = server });

                }
                row.Close();

            }
            return Ok(topServer);
        }
        public string getTopServer(DateTime? begintijd = null, DateTime? eindtijd = null)
        {
            string whereClause = "";
            if (begintijd != null && eindtijd == null)
            {
                whereClause = "WHERE O.OrderTime > '" + begintijd + "' ";
            }
            if (eindtijd != null && begintijd == null)
            {
                whereClause = "WHERE O.OrderTime < '" + eindtijd + "' ";
            }
            if (begintijd != null && eindtijd != null)
            {
                whereClause = "WHERE O.OrderTime > '" + begintijd + "' AND O.OrderTime < '" + eindtijd + "' ";
            }
            string sqlCommand = "SELECT TOP 10 COUNT(OrderLineId) As Aantal, (S.Firstname + ' ' + S.LastName) " +
                                "As Server FROM OrderLines O INNER JOIN Users S ON S.UserId = O.ServerUserId " + whereClause +
                                "GROUP BY S.FirstName, S.LastName";
            return sqlCommand;
        }
    }
}