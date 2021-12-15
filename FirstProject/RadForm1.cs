
using SimpleHttp;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace FirstProject
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        private Entities entities = new Entities();
        private static readonly log4net.ILog log
     = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public RadForm1()
        {
            RestoreData();
            InitializeComponent();
        }
        private void RadForm1_Load(object sender, EventArgs e)
        {
            log.Info("RadForm1_load is run!!!");

            //var users = entities.User.Select(c => c).ToList();
            var users = new List<User>();

            try
            {
                log.Info("Get User for RadForm1_load !!!");
                users = entities.Users.Select(c => c).ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                throw new Exception("can not get data");
            }

            foreach (var item in users)
            {
                dataGridView2.Rows.Add(item.UserId, item.Gender, item.FirstName, item.Family, item.Age,
                                               item.RegisterDate, item.Login.UserName, item.Login.Password);
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            //XmlDocument log4netConfig = new XmlDocument();
            //log4netConfig.Load(File.OpenRead("log4net.config"));
            //var repo = log4net.LogManager.CreateRepository(Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));
            //log4net.Config.XmlConfigurator.Configure(repo, log4netConfig["log4net"]);

            log.Info("Hello logging world!");
            log.Error("Hello logging world!");
        }

        private void RestoreData()
        {
            HttpServer.ListenAsync(8000, CancellationToken.None, Route.OnHttpRequestAsync);

            Route.Add("/GetUser", (rq, rp, args) =>
            {
                log.Info("get user by id is run");

                var files = rq.ParseBody(args);

                var IsConvert = int.TryParse(args["id"], out int id);

                if (IsConvert)
                {
                    var user = new User();
                    try
                    {
                        log.Info("get data for selct user by id ");
                        user = entities.Users.Find(id);
                    }
                    catch (Exception ex)
                    {
                        log.Error(ex.Message);
                        throw new Exception("can not get data for select user by id");
                    }
                    if (user != null)
                    {
                        string str = " " + user.UserId + " , " + user.Gender + " , " + user.FirstName
                                   + " , " + " , " + user.Family + " , " + " , " + user.RegisterDate + " , " + user.Age + " , " +
                                   user.Login.UserName + " , " + user.Login.Password;
                        rp.AsText(str);
                    }
                    else
                    {
                        rp.AsText("user not found!!");
                    }
                }
            });
            Route.Add("/LoginUser", (rq, rp, args) =>
            {
                log.Info("Login User is run");

                var files = rq.ParseBody(args);

                string Name = args["name"];
                string Password = args["password"];

                var user = new User();
                try
                {
                    user = entities.Users.Where(x => x.Login.UserName == Name && x.Login.Password == Password).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                    throw;
                }

                if (user != null)
                {
                    string str = " " + user.UserId + " , " + user.Gender + " , " + user.FirstName
                              + " , " + " , " + user.Family + " , " + " , " + user.RegisterDate + " , " + user.Age;

                    rp.AsText(str);
                }
                else
                {
                    rp.AsText("UserName or password not valid");
                }
            });
            Route.Add("/RegisterUser", (rq, rp, args) =>
            {
                log.Info("Register User is run");

                var files = rq.ParseBody(args);

                string name = args["name"];
                string family = args["family"];
                int age = int.Parse(args["age"]);
                string gender = args["gender"];
                string userName = args["username"];
                string password = args["password"];

                var user = new User()
                {
                    FirstName = name,
                    Family = family,
                    Age = age,
                    Gender = gender,
                    RegisterDate = DateTime.Now,
                    Login = new Login()
                    {
                        UserName = userName,
                        Password = password
                    }
                };


                var entity = new Entities();
                try
                {
                    entities.Users.Add(user);
                    entities.SaveChanges();
                    rp.AsText("register is sucsecful");
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                    throw new Exception("can not register user");
                }
            });
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (txtGender.Text == "" && txtFilterAge.Text == "" && !rdoFilterRegsiterDate.IsChecked)
            {
                MessageBox.Show("plese inter text box");
                return;
            }


            log.Info("Filter with gender is run");

            if (rdoFilterRegsiterDate.IsChecked)
            {
                var user = new List<User>();
                try
                {
                    user = entities.Users.Select(c => c).OrderBy(x => x.RegisterDate).ToList();

                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                    throw new Exception("can not get user with gender");
                }
                dataGridView2.Rows.Clear();
                int i = 0;
                foreach (var item in user)
                {
                    if (i == 5)
                        break;

                    dataGridView2.Rows.Add(item.UserId, item.Gender, item.FirstName, item.Family, item.Age,
                                                      item.RegisterDate, item.Login.UserName, item.Login.Password);
                    ++i;
                }

            }
            else if (txtGender.Text != "" && txtFilterAge.Text != "")
            {
                string gender = txtGender.Text;
                int age = int.Parse(txtFilterAge.Text);
                var user = new List<User>();
                try
                {
                    user = entities.Users.Where(x => x.Gender == gender && x.Age == age).ToList();

                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                    throw new Exception("can not get user with gender");
                }

                dataGridView2.Rows.Clear();
                foreach (var item in user)
                {
                    dataGridView2.Rows.Add(item.UserId, item.Gender, item.FirstName, item.Family, item.Age,
                                                   item.RegisterDate, item.Login.UserName, item.Login.Password);
                }
            }
            else if (txtGender.Text != "")
            {
                string gender = txtGender.Text;
                var user = new List<User>();
                try
                {
                    user = entities.Users.Where(x => x.Gender == gender).ToList();

                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                    throw new Exception("can not get user with gender");
                }

                dataGridView2.Rows.Clear();
                foreach (var item in user)
                {
                    dataGridView2.Rows.Add(item.UserId, item.Gender, item.FirstName, item.Family, item.Age,
                                                   item.RegisterDate, item.Login.UserName, item.Login.Password);
                }
            }
            else if (txtFilterAge.Text != "")
            {
                int age = int.Parse(txtFilterAge.Text);
                var user = new List<User>();
                try
                {
                    user = entities.Users.Where(x => x.Age == age).ToList();

                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                    throw new Exception("can not get user with age");
                }

                dataGridView2.Rows.Clear();
                foreach (var item in user)
                {
                    dataGridView2.Rows.Add(item.UserId, item.Gender, item.FirstName, item.Family, item.Age,
                                                   item.RegisterDate, item.Login.UserName, item.Login.Password);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            log.Info("Register User is Run !!");

            var name = txtFirstName.Text;
            var family = txtFamily.Text;
            var age = txtAge.Text != "" ? int.Parse(txtAge.Text) : 0;
            var gender = txtGenderRegister.Text;
            var userName = txtUserNameRegister.Text;
            var password = txtPasswordRegister.Text;

            if (name == "")
                MessageBox.Show("please inter Name");
            if (family == "")
                MessageBox.Show("please inter Family");
            if (age == 0)
                MessageBox.Show("please inter Age");
            if (gender == "")
                MessageBox.Show("please inter Gender");
            if (userName == "")
                MessageBox.Show("please inter UserName");
            if (password == "")
                MessageBox.Show("please inter Password");

            var user = new User()
            {
                FirstName = name,
                Family = family,
                Age = age,
                Gender = gender,
                RegisterDate = DateTime.Now,
                Login = new Login()
                {
                    UserName = userName,
                    Password = password
                }
            };

            try
            {
                entities.Users.Add(user);
                entities.SaveChanges();
                MessageBox.Show("register is sucessful");
            }
            catch (Exception ex)
            {
                log.Info(ex.Message);
                throw new Exception("can not register user");
            }
        }

        private void btnExpotExcel_Click(object sender, EventArgs e)
        {
            Workbook book = new Workbook();
            if (File.Exists(@"C:\Users\mahrayan\Desktop\Report.xlsx"))
            {
                book.LoadFromFile(@"C:\Users\mahrayan\Desktop\Report.xlsx");
            }
            Worksheet sheet = book.Worksheets["Exported from gridview"];
            if (sheet == null)
            {
                sheet = book.CreateEmptySheet("Exported from gridview");
            }
            //Convert data from datagridview to datatable
            DataTable dt = GetDgvToTable(dataGridView2);
            //Export datatable to excel
            int startRow = sheet.LastRow + 2;
            if (startRow > 60000)
            {
                startRow = 1;
            }
            sheet.InsertDataTable(dt, true, startRow, 1, -1, -1);
            sheet.Range[1, 1, sheet.LastRow, sheet.LastColumn].AutoFitColumns();
            sheet.AllocatedRange.BorderAround(LineStyleType.Thin, borderColor: ExcelColors.Black);
            sheet.AllocatedRange.BorderInside(LineStyleType.Thin, borderColor: ExcelColors.Black);
            book.SaveToFile(@"C:\Users\mahrayan\Desktop\Report.xlsx", ExcelVersion.Version2013);
            book.Dispose();
            MessageBox.Show("Export complete");
        }
        public DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            //Column
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }

            //Row
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
               // for (int countsub = 0; countsub < dgv.Rows.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            decimal total = dataGridView2.SelectedRows.OfType<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells[2].Value));
            dt.Rows.Add(total);
            return dt;
        }
        //private void CreateFileLog()
        //{
        //    XmlDocument log4netConfig = new XmlDocument();
        //    log4netConfig.Load(File.OpenRead("log4net.config"));
        //    var repo = log4net.LogManager.CreateRepository(Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));
        //    log4net.Config.XmlConfigurator.Configure(repo, log4netConfig["log4net"]);
        //}
    }
}
