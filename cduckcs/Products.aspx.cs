﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cduckcs
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ((this.Master) as SiteMaster).PageTitle = "C-DUCK CONSULTANCY SERVICES | PRODUCTS | HRMS | QUIZ ENGINE | LOYALTY SOLUTIONS";
        }
    }
}