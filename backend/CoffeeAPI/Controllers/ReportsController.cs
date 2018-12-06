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
using System.Data;

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
                string sqlCommand = getTopServer();
                command.CommandText = sqlCommand;
                DbParameter paramBeginTijd = command.CreateParameter();
                paramBeginTijd.ParameterName = "@begintijd";
                paramBeginTijd.DbType = DbType.DateTime;
                paramBeginTijd.Value = (object)begintijd ?? DBNull.Value;

                DbParameter paramEindTijd = command.CreateParameter();
                paramEindTijd.ParameterName = "@eindtijd";
                paramEindTijd.DbType = DbType.DateTime;
                paramEindTijd.Value = (object)eindtijd ?? DBNull.Value;
                    
                // command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(paramBeginTijd);
                command.Parameters.Add(paramEindTijd);
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
        public string getTopServer()
        {
            string sqlCommand = "SELECT TOP 10 COUNT(OrderLineId) As Aantal, (S.Firstname + ' ' + S.LastName) " +
                                "As Server FROM OrderLines O INNER JOIN Users S ON S.UserId = O.ServerUserId " +
                                "WHERE (O.OrderTime > @begintijd OR @begintijd IS NULL)" +
                                "AND (O.OrderTime < @eindtijd OR @eindtijd IS NULL)" +
                                "GROUP BY S.FirstName, S.LastName";
            return sqlCommand;
        }
    }
}