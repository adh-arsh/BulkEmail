using Aspose.Email.Clients;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Vml;
using OpenXmlPowerTools;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Xml.Linq;
using System.Xml.Serialization;
using Excel = Microsoft.Office.Interop.Excel;

namespace BulkEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


      
        private void uploadExcelBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string filepath = getFilePath();
                if (filepath != "")
                {
                    importExcel(filepath);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public bool importExcel(string filepath = @"d:\Exhibitors.xlsx")
        {
            try
            {


                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                Excel.Range range;

                excelGV.Rows.Clear();
                excelGV.Columns.Clear();
                excelGV.DataSource = null;

                string str;
                int rCnt;
                int cCnt;
                int rw = 0;
                int cl = 0;

                Debug.WriteLine("--------------");

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(filepath, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                range = xlWorkSheet.UsedRange;
                rw = range.Rows.Count;
                cl = range.Columns.Count;

                

                for (int i = 1; i <= cl; i++)
                {
                    
                    string colName = (string)(range.Cells[1, i] as Excel.Range).Value2;
                    excelGV.Columns.Add(colName, colName);

                }
               


                for (rCnt = 2; rCnt <= rw; rCnt++)
                {
                    string[] row = new string[cl];


                    for (int i = 1; i <= cl; i++)
                    {
                        
                        Debug.WriteLine((string)(range.Cells[rCnt, i] as Excel.Range).Value2);
                        row[i-1] = (string)(range.Cells[rCnt, i] as Excel.Range).Value2;

                        Debug.WriteLine(row.Length.ToString());
                    }
                    foreach(string item in row)
                    {
                        Debug.WriteLine(item);
                    }
                    

                    excelGV.Rows.Add(row);
                }
                excelGV.Columns.Add("Status", "Status");

                xlWorkBook.Close(true, null, null);
                xlApp.Quit();



                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public string getFilePath(string type = "excel")
        {
            string filepath = "";

            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Excel Files|*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt;*.xls;*.xml;*.xml;*.xlam;*.xla;*.xlw;*.xlr;*.csv;";
            if (type == "word")
            {
                choofdlog.Filter = "Word Document|*.docx;*.doc;";
            }
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                filepath = sFileName;
            }

            
            return filepath;
        }


        public bool importWord(string filepath = @"d:\Exhibitors.docx")
        {
            try
            {

                Debug.WriteLine(filepath);
                wordToHTML(filepath);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        private void uploadTemplateBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string filepath = getFilePath("word");
                if (filepath != "")
                {
                    importWord(filepath);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void wordToHTML(string filepath)
        {
            //string startupPath = System.IO.Directory.GetCurrentDirectory();

            string startupPath = Environment.CurrentDirectory;

            byte[] byteArray = File.ReadAllBytes(filepath);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                memoryStream.Write(byteArray, 0, byteArray.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(memoryStream, true))
                {
                    HtmlConverterSettings settings = new HtmlConverterSettings()
                    {
                        PageTitle = "Email from techvestors"
                    };
                    XElement html = HtmlConverter.ConvertToHtml(doc, settings);

                    Debug.WriteLine(startupPath);
                    
                    File.WriteAllText(startupPath +"\\html.txt", html.ToStringNewLineOnAttributes());

                }
            }
        }



        //sendimg email using host system
        private string _sendMail(string from, string to, string subject, string host, int port, string email, string password, string fromName)
        {
            string returnStatus = "Not Sent";

            string startupPath = Environment.CurrentDirectory;

            string emailbodyHTML = File.ReadAllText(startupPath + "\\html.txt");

            MailAddress fromAddress = new MailAddress(from, fromName);
            MailAddress toAddress = new MailAddress(to);

            MailMessage mail = new MailMessage(fromAddress.Address, toAddress.Address);
            mail.Subject = subject;
            mail.Body = emailbodyHTML;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            SmtpClient client = new SmtpClient();
            client.Host = host;
            client.Port = port;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(email, password);

            try
            {
                client.Send(mail);
                //MessageBox.Show("Mail Sent!", "Success", MessageBoxButtons.OK);
                returnStatus = "Success";
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                returnStatus = "Error: "+ ex.Message;
            }

            return returnStatus;
        }


        private void testMailBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            _sendMail(from: emailTB.Text,
                to: emailTB.Text,
                subject: "Email for SMTP configuration",
                host: hostTB.Text,
                port: Int32.Parse(portTB.Text),
                email: emailTB.Text,
                password: passwordTB.Text,
                fromName: sendernameTB.Text
                ));
        }

        public bool addVariablesToHTMLtxt(string name)
        {
            bool retStatus = false;

            string startupPath = Environment.CurrentDirectory;
            string emailbodyHTML = File.ReadAllText(startupPath + "\\html.txt");
            
            string sourcePath = startupPath + "\\html.txt";
            string destinationPath = startupPath + "\\msg.txt";

            try
            {

                File.WriteAllLines(destinationPath, File.ReadLines(sourcePath).Select(line => line.Replace("{name}", name)));


                //replace variables in subject line 
                string subjectLine = subjectTB.Text;
                subjectTB.Text = subjectLine.Replace("{name}", name);
                retStatus = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                retStatus = false;
            }


            return retStatus;

        }


        //sending email using API hosted in clients website
        private string sendEmail(string subject, string toEmail, string name)
        {
            string returnStatus = "Not Sent";

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://textilefairsindia.com/automation-test/auto-emailer/sendemail.php");



            string urlParameters = "?subject=" + subject + "&email=" + toEmail + "&name=" +name;


            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
            // Get data response
            var response = client.GetAsync(urlParameters).Result;

            if (response.IsSuccessStatusCode)
            {

                // Parse the response body
                var dataObjects = response.Content.ReadAsStringAsync().Result;

                returnStatus = "Sent";


            }
            else
            {
                returnStatus = "Error";
            }


            return returnStatus;
        }

        private void sendMailBtn_Click(object sender, EventArgs e)
        {
            sendMailBtn.Text = "Cancel";
            try
            {
                

                foreach (DataGridViewRow row in excelGV.Rows)
                {

                    

                    bool emailIsNotNull = row.Cells["email"].Value != null;

                    if (emailIsNotNull)
                    {
                        string name = row.Cells["name"].Value.ToString();

                        string toEmail = row.Cells["email"].Value.ToString();
                       

                       
                        string subjectLine = subjectTB.Text;

                        string subject = subjectLine.Replace("{name}", name);

                        if (toEmail != "" && subjectTB.Text.Length > 0)
                        {
                            Debug.WriteLine(name + subject + "------");
                            
                            if (addVariablesToHTMLtxt(name))
                            {

                           
                                
                               row.Cells["Status"].Value = _sendMail(
                                                               from: fromEmailTB.Text,
                                                               to: toEmail,
                                                               subject: subject,
                                                               host: hostTB.Text,
                                                               port: Int32.Parse(portTB.Text),
                                                               email: emailTB.Text,
                                                               password: passwordTB.Text,
                                                               fromName: sendernameTB.Text
                                                               );

                                

                                //row.Cells["Status"].Value = sendEmail(subject: subjectTB.Text, toEmail);
                               


                            }
                           

                           // sendEmail(subject, toEmail, name);


                        }
                        else
                        {
                            MessageBox.Show("Email or subject line missing");
                        }


                    }
                    countLbl.Text =  row.Index.ToString() + " of " + (excelGV.Rows.Count-1).ToString();

                }

                sendMailBtn.Text = "Send";
                countLbl.Text = "";
            }
            catch (Exception ex)
            {
                sendMailBtn.Text = "Send";
                MessageBox.Show(ex.Message);
                
            }


        }


    }
}