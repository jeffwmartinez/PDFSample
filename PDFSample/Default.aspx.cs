using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PDFSample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            SelectPdf.PdfDocument document = new SelectPdf.PdfDocument();
            SelectPdf.HtmlToPdf htmlToPdf = new SelectPdf.HtmlToPdf();
            document = htmlToPdf.ConvertUrl(txtUrl.Text);
            document.Save(Response, false, "Sample.pdf");

            document.Close();
        }
    }
}