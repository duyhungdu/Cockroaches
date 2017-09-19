using Aspose.Words;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Text.RegularExpressions;

public partial class Util
{
    public static string DetecVowel(string keyword)
    {
        if (string.IsNullOrEmpty(keyword))
        {
            keyword = "";
        }
        keyword = keyword.ToLower();
        char[] charArr = keyword.ToCharArray();
        keyword = "";
        foreach (char c in charArr)
        {
            string tmp = "";
            tmp = c.ToString();

            if (c == 'a')
            {
                tmp = "[aáàạảãâấầậẩẫăắằặẳẵ]";
            }
            if (c == 'e')
            {
                tmp = "[eéèẹẻẽêếềệểễ]";
            }
            if (c == 'o')
            {
                tmp = "[oóòọỏõôốồộổỗơớờợởỡ]";
            }
            if (c == 'i')
            {
                tmp = "[iíìịỉĩ]";
            }
            if (c == 'u')
            {
                tmp = "[uúùụủũưứừựửữ]";
            }
            if (c == 'd')
            {
                tmp = "[dđ]";
            }
            if (c == 'y')
            {
                tmp = "[ýyỳỷỹ]";
            }
            keyword += tmp;
        }
        return keyword;
    }

    public static string GetDayOfWeek(int i)
    {
        switch (i) {
            case 0:
                return "Thứ hai";                
            case 1:
                return "Thứ ba";
            case 2:
                return "Thứ tư";
            case 3:
                return "Thứ năm";
            case 4:
                return "Thứ sáu";
            case 5:
                return "Thứ bảy";
            case 6:
                return "Chủ nhật";
            default:
                return "";
        }
    }

    #region Generate Document
    public static Document GenerateDocument(string content, int padding = 10, bool landScape = false)
    {
        Document doc = new Document();

        #region Default Font
        //doc.NodeChangingCallback = new HandleNodeChanging_FontChanger();
        #endregion Default Font

        DocumentBuilder builder = new DocumentBuilder(doc);

        #region Phân trang
        doc.FirstSection.PageSetup.RestartPageNumbering = true;
        doc.FirstSection.PageSetup.PageStartingNumber = 1;
        builder.MoveToHeaderFooter(HeaderFooterType.FooterPrimary);
        builder.ParagraphFormat.Alignment = ParagraphAlignment.Right;

        builder.InsertField("Page");
        builder.MoveToDocumentEnd();
        #endregion Phân trang

        #region Paper Size, Margin, Orientation
        PageSetup pageSetup = builder.PageSetup;
        pageSetup.PaperSize = Aspose.Words.PaperSize.A4;
        pageSetup.TopMargin = ConvertUtil.MillimeterToPoint(padding);
        pageSetup.RightMargin = ConvertUtil.MillimeterToPoint(padding);
        pageSetup.BottomMargin = ConvertUtil.MillimeterToPoint(padding);
        pageSetup.LeftMargin = ConvertUtil.MillimeterToPoint(padding);
        pageSetup.Orientation = landScape ? Aspose.Words.Orientation.Landscape : Orientation.Portrait;
        #endregion

        #region Insert HTML
        builder.InsertHtml(content);
        #endregion
        return doc;
    }
    #endregion
    #region Create document
    public static string CreateDocument(string content, string preName, string tempName, int padding = 10, bool landScape = false)
    {
        //delete old file
        DirectoryInfo dirFile = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/Temp"));        
        foreach (FileInfo file in dirFile.GetFiles())
        {
            file.Delete();
        }
        LoadOptions loadOptions = new LoadOptions();
        loadOptions.LoadFormat = LoadFormat.Doc;
        Document wordDocument = Util.GenerateDocument(content, padding, landScape);
        string fileDocName = preName + "-" + Guid.NewGuid().ToString() + ".doc";
        wordDocument.Save(HttpContext.Current.Server.MapPath("~/Temp/" + tempName + ".doc"), SaveFormat.Doc);
        Document docFile = new Document(HttpContext.Current.Server.MapPath("~/Temp/" + tempName + ".doc"), loadOptions);
        docFile.Save(HttpContext.Current.Server.MapPath("~/Temp/" + fileDocName), SaveFormat.Doc);
       
        return "temp/" + fileDocName;
    }
    #endregion

    #region Generate Document
    public static Document GenerateContent(string content, int padding = 10)
    {
        Document doc = new Document();

        #region Default Font
        //doc.NodeChangingCallback = new HandleNodeChanging_FontChanger();
        #endregion Default Font

        DocumentBuilder builder = new DocumentBuilder(doc);

        #region Phân trang
        doc.FirstSection.PageSetup.RestartPageNumbering = true;
        doc.FirstSection.PageSetup.PageStartingNumber = 1;
        builder.MoveToHeaderFooter(HeaderFooterType.FooterPrimary);
        builder.ParagraphFormat.Alignment = ParagraphAlignment.Right;

        builder.InsertField("Page");
        builder.MoveToDocumentEnd();
        #endregion Phân trang

        #region Paper Size, Margin, Orientation
        PageSetup pageSetup = builder.PageSetup;
        pageSetup.PaperSize = Aspose.Words.PaperSize.A4;
        pageSetup.TopMargin = ConvertUtil.MillimeterToPoint(padding);
        pageSetup.RightMargin = ConvertUtil.MillimeterToPoint(padding);
        pageSetup.BottomMargin = ConvertUtil.MillimeterToPoint(padding);
        pageSetup.LeftMargin = ConvertUtil.MillimeterToPoint(padding);
        pageSetup.Orientation = Aspose.Words.Orientation.Landscape;
        #endregion

        #region Insert HTML
        builder.InsertHtml(content);
        #endregion
        return doc;
    }
    #endregion
    #region Create document
    public static string CreateContent(string content, string preName, string tempName, int padding = 10)
    {
        //delete old file
        DirectoryInfo dirFile = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/Temp"));
        try
        {
            foreach (FileInfo file in dirFile.GetFiles())
            {
                file.Delete();
            }
        }
        catch
        {
        }
        LoadOptions loadOptions = new LoadOptions();
        loadOptions.LoadFormat = LoadFormat.Doc;
        Document wordDocument = Util.GenerateContent(content, padding);
        string fileDocName = preName + "-" + Guid.NewGuid().ToString() + ".doc";
        wordDocument.Save(HttpContext.Current.Server.MapPath("~/Temp/" + tempName + ".doc"), SaveFormat.Doc);
        Document docFile = new Document(HttpContext.Current.Server.MapPath("~/Temp/" + tempName + ".doc"), loadOptions);
        docFile.Save(HttpContext.Current.Server.MapPath("~/Temp/" + fileDocName), SaveFormat.Doc);
        return "temp/" + fileDocName;
    }
    #endregion
    public static string BuildObjectTitleSEO(object objectTitle)
    {
        string strReturn = "";
        Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
        strReturn = Regex.Replace(objectTitle.ToString().Trim(), "[^\\w\\s]", string.Empty).Replace("-", string.Empty).Replace(" ", "-").Replace(":", "-").Replace("--", "-").ToLower();
        string strFormD = strReturn.Normalize(System.Text.NormalizationForm.FormD);
        return regex.Replace(strFormD, string.Empty).Replace("đ", "d");
    }
}
public  static partial class DateTimeExtension
{
    public static DateTime GetFirstDayOfWeek(this DateTime date)
    {
        CultureInfo myCI = new CultureInfo("vi-VN");
        Calendar myCal = myCI.Calendar;
        var firstDayOfWeek = myCI.DateTimeFormat.FirstDayOfWeek;

        while (date.DayOfWeek != firstDayOfWeek)
        {
            date = date.AddDays(-1);
        }
        return date;
    }
} 
 

public partial class EmailHelper
{
     
    public async static Task Send_Email(string mailFrom, string passmailFrom, string mailTo, string cc, string bcc, string subject, string body)
    {
        string _mailServer = "smtp.gmail.com";
        int _mailPort = 587;

        MailMessage mailMessage = new MailMessage();
        SmtpClient mailClient = new SmtpClient(_mailServer, _mailPort);
        mailClient.Timeout = 15000;
        mailClient.Credentials = new NetworkCredential(mailFrom, passmailFrom);
        mailClient.EnableSsl = true;

        mailMessage.IsBodyHtml = true;
        mailMessage.From = new MailAddress(mailFrom);
        mailMessage.Subject = subject;
        foreach (string s in bcc.Split(','))
        {
            if (!string.IsNullOrEmpty(s))
            {
                if (s != mailTo)
                {
                    MailAddress emailBcc = new MailAddress(s);
                    if (!mailMessage.Bcc.Contains(emailBcc))
                    {
                        mailMessage.Bcc.Add(emailBcc);
                    }
                }
            }
        }
        foreach (string s in cc.Split(','))
        {
            if (!string.IsNullOrEmpty(s))
            {
                if (s != mailTo)
                {
                    MailAddress emailCc = new MailAddress(s);
                    if (!mailMessage.CC.Contains(emailCc))
                    {
                        mailMessage.CC.Add(emailCc);
                    }
                }
            }
        }
        mailMessage.Body = body;
        mailMessage.To.Add(mailTo);
        try
        {
           await  mailClient.SendMailAsync(mailMessage);
        }
        catch
        {

        }
    }
}
 