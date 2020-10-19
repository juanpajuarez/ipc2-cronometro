using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace timer_ipc2
{
    public partial class Default : System.Web.UI.Page
    {
        public static Stopwatch stopwatch;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                stopwatch = new Stopwatch();
                stopwatch.Start();
            }
        }

        protected void Timer1_tick(object sender, EventArgs e)
        {
            if (stopwatch.Elapsed.Minutes<10)
            {
                lbltiempo.Text = "0" + stopwatch.Elapsed.Minutes.ToString();
            }
            else
            {
                lbltiempo.Text = stopwatch.Elapsed.Minutes.ToString();
            }
            lbltiempo.Text += ":";
            if (stopwatch.Elapsed.Seconds < 10)
            {
                lbltiempo.Text += "0" + stopwatch.Elapsed.Seconds.ToString();
            }
            else
            {
                lbltiempo.Text += stopwatch.Elapsed.Seconds.ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Tiempo1"] = stopwatch.Elapsed.Seconds;
            stopwatch.Restart();
            Label1.Text = Session["Tiempo1"].ToString();
        }
    }
}