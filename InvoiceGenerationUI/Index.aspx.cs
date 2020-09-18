using InvoiceGenerationBO;
using InvoiceGenerationDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InvoiceGenerationUI
{
    public partial class Index : System.Web.UI.Page
    {

        private IDataRepository _dataRepository;
        public Index(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                List<P2Source> p2Sources = _dataRepository.Get<P2Source>("usp_GetP2Source");
                rptTest.DataSource = p2Sources;
                rptTest.DataBind();
            }
        }
    }

        
}