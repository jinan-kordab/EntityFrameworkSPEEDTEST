using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkSPEEDTEST.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        public ActionResult startStandardLINQ()
        {
            using (var db = new EntityFramework.AdventureWorks2012Entities())
        {
                db.Database.Connection.Open();
                var c = (from rr in db.RANDOMDATA
                         select new Models.RandomData()
                         {
                                COLUMN1 = rr.COLUMN1,
                                COLUMN2= rr.COLUMN2,
                                COLUMN3 = rr.COLUMN3,
                                COLUMN4 = rr.COLUMN4,
                                COLUMN5 = rr.COLUMN5,
                                COLUMN6 = rr.COLUMN6,
                                COLUMN7 = rr.COLUMN7,
                                COLUMN8 = rr.COLUMN8,
                                COLUMN9 = rr.COLUMN9,
                                COLUMN10 = rr.COLUMN10,
                                COLUMN11 = rr.COLUMN11,
                                COLUMN12 = rr.COLUMN12,
                                COLUMN13 = rr.COLUMN13,
                                COLUMNN14 = rr.COLUMNN14,
                                COLUMNO15 = rr.COLUMNO15,
                                COLUMNO16 = rr.COLUMNO16,
                                COLUMNO17 = rr.COLUMNO17,
                                COLUMNO18 = rr.COLUMNO18,
                                COLUMNO19 = rr.COLUMNO19,
                                COLUMN20 = rr.COLUMN20,
                                COLUMN21 = rr.COLUMN21,
                                COLUMN22 = rr.COLUMN22,
                                COLUMN23 = rr.COLUMN23,
                                COLUMN24 = rr.COLUMN24,
                                COLUMN25 = rr.COLUMN25,
                                COLUMN26 = rr.COLUMN26,
                                COLUMN27 = rr.COLUMN27,
                                COLUMN28 = rr.COLUMN28,
                                COLUMN29 = rr.COLUMN29,
                                COLUMN30 = rr.COLUMN30,
                                COLUMN31 = rr.COLUMN31,
                                COLUMN32 = rr.COLUMN32,
                                COLUMN33 = rr.COLUMN33,
                                COLUMN34 = rr.COLUMN34,
                                COLUMN35 = rr.COLUMN35,
                                COLUMN36 = rr.COLUMN36,
                                COLUMN37 = rr.COLUMN37,
                                COLUMN38 = rr.COLUMN38,
                                COLUMN39 = rr.COLUMN39
                         }
                                     ).ToList();
                db.Database.Connection.Close();
            }

            return View("Index");
        }

        public ActionResult startCompiledQuery()
        {
            
            var DBMLQuery = System.Data.Linq.CompiledQuery.Compile((DBML.DBML.DataClasses1DataContext datacontext) => (from s in datacontext.RANDOMDATAs select s));
            using (DBML.DBML.DataClasses1DataContext dbContext = new DBML.DBML.DataClasses1DataContext())
            {
                dbContext.Connection.Open();
                //IQueryable<DBML.RANDOMDATA> cbwebresults = DBMLQuery(dbContext);
                var cbwebresults = DBMLQuery(dbContext).ToList();
                dbContext.Connection.Close();
            }

            return View("Index");
        }

        public ActionResult startADODOTNETQuery()
        {
            string connectionstring = "Data Source=(localdb)\\LocalInstance;Initial Catalog=AdventureWorks2012;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            string QUERY = "SELECT * FROM RANDOMDATA";

            System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(QUERY, connectionstring);
            DataSet SpoolClients = new DataSet();
            adapter.Fill(SpoolClients, "RANDOMDATA");
            return View("Index");
        }

    }
}