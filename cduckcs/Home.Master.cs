using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cduckcs
{
    public partial class Home : System.Web.UI.MasterPage
    {
        string pageTitle;
        public string PageTitle
        {
            get { return pageTitle; }
            set { pageTitle = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}