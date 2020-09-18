using InvoiceGenerationBAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InvoiceGenerationUI
{
    public partial class ImportExport : System.Web.UI.Page
    {
        private IImport _importBAL;
        public ImportExport(IImport importBAL)
        {
            _importBAL = importBAL;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //Page.ClientScript.RegisterStartupScript(typeof(Page), "Javascript", "showhidemessage('#successalert'); ", true);
            }
        }
        private readonly string ImportFullPath = ConfigurationManager.AppSettings["ImportFilePath"].ToString();

        protected void btnImport_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                object obj = null;
                string alertid = string.Empty;
                FileInfo info = new FileInfo(fuImport.FileName);
                string fileName = info.Name+"_" + DateTime.Now.ToString("ddMMyyyyhhmmss")  + info.Extension;
                fuImport.SaveAs(ImportFullPath + fileName);
                if (ddlImportType.SelectedValue == "1")
                {
                    obj = _importBAL.P2Import(fileName);
                }
                else if(ddlImportType.SelectedValue == "2")
                {
                    obj = _importBAL.P3Import(fileName);
                }
                else if (ddlImportType.SelectedValue == "3")
                {
                    obj = _importBAL.GLImport(fileName);
                }
                
                if (obj != null && int.Parse(obj.ToString()) > 0)
                {
                    //alertid = "#successalert";
                    successalert.Visible = true;
                    ddlImportType.SelectedValue = "0";
                }
                else
                {
                    erroralert.Visible = true;
                    //alertid = "#erroralert";
                }
                //ClientScript.RegisterStartupScript(GetType(), "Javascript", "showhidemessage('" + alertid+"'); ", true);
            }
        }

        protected void cvImport_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = fuImport.HasFile;
        }
    }
}