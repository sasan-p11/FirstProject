
using SimpleHttp;
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
        private PracticeEntities entities = new PracticeEntities();
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
                users = entities.User.Select(c => c).ToList();
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
                        user = entities.User.Find(id);
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
                    user = entities.User.Where(x => x.Login.UserName == Name && x.Login.Password == Password).FirstOrDefault();
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
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (txtGender.Text == "" && txtFilterAge.Text == "")
            {
                MessageBox.Show("plese inter text box");
                return;
            }
               

            log.Info("Filter with gender is run");

            if (txtGender.Text != "" && txtFilterAge.Text != "")
            {
                string gender = txtGender.Text;
                int age = int.Parse(txtFilterAge.Text);
                var user = new List<User>();
                try
                {
                    user = entities.User.Where(x => x.Gender == gender && x.Age == age).ToList();

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
                    user = entities.User.Where(x => x.Gender == gender).ToList();

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
            else if(txtFilterAge.Text != null)
            {
                int age = int.Parse(txtFilterAge.Text);
                var user = new List<User>();
                try
                {
                    user = entities.User.Where(x => x.Age == age).ToList();

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
                entities.User.Add(user);
                entities.SaveChanges();
                MessageBox.Show("register is sucessful");
            }
            catch (Exception ex)
            {
                log.Info(ex.Message);
                throw new Exception("can not register user");
            }
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
