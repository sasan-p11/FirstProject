﻿using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace FirstProject
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        private static readonly log4net.ILog log
     = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public RadForm1()
        {
            InitializeComponent();
        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            XmlDocument log4netConfig = new XmlDocument();
            log4netConfig.Load(File.OpenRead("log4net.config"));
            var repo = log4net.LogManager.CreateRepository(Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));
            log4net.Config.XmlConfigurator.Configure(repo,log4netConfig["log4net"]);

            log.Info("Hello logging world!");
            log.Error("Hello logging world!");
        }
    }
}