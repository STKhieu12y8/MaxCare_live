using System;
using System.Net;
using System.Text;
using License.RNCryptor;
namespace License
{
	// License.License
	using System;
    using System.Diagnostics;
    using System.IO;
    using System.Net;
	using System.Text;
    using System.Web.Script.Serialization;

	public class ResponseTrailLicense
    {
		/**
		 * result="success",
		 * result="error"
		 */
		
		public string result = "";
        public DateTime created_date;
        private string ServerURL = "https://softway.vn/index.php";


        public ResponseTrailLicense()
		{
			
			
		}
        public string getResult()
        {
            return result;
        }

		public ResponseTrailLicense checkDate(string computeCode)
		{
            //Discarded unreachable code: IL_01b6, IL_01c5
            ResponseTrailLicense responseTrailLicense = new ResponseTrailLicense();
			try
			{
                responseTrailLicense = getResponseTrailLicense(ServerURL + "?option=com_projectmanager&task=license.checkTrialerDate&computer_code=" + computeCode);
                Trace.WriteLine(ServerURL + "?option=com_projectmanager&task=license.checkTrialerDate&computer_code=" + computeCode);
				return responseTrailLicense;
			}
			catch
			{
				
			}
			return responseTrailLicense;
		}
        private ResponseTrailLicense getResponseTrailLicense(string URL)
        {
            //Discarded unreachable code: IL_0024, IL_0032
            try
            {

                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                String jsonString = webClient.DownloadString(URL);
                ResponseTrailLicense responseTrailLicense = ResponseTrailLicense.Parse(jsonString);
                return responseTrailLicense;
            }
            catch (Exception error)
            {
                throw new ArgumentNullException("{0} Exception caught.", error);
            }
        }
        public static ResponseTrailLicense Parse(string jsonString)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            ResponseTrailLicense responseTrailLicense = jss.Deserialize<ResponseTrailLicense>(jsonString);
            return responseTrailLicense;

        }

    }

    
}