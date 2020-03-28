using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;

namespace Factura
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public string hola()
        {
            return "HOla";
        }

        [WebMethod]
        public byte[] Pdf(String NombreC,String ApellidoPaternoC,String ApellidoMaternoC,String CorreoC,String CelularC,String Marca,String Descripcion,String Precio)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(@"D:\Webservice\Factura\documento.pdf", FileMode.Create));
            doc.Open();

            Paragraph title = new Paragraph();
            title.Font = FontFactory.GetFont(FontFactory.TIMES, 18f, BaseColor.BLUE);
            title.Add("Reporte De Venta ");
            doc.Add(title);

            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"D:\Webservice\Factura\cc.png");
            img.SetAbsolutePosition(400, 680);
            doc.Add(img);
            img.ScaleToFit(115f, 50F);


            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("Datos del Comprador"));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("Nombre: "+NombreC));
            doc.Add(new Paragraph("Apellido Paterno: "+ApellidoPaternoC));
            doc.Add(new Paragraph("Apellido Materno: "+ApellidoMaternoC));
            doc.Add(new Paragraph("Correo Electronico: "+CorreoC));
            doc.Add(new Paragraph("Numero de Telefono: "+CelularC));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("Descripcion del producto "));
            doc.Add(new Paragraph("Marca:"+Marca));
            doc.Add(new Paragraph("Descripcion:"+Descripcion));
            doc.Add(new Paragraph("Precio: "+Precio));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("."));
            doc.Add(new Paragraph("Facebook: WorldOfComputers        Woc@gmail.com"));
            doc.Close();

            string pdfFilePath = @"D:\Webservice\Factura\documento.pdf";
            byte[] bytes = System.IO.File.ReadAllBytes(pdfFilePath);
            System.IO.File.WriteAllBytes(pdfFilePath, bytes);

            return bytes;

            
        }
    }

}
