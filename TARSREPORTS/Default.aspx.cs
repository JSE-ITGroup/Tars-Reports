using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TARSREPORTS
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReportViewer1.ReportSource = (ReportDocument)Session["myReport"];
        }

        protected void Reports_Click(object sender, EventArgs e)
        {            
                try
                {
                    ReportDocument reports = new ReportDocument();
                    reports.Load(ReportsList.SelectedValue.ToString());
                    if (ReportsList.SelectedValue.ToString().Contains("CESS")|| ReportsList.SelectedValue.ToString().Contains("CA")|| ReportsList.SelectedValue.ToString().Contains("Dividend"))
                    {
                        reports.SetDatabaseLogon(Properties.Settings.Default.UserName, Properties.Settings.Default.Password, Properties.Settings.Default.Server, Properties.Settings.Default.DatabaseWebFeedRepository);
                    }
                    else
                    {
                    reports.SetDatabaseLogon(Properties.Settings.Default.UserName, Properties.Settings.Default.Password, Properties.Settings.Default.Server, Properties.Settings.Default.DatabaseWebRepository);
                }
                    CrystalReportViewer1.Visible = true;
                    CrystalReportViewer1.ReportSource = reports;
                    Session["myReport"] = reports;
                }
                catch (Exception exc)
                {
                    throw exc;
                }       
        }
    }
}