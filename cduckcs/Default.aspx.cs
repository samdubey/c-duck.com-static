using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cduckcs
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ((this.Master) as Home).PageTitle = "C-DUCK CONSULTANCY SERVICES | HOME | BUSINESS TECHNOLOGY CONSULTING | IT SERVICES | HR SOLUTIONS";
        }
    }
}
