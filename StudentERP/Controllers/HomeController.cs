using StudentERP.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentERP.Controllers
{
    public class HomeController : Controller
    {
        string strcon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

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

        public ActionResult Add_teacher()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add_teacher(FormCollection fcol)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    string pwd = fcol.Get("Password");
                    string fname = fcol.Get("Firstname");
                    string mname = fcol.Get("Middlename");
                    string lname = fcol.Get("Lastname");
                    string bdate = fcol.Get("Birthdate");
                    string mail = fcol.Get("Email");
                    string gen = (fcol.Get("Gender"));
                    bool gender_get = true;

                    if (gen.Equals("male"))
                        gender_get = true;

                    else
                        gender_get = false;

                    string cno = fcol.Get("ContactNo");
                    string address = fcol.Get("Address");


                    string qs = "insertTeacher";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pass", pwd);
                    cmd.Parameters.AddWithValue("fname", fname);
                    cmd.Parameters.AddWithValue("mname", mname);
                    cmd.Parameters.AddWithValue("lname", lname);
                    cmd.Parameters.AddWithValue("birthdate", bdate);
                    cmd.Parameters.AddWithValue("email", mail);
                    cmd.Parameters.AddWithValue("gender", gender_get);
                    cmd.Parameters.AddWithValue("contact_No", cno);
                    cmd.Parameters.AddWithValue("address", address);

                    cmd.ExecuteNonQuery();

                    con.Close();
                }

                catch (Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }

            return View();
        }

        public ActionResult Add_standard()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add_standard(FormCollection fcol)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    string fn = fcol.Get("name");
                    int ln = Convert.ToInt32(fcol.Get("LevelOfStd"));

                    string qs = "insertStandard";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("name", fn);
                    cmd.Parameters.AddWithValue("level", ln);

                    cmd.ExecuteNonQuery();

                    con.Close();
                }

                catch (Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }

            return View();
        }

        public ActionResult Add_division()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add_division(FormCollection fcol)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    string divname = fcol.Get("Name");
                    string qs = "insertDivison";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("div", divname);

                    cmd.ExecuteNonQuery();

                    con.Close();
                }

                catch(Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }

            return View();
        }

        public ActionResult Add_subject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add_subject(FormCollection fcol)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    string sname = fcol.Get("Name");

                    string qs = "insertSubject";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("name", sname);

                    cmd.ExecuteNonQuery();

                    con.Close();
                }

                catch(Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }
            
            return View();
        }

        public ActionResult Add_qualification()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add_qualification(FormCollection fcol)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    string quali = fcol.Get("Name");

                    string qs = "insertQualification";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("name", quali);

                    cmd.ExecuteNonQuery();

                    con.Close();
                }

                catch(Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }
            
            return View();
        }

        public ActionResult Add_occupation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add_occupation(FormCollection fcol)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    string ocu = fcol.Get("name");

                    string qs = "insertOccupation";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("name", ocu);

                    cmd.ExecuteNonQuery();

                    con.Close();
                }

                catch(Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }
            
            return View();
        }

        [HttpGet]
        public ActionResult Add_acadamic_year()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add_acadamic_year(FormCollection fcol)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    string yr = fcol.Get("Year");

                    string qs = "insertAcaYear";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("year", yr);

                    cmd.ExecuteNonQuery();

                    con.Close();
                }

                catch(Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMeesage = ex.Message });
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult Add_year_according_standard()
        {
            fillStandard();
            fillaca_year();
            List<SelectListItem> monthlist = new List<SelectListItem>();
            monthlist.Add(new SelectListItem
            {
                Text = "January",
                Value = "January"
            });
            monthlist.Add(new SelectListItem
            {
                Text = "February",
                Value = "February"
            });

            monthlist.Add(new SelectListItem
            {
                Text = "March",
                Value = "March"
            });

            monthlist.Add(new SelectListItem
            {
                Text = "April",
                Value = "April"
            });

            monthlist.Add(new SelectListItem
            {
                Text = "May",
                Value = "May"
            });

            monthlist.Add(new SelectListItem
            {
                Text = "June",
                Value = "June"
            });

            monthlist.Add(new SelectListItem
            {
                Text = "July",
                Value = "July"
            });

            monthlist.Add(new SelectListItem
            {
                Text = "August",
                Value = "August"
            });

            monthlist.Add(new SelectListItem
            {
                Text = "September",
                Value = "September"
            });

            monthlist.Add(new SelectListItem
            {
                Text = "October",
                Value = "October"
            });

            monthlist.Add(new SelectListItem
            {
                Text = "November",
                Value = "November"
            });
            monthlist.Add(new SelectListItem
            {
                Text = "December",
                Value = "December"
            });
            ViewBag.monthList = monthlist;

            return View();
        }

        [HttpPost]
        public ActionResult Add_year_according_standard(FormCollection fcol)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    var std = fcol["Standard"];
                    var yr = fcol["AcadamicYear"];
                    var sm = fcol["StartMonth"];
                    var em = fcol["EndMonth"];

                    string qs = "insertAcademicYrStd";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("aca", yr);
                    cmd.Parameters.AddWithValue("std", std);
                    cmd.Parameters.AddWithValue("smonth", sm);
                    cmd.Parameters.AddWithValue("emonth", em);

                    cmd.ExecuteNonQuery();

                    con.Close();
                }

                catch(Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Add_subject_teacher()
        {
            fillteacher();
            fillsubject();
            fillStandard();
            filldiv();
            fillaca_year();
            return View();
        }

        [HttpPost]
        public ActionResult Add_subject_teacher(FormCollection fcol)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    int std_ddl = Convert.ToInt32(fcol["Standard"]);
                    int div_ddl = Convert.ToInt32(fcol["Division"]);
                    var sub_ddl = fcol["Subject"];
                    var yr_ddl = fcol["AcadamicYear"];
                    var teacher_ddl = fcol["TeacherName"];
                    int id = fetch_stddiv(std_ddl, div_ddl);

                    string qs = "insertSubjectTeacher";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("stddiv", id);
                    cmd.Parameters.AddWithValue("sub", sub_ddl);
                    cmd.Parameters.AddWithValue("year", yr_ddl);
                    cmd.Parameters.AddWithValue("teacher", teacher_ddl);
                    cmd.ExecuteNonQuery();

                    con.Close();
                }

                catch (Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }

            return RedirectToAction("Index");
        }

        [NonAction]
        public void fillteacher()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    con.Open();
                    List<SelectListItem> teacherlist = new List<SelectListItem>();
                    SqlDataReader sdr = null;
                    SqlCommand cmd = new SqlCommand("select TeacherID,FirstName,LastName from TeacherLogin", con);
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        teacherlist.Add(new SelectListItem { Text = sdr["FirstName"].ToString() + " " + sdr["LastName"].ToString(), Value = sdr["TeacherID"].ToString() });

                    }
                    con.Close();
                    ViewBag.teacher = teacherlist;
                }
                catch(Exception ex)
                {
                    RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }
        }

        [HttpGet]
        public ActionResult Add_class_teacher()
        {
            fillteacher();
            fillStandard();
            filldiv();
            fillaca_year();
            return View();
        }

        [NonAction]
        public int fetch_stddiv(int std, int div)
        {
            int sdid = 0;

            using(SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    con.Open();
                    string query = "select StandardDivisionID from StandardDivisionMaster where StandardID=" + std + "and DivisionID=" + div;

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        sdid = Convert.ToInt32(sdr["StandardDivisionID"]);
                    }
                    con.Close();
                    return sdid;
                }

                catch(Exception ex)
                {
                    RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }

            return sdid;
        }

        [HttpPost]
        public ActionResult Add_class_teacher(FormCollection fcol)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    con.Open();

                    int std_ddl = Convert.ToInt32(fcol["Standard"]);
                    int div_ddl = Convert.ToInt32(fcol["Division"]);
                    var teacher_ddl = fcol["TeacherName"];
                    var yr_ddl = fcol["AcadamicYear"];

                    int id = fetch_stddiv(std_ddl, div_ddl);

                    string qs = "insertClassTeacher";

                    SqlCommand cmd1 = new SqlCommand(qs, con);
                    cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("teacher", teacher_ddl);
                    cmd1.Parameters.AddWithValue("stddiv", id);
                    cmd1.Parameters.AddWithValue("year", yr_ddl);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }

                catch(Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }
            
            return RedirectToAction("Index");
        }

        [NonAction]
        public void fillsubject()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    con.Open();
                    List<SelectListItem> subjectlist = new List<SelectListItem>();
                    SqlDataReader sdr = null;
                    SqlCommand cmd = new SqlCommand("select SubjectID,Name from SubjectMaster", con);
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        subjectlist.Add(new SelectListItem { Text = sdr["Name"].ToString(), Value = sdr["SubjectID"].ToString() });
                    }
                    con.Close();
                    ViewBag.sub = subjectlist;
                }

                catch(Exception ex)
                {
                    RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }
        }

        public ActionResult Add_standard_wise_subject()
        {
            fillsubject();
            fillStandard();
            fillaca_year();
            return View();
        }

        [HttpPost]
        public ActionResult Add_standard_wise_subject(FormCollection fcol)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    var std_ddl = fcol["Standard"];
                    var sub_ddl = fcol["Subject"];
                    var yr_ddl = fcol["Year"];

                    string qs = "insertstdvsub";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("sub", sub_ddl);
                    cmd.Parameters.AddWithValue("std", std_ddl);
                    cmd.Parameters.AddWithValue("yr", yr_ddl);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                catch(Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }

            return RedirectToAction("Index");
        }

        [NonAction]
        public void fillStandard()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    con.Open();
                    List<SelectListItem> standardlist = new List<SelectListItem>();
                    SqlDataReader sdr = null;
                    SqlCommand cmd = new SqlCommand("select StandardID,Name from StandardMaster", con);
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        standardlist.Add(new SelectListItem { Text = sdr["Name"].ToString(), Value = sdr["StandardID"].ToString() });

                    }
                    con.Close();
                    ViewBag.standard = standardlist;
                }
                catch(Exception ex)
                {
                    RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }
        }

        [NonAction]
        public void filldiv()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    con.Open();
                    List<SelectListItem> divlist = new List<SelectListItem>();
                    SqlDataReader sdr = null;
                    SqlCommand cmd = new SqlCommand("select DivisionID,Name from DivisionMaster", con);
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        divlist.Add(new SelectListItem { Text = sdr["Name"].ToString(), Value = sdr["DivisionID"].ToString() });
                    }
                    con.Close();
                    ViewBag.div = divlist;
                }

                catch(Exception ex)
                {
                    RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }
        }

        [NonAction]
        public void fillaca_year()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    con.Open();
                    List<SelectListItem> acalist = new List<SelectListItem>();
                    SqlDataReader sdr = null;
                    SqlCommand cmd = new SqlCommand("select AcademicID,Year from AcademicYearMaster", con);
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        acalist.Add(new SelectListItem { Text = sdr["Year"].ToString(), Value = sdr["AcademicID"].ToString() });

                    }
                    con.Close();
                    ViewBag.yr = acalist;
                }

                catch(Exception ex)
                {
                    RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }
        }

        public ActionResult Add_standard_wise_division()
        {
            fillStandard();
            filldiv();
            fillaca_year();
            return View();
        }

        [HttpPost]
        public ActionResult Add_standard_wise_division(FormCollection fcol)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    var std = fcol["Standard"];
                    var div = fcol["Division"];
                    var year = fcol["Year"];

                    string qs = "insertStdVDiv";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("std", std);
                    cmd.Parameters.AddWithValue("div", div);
                    cmd.Parameters.AddWithValue("year", year);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                catch(Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Add_exam_standrad()
        {
            List<SelectListItem> std_divlist = new List<SelectListItem>();
            ViewBag.std_divlist = std_divlist;
            List<SelectListItem> examlist = new List<SelectListItem>();
            ViewBag.examlist = examlist;

            return View();
        }

        [HttpGet]
        public ActionResult Add_exam()
        {
            List<SelectListItem> termlist = new List<SelectListItem>();
            ViewBag.termlist = termlist;
            List<SelectListItem> stdlist = new List<SelectListItem>();
            ViewBag.stdlist = stdlist;
            return View();
        }

        [HttpGet]
        public ActionResult Add_country()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add_country(FormCollection fcol)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    string cn = fcol.Get("Name");

                    string qs = "insertCountry";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("name", cn);

                    cmd.ExecuteNonQuery();

                    con.Close();
                }

                catch(Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }
            
            return View();
        }

        [NonAction]
        public void fillcountry()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    con.Open();
                    List<SelectListItem> countrylist = new List<SelectListItem>();
                    SqlDataReader sdr = null;
                    SqlCommand cmd = new SqlCommand("select CountryID,Name from CountryMaster", con);
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        countrylist.Add(new SelectListItem { Text = sdr["Name"].ToString(), Value = sdr["CountryID"].ToString() });

                    }
                    con.Close();
                    ViewBag.country = countrylist;
                }

                catch(Exception ex)
                {
                    RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }
        }

        [HttpGet]
        public ActionResult Add_state()
        {   
            fillcountry();

            return View();
        }

        [HttpPost]
        public ActionResult Add_state(FormCollection fcol)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    var cty = fcol["Country"];
                    string st = fcol.Get("stat");

                    string qs = "insertState";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("country", cty);
                    cmd.Parameters.AddWithValue("state", st);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                catch(Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }

            return RedirectToAction("Index");
        }

        [NonAction]
        public void fillstate()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    con.Open();
                    List<SelectListItem> statelist = new List<SelectListItem>();
                    SqlDataReader sdr = null;
                    SqlCommand cmd = new SqlCommand("select StateID,Name from StateMaster", con);
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        statelist.Add(new SelectListItem { Text = sdr["Name"].ToString(), Value = sdr["StateID"].ToString() });

                    }
                    con.Close();
                    ViewBag.state = statelist;
                }

                catch(Exception ex)
                {
                    RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }
        }

        [HttpGet]
        public ActionResult Add_city()
        {
            fillstate();
            return View();
        }

        [HttpPost]
        public ActionResult Add_city(FormCollection fcol)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    var st = fcol["State"];
                    string ct = fcol.Get("cty");

                    string qs = "insertCity";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("state", st);
                    cmd.Parameters.AddWithValue("City", ct);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                catch(Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Add_student_according_acadamic_year()
        {
            List<SelectListItem> yearlist = new List<SelectListItem>();
            ViewBag.yearlist = yearlist;
            List<SelectListItem> std_divlist = new List<SelectListItem>();
            ViewBag.std_divlist = std_divlist;
            return View();
        }

        public ActionResult Add_user()
        {
            return View();
        }

        public ActionResult Add_religon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add_religon(FormCollection fcol)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    string rname = fcol.Get("Name");

                    string qs = "insertReligion";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("name", rname);

                    cmd.ExecuteNonQuery();

                    con.Close();
                }

                catch(Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }
            
            return View();
        }

        public ActionResult Add_events()
        {
            List<SelectListItem> typelist = new List<SelectListItem>();
            ViewBag.typelist = typelist;

            List<SelectListItem> stdlist = new List<SelectListItem>();
            ViewBag.stdlist = stdlist;

            List<SelectListItem> divlist = new List<SelectListItem>();
            ViewBag.divlist = divlist;
            return View();
        }

        public ActionResult Add_notification()
        {
            List<SelectListItem> typelist = new List<SelectListItem>();
            ViewBag.typelist = typelist;

            List<SelectListItem> stdlist = new List<SelectListItem>();
            ViewBag.stdlist = stdlist;

            List<SelectListItem> divlist = new List<SelectListItem>();
            ViewBag.divlist = divlist;

            return View();
        }

        public ActionResult Add_assignment_and_worksheet()
        {
            List<SelectListItem> stdlist = new List<SelectListItem>();
            ViewBag.stdlist = stdlist;

            List<SelectListItem> teacherlist = new List<SelectListItem>();
            ViewBag.teacherlist = teacherlist;
            return View();
        }

        public ActionResult Admin_login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Admin_login(login l, FormCollection fc)
        {

            string em = fc.Get("email");
            string pwd = fc.Get("pwd");
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string q = "Admin_login";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("em", em);
            cmd.Parameters.AddWithValue("pwd", pwd);
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["user"] = dt.Rows[0]["TeacherId"].ToString();
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public ActionResult Change_pwd()
        {
            return View();
        }

        public ActionResult Forgot_pwd()
        {
            return View();
        }

        //----------------------View Pages-------------------------------------

        public ActionResult List_Std()
        {
            List<Standard> std = new List<Standard>();

            using(SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                    string qs = "listStd";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qs, con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        std.Add(new Standard { StandardId = Convert.ToInt32(sdr["StandardID"]), name = sdr["Name"].ToString(), LevelOfStd = Convert.ToInt32(sdr["LevelOfstd"]) });

                    }

                    con.Close();
                }

                catch(Exception ex)
                {
                    return RedirectToAction("Error", "Shared", new { ErrorMessage = ex.Message });
                }
            }

            return View(std);
        }

        public ActionResult List_Div()
        {
            List<division> div = new List<division>();
            SqlConnection con = new SqlConnection(strcon);
            string qs = "listDiv";

            con.Open();
            SqlCommand cmd = new SqlCommand(qs, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                div.Add(new division
                {
                    DivisonID = Convert.ToInt32(sdr["DivisionID"]),
                    Name = sdr["Name"].ToString()
                });

            }
            return View(div);
        }
        public ActionResult list_Sub()
        {
            List<subject> sub = new List<subject>();
            SqlConnection con = new SqlConnection(strcon);
            string qs = "listsub";

            con.Open();
            SqlCommand cmd = new SqlCommand(qs, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                sub.Add(new subject
                {
                    SubjectID = Convert.ToInt32(sdr["SubjectID"]),
                    Name = sdr["Name"].ToString()
                });

            }
            return View(sub);
        }
        public ActionResult List_classTeacher()
        {
            List<class_teacher> c_teacher = new List<class_teacher>();
            SqlConnection con = new SqlConnection(strcon);
            string qs = "listClassTeacher";

            con.Open();
            SqlCommand cmd = new SqlCommand(qs, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                c_teacher.Add(new class_teacher
                {
                    ClassTeacherID = Convert.ToInt32(sdr["ClassTeacherID"]),
                    tname = sdr["FirstName"].ToString() + " " + sdr["LastName"].ToString(),
                    acadyear = sdr["Year"].ToString(),
                    std = sdr["Name"].ToString(),
                    div = sdr["divname"].ToString()
                });

            }
            return View(c_teacher);
        }
        public ActionResult List_SubTeacher()
        {
            List<subject_teacher> s_teacher = new List<subject_teacher>();
            SqlConnection con = new SqlConnection(strcon);
            string qs = "listSubTeacher";

            con.Open();
            SqlCommand cmd = new SqlCommand(qs, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                s_teacher.Add(new subject_teacher
                {
                    subjectteacherId = Convert.ToInt32(sdr["SubjectTeacherId"]),
                    tname = sdr["FirstName"].ToString() + " " + sdr["LastName"].ToString(),
                    acadyear = sdr["Year"].ToString(),
                    std = sdr["Name"].ToString(),
                    div = sdr["divname"].ToString(),
                    sub = sdr["SubName"].ToString()

                });

            }
            return View(s_teacher);
        }
        public ActionResult List_Religion()
        {
            List<religion> rel = new List<religion>();
            SqlConnection con = new SqlConnection(strcon);
            string qs = "listreligion";

            con.Open();
            SqlCommand cmd = new SqlCommand(qs, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                rel.Add(new religion
                {
                    ReligionID = Convert.ToInt32(sdr["ReligionID"]),
                    Name = sdr["Name"].ToString()
                });

            }
            return View(rel);
        }
        public ActionResult List_qualification()
        {
            List<qualification> qul = new List<qualification>();
            SqlConnection con = new SqlConnection(strcon);
            string qs = "listQualification";

            con.Open();
            SqlCommand cmd = new SqlCommand(qs, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                qul.Add(new qualification
                {
                    QualificationId = Convert.ToInt32(sdr["QualificationId"]),
                    Name = sdr["Name"].ToString()
                });

            }
            return View(qul);
        }
        public ActionResult List_Occupation()
        {
            List<occupation> oac = new List<occupation>();
            SqlConnection con = new SqlConnection(strcon);
            string qs = "listOccupation";

            con.Open();
            SqlCommand cmd = new SqlCommand(qs, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                oac.Add(new occupation
                {
                    OccupationId = Convert.ToInt32(sdr["OccupationId"]),
                    name = sdr["name"].ToString()
                });

            }
            return View(oac);
        }
        public ActionResult ListStandardDivison()
        {
            List<standard_wies_division> stdiv = new List<standard_wies_division>();
            SqlConnection con = new SqlConnection(strcon);
            string qs = "listStandardDivison";

            con.Open();
            SqlCommand cmd = new SqlCommand(qs, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                stdiv.Add(new standard_wies_division
                {
                    standivid = Convert.ToInt32(sdr["StandardDivisionID"]),
                    std = sdr["Name"].ToString(),
                    divi = sdr["DivName"].ToString(),
                    Year = sdr["Year"].ToString()
                });

            }
            return View(stdiv);
        }
        public ActionResult listStandardSubject()
        {
            List<standard_wies_subject> stdsub = new List<standard_wies_subject>();
            SqlConnection con = new SqlConnection(strcon);
            string qs = "listStandardsubject";

            con.Open();
            SqlCommand cmd = new SqlCommand(qs, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                stdsub.Add(new standard_wies_subject
                {
                    standardvisesubject = Convert.ToInt32(sdr["StandardWiseSubjectID"]),
                    std = sdr["Name"].ToString(),
                    sub = sdr["subname"].ToString(),
                    aca = sdr["Year"].ToString()
                });

            }
            return View(stdsub);
        }
        public ActionResult ListyearAccordingTOStandard()
        {
            List<year_according_standard> stdyear = new List<year_according_standard>();
            SqlConnection con = new SqlConnection(strcon);
            string qs = "listYearAccStd";

            con.Open();
            SqlCommand cmd = new SqlCommand(qs, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                stdyear.Add(new year_according_standard
                {
                    yearStandardId = Convert.ToInt32(sdr["Academic_year_standardId"]),
                    astd = sdr["Name"].ToString(),
                    smonth = sdr["Start_month"].ToString(),
                    emonth = sdr["End_Month"].ToString(),
                    ayear = sdr["Year"].ToString()
                });

            }
            return View(stdyear);
        }
        public ActionResult List_Teacher()
        {
            List<teacher> listTeach = new List<teacher>();
            SqlConnection con = new SqlConnection(strcon);
            string qs = "listTeacher";

            con.Open();
            SqlCommand cmd = new SqlCommand(qs, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                listTeach.Add(new teacher
                {
                    TecherId = Convert.ToInt32(sdr["TeacherId"]),
                    FirstName = sdr["FirstName"].ToString(),
                    MiddleName = sdr["MiddleName"].ToString(),
                    LastName = sdr["LastName"].ToString(),
                    Birthdate = Convert.ToDateTime(sdr["Birthdate"]),
                    Email = sdr["Email"].ToString(),
                    ContactNo = Convert.ToDecimal(sdr["ContactNo"]),
                    Address = sdr["Address"].ToString(),
                });
            }
            return View(listTeach);
        }

        public ActionResult listCountry()
        {
            List<country> listcty = new List<country>();
            SqlConnection con = new SqlConnection(strcon);
            string qs = "listCountry";

            con.Open();
            SqlCommand cmd = new SqlCommand(qs, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                listcty.Add(new country
                {
                    CountryId = Convert.ToInt32(sdr["CountryId"]),
                    Name = sdr["Name"].ToString(),

                });
            }
            return View(listcty);
        }
        public ActionResult listState()
        {
            List<state> liststate = new List<state>();
            SqlConnection con = new SqlConnection(strcon);
            string qs = "listState";

            con.Open();
            SqlCommand cmd = new SqlCommand(qs, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                liststate.Add(new state
                {
                    stat = sdr["Name"].ToString(),

                });
            }
            return View(liststate);
        }
        public ActionResult listCity()
        {
            List<city> listcity = new List<city>();
            SqlConnection con = new SqlConnection(strcon);
            string qs = "List_city";

            con.Open();
            SqlCommand cmd = new SqlCommand(qs, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                listcity.Add(new city
                {
                    cty = sdr["Name"].ToString(),

                });
            }
            return View(listcity);
        }
        public ActionResult list_acadamicYear()
        {
            List<acadamic_year> listyr = new List<acadamic_year>();
            SqlConnection con = new SqlConnection(strcon);
            string qs = "listYear";

            con.Open();
            SqlCommand cmd = new SqlCommand(qs, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                listyr.Add(new acadamic_year
                {
                    academicId = Convert.ToInt32(sdr["AcademicID"]),
                    Year = sdr["Year"].ToString(),
                    //isact=Convert.ToBoolean(sdr["IsActiveYear"])
                });
            }
            return View(listyr);
        }
    }
}