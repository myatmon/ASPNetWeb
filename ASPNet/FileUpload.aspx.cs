using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (FileUploadControl.HasFile)
            {
                try
                {
                    Utility util = new Utility();
                    
                    if (util.CheckExtension(FileUploadControl.PostedFile.ContentType))
                    {
                        if (util.CheckMaxLength(FileUploadControl.PostedFile.ContentLength))
                        {

                            string filename = Path.GetFileName(FileUploadControl.FileName);
                            switch (util.getType(FileUploadControl.PostedFile.ContentType))
                            {
                                case GlobalParameter.XLS:
                                    Reader excelReader = new ExcelReader();
                                    excelReader.Read(filename);
                                    break;
                                case GlobalParameter.XML:
                                    Reader xmlReader = new XmlReader();
                                    xmlReader.Read(filename);
                                    break;
                            }
                            //FileUploadControl.SaveAs(Server.MapPath("~/") + filename);
                            StatusLabel.Text = "Upload status: File uploaded!";
                        }
                        else
                            StatusLabel.Text = "Upload status: The file has to be less than 100 kb!";
                    }
                    else
                        StatusLabel.Text = "Upload status: Only JPEG files are accepted!";
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
        }
    }
}