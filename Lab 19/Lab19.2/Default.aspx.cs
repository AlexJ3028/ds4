using System;
using System.IO;
using System.Net;
using System.Web.UI;

namespace Lab19._2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private string GetAllValues()
        {
            var url = "https://localhost:44307/api/values";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string responseBody = reader.ReadToEnd();
                        return responseBody;
                    }
                }
            }
            catch (WebException ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        protected void btnGetAll_Click(object sender, EventArgs e)
        {
            // Display all values
            lblResult.Text = GetAllValues();
        }
    }
}


