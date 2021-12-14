
using SimpleHttp;
using System;
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
            PracticeEntities entities = new PracticeEntities();
            var users = entities.User.Select(c => c).ToList();

            DataGridViewRow row = new DataGridViewRow();
            foreach(var item in users)
            {
                dataGridView2.Rows.Add(item.UserId, item.Gender, item.FirstName, item.Family, item.Age,
                                               item.RegisterDate, item.Login.UserName, item.Login.Password);
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            XmlDocument log4netConfig = new XmlDocument();
            log4netConfig.Load(File.OpenRead("log4net.config"));
            var repo = log4net.LogManager.CreateRepository(Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));
            log4net.Config.XmlConfigurator.Configure(repo, log4netConfig["log4net"]);

            log.Info("Hello logging world!");
            log.Error("Hello logging world!");
        }

        private void RestoreData()
        {
            PracticeEntities entities = new PracticeEntities();
            HttpServer.ListenAsync(8000, CancellationToken.None, Route.OnHttpRequestAsync);

            Route.Add("/myForm/", (rq, rp, args) =>
            {
                log.Info("get user with id is run");

                var files = rq.ParseBody(args);
                 
                var IsConvert = int.TryParse(args["id"],out int id);

                if(IsConvert)
                {
                    var user = entities.User.Find(id); 
                    string str = " " + user.UserId + " , " + user.Gender + " , " + user.FirstName 
                                    + " , " + " , " + user.Family + " , " + " , " + user.RegisterDate+" , "+user.Age+" , "+
                                    user.Login.UserName+" , "+user.Login.Password;
                    rp.AsText(str);
                }
                   

            });
        }

    }   
}
