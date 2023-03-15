using MySql.Data.MySqlClient;
using System.Data;
using System.Web.Mvc;

namespace CRUD_project.Models
{
    public class HomController : Controller
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=1998;database=category");
        // GET: Hom

        public ActionResult Index()
        {
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM product_list",conn);

            DataTable dt = new DataTable();
            adp.Fill(dt);
            return View(dt);
        }
    }
}