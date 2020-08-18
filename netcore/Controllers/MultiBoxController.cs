using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using CheckBox_DropDownList_MVC.Models;
namespace CheckBox_DropDownList_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            FruitModel fruit = new FruitModel();
            fruit.Fruits = PopulateFruits();
            return View(fruit);
        }

        [HttpPost]
        public ActionResult Index(FruitModel fruit)
        {
            fruit.Fruits = PopulateFruits();
            if (fruit.FruitIds != null)
            {
                List<SelectListItem> selectedItems = fruit.Fruits.Where(p => fruit.FruitIds.Contains(int.Parse(p.Value))).ToList();

                ViewBag.Message = "Selected Fruits:";
                foreach (var selectedItem in selectedItems)
                {
                    selectedItem.Selected = true;
                    ViewBag.Message += "\\n" + selectedItem.Text;
                }
            }

            return View(fruit);
        }

        private static List<SelectListItem> PopulateFruits()
        {
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Organic", Value = "1" });
            items.Add(new SelectListItem { Text = "Natural", Value = "2" });
            items.Add(new SelectListItem { Text = "Colored", Value = "3" });
            return items;
        

        //string constr = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        string query = " SELECT FruitName, FruitId FROM Fruits";
        //        using (SqlCommand cmd = new SqlCommand(query))
        //        {
        //            cmd.Connection = con;
        //            con.Open();
        //            using (SqlDataReader sdr = cmd.ExecuteReader())
        //            {
        //                while (sdr.Read())
        //                {
        //                    items.Add(new SelectListItem
        //                    {
        //                        Text = sdr["FruitName"].ToString(),
        //                        Value = sdr["FruitId"].ToString()
        //                    });
        //                }
        //            }
        //            con.Close();
        //        }
        //    }


        }
    }
}