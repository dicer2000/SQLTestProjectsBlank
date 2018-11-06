using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLWebApp
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        // Connection String
        private string GetConnectionString()
        {
            System.Configuration.Configuration rootWebConfig =
                System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            if (rootWebConfig.ConnectionStrings.ConnectionStrings.Count > 0)
                return rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"].ToString();
            else
                return null;
        }

    }
}