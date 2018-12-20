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
using Microsoft.AspNetCore.Authorization;

namespace CoffeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize(Roles = "Manager")]
    public class ReportsController : ControllerBase
    {
        private readonly CoffeeContext _context;
        public ReportsController(CoffeeContext context)
        {
            _context = context;
        }


        // GET: api/OrderLines/reports/topserver

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

        [HttpGet]
        [Route("topdrinker")]
        public IActionResult GetTopDrinkers(DateTime? begintijd = null, DateTime? eindtijd = null)
        {
            List<object> topDrinkers = new List<object>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                string sqlCommand = getTopDrinker();
                command.CommandText = sqlCommand;
                DbParameter paramBeginTijd = command.CreateParameter();
                paramBeginTijd.ParameterName = "@begintijd";
                paramBeginTijd.DbType = DbType.DateTime;
                paramBeginTijd.Value = (object)begintijd ?? DBNull.Value;

                DbParameter paramEindTijd = command.CreateParameter();
                paramEindTijd.ParameterName = "@eindtijd";
                paramEindTijd.DbType = DbType.DateTime;
                paramEindTijd.Value = (object)eindtijd ?? DBNull.Value;

                command.Parameters.Add(paramBeginTijd);
                command.Parameters.Add(paramEindTijd);
                _context.Database.OpenConnection();
                DbDataReader row = command.ExecuteReader();

                while (row.Read())
                {
                    int aantal = Int32.Parse(row[0].ToString());
                    string drinkers = row[1].ToString();
                    topDrinkers.Add(new { Aantal = aantal, Drinkers = drinkers });

                }
                row.Close();

            }
            return Ok(topDrinkers);
        }
        // GET: api/OrderLines/reports/timetillserve

        [HttpGet]
        [Route("timetillserve")]
        public IActionResult GetTimeToServe(DateTime? begintijd = null, DateTime? eindtijd = null)
        {
            List<object> timeToServe = new List<object>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                string sqlCommand = getTimeToServe();
                command.CommandText = sqlCommand;
                DbParameter paramBeginTijd = command.CreateParameter();
                paramBeginTijd.ParameterName = "@begintijd";
                paramBeginTijd.DbType = DbType.DateTime;
                paramBeginTijd.Value = (object)begintijd ?? DBNull.Value;

                DbParameter paramEindTijd = command.CreateParameter();
                paramEindTijd.ParameterName = "@eindtijd";
                paramEindTijd.DbType = DbType.DateTime;
                paramEindTijd.Value = (object)eindtijd ?? DBNull.Value;

                command.Parameters.Add(paramBeginTijd);
                command.Parameters.Add(paramEindTijd);
                _context.Database.OpenConnection();
                DbDataReader row = command.ExecuteReader();

                while (row.Read())
                {
                    int minute = Int32.Parse(row[0].ToString());
                    string date = row[1].ToString();
                    timeToServe.Add(new { Minutes = minute, Date = date });

                }
                row.Close();

            }
            return Ok(timeToServe);
        }

        // GET: api/OrderLines/reports/topserver

        [HttpGet]
        [Route("mostdrinked")]
        public IActionResult GetMostDrinked(DateTime? begintijd = null, DateTime? eindtijd = null)
        {
            List<object> mostDrinked = new List<object>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                string sqlCommand = getMostDrinked();
                command.CommandText = sqlCommand;
                DbParameter paramBeginTijd = command.CreateParameter();
                paramBeginTijd.ParameterName = "@begintijd";
                paramBeginTijd.DbType = DbType.DateTime;
                paramBeginTijd.Value = (object)begintijd ?? DBNull.Value;

                DbParameter paramEindTijd = command.CreateParameter();
                paramEindTijd.ParameterName = "@eindtijd";
                paramEindTijd.DbType = DbType.DateTime;
                paramEindTijd.Value = (object)eindtijd ?? DBNull.Value;

                command.Parameters.Add(paramBeginTijd);
                command.Parameters.Add(paramEindTijd);
                _context.Database.OpenConnection();
                DbDataReader row = command.ExecuteReader();

                while (row.Read())
                {
                    int aantal = Int32.Parse(row[0].ToString());
                    string drink = row[1].ToString();
                    mostDrinked.Add(new { Aantal = aantal, Drink = drink });

                }
                row.Close();

            }
            return Ok(mostDrinked);
        }

        private string getTopDrinker()
        {
            string sqlCommand = "SELECT TOP 10 COUNT(OrderLineId) As Aantal, (S.Firstname + ' ' + S.LastName) " +
                                "As Drinkers FROM OrderLines O INNER JOIN Users S ON S.UserId = O.CustomerUserId " +
                                "WHERE (O.OrderTime > @begintijd OR @begintijd IS NULL)" +
                                "AND (O.OrderTime < @eindtijd OR @eindtijd IS NULL)" +
                                "GROUP BY S.FirstName, S.LastName";

            return sqlCommand;
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
        public string getTimeToServe()
        {
            string sqlCommand = "SELECT CONVERT(date, OrderTime) As orderdate, orderlineid, datediff(mi, OrderTime, GetTime) as timespend INTO #date FROM OrderLines O " +
                                "WHERE (O.OrderTime > @begintijd OR @begintijd IS NULL)" +
                                "AND (O.OrderTime < @eindtijd OR @eindtijd IS NULL)" +
                                "AND O.GetTime > O.OrderTime;" +
                                "SELECT count(orderlineid) as aantal, orderdate, sum(timespend) as totaltime INTO #total FROM #date GROUP BY orderdate;" +
                                "SELECT(totaltime / aantal) as averagetime, CONVERT(varchar, orderdate, 5) as orderdate FROM #total ORDER BY orderdate ASC;";
            return sqlCommand;
        }
        public string getMostDrinked()
        {
            string sqlCommand = "SELECT TOP 10 COUNT(OrderLineId) As Aantal," +
                                "D.DrinkName As Drink FROM OrderLines O " +
                                "INNER JOIN Drinks D ON D.DrinkId = O.DrinkId " +
                                "WHERE(O.OrderTime > @begintijd OR @begintijd IS NULL) " +
                                "AND(O.OrderTime < @eindtijd OR @eindtijd IS NULL) " +
                                "GROUP BY D.DrinkName";
            return sqlCommand;
        }
    }
}