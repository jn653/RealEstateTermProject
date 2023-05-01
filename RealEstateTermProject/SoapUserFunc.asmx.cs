using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;
using Utilities;

namespace RealEstateTermProject
{
    /// <summary>
    /// Summary description for SoapUserFunc
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SoapUserFunc : System.Web.Services.WebService
    {

        [WebMethod]
        //making sure the username isnt already in the database when signup happens
        public string ValidateSignUp(string usernameTextBox)
        {
            string errorMessage;
            SqlCommand objCommand20 = new SqlCommand();
            objCommand20.CommandType = CommandType.StoredProcedure;
            objCommand20.CommandText = "TP_validateCreateNewUser";

            objCommand20.Parameters.AddWithValue("@Username", usernameTextBox);

            SqlParameter outputParameter = new SqlParameter("@accountUsername", SqlDbType.VarChar, 600);
            outputParameter.Direction = ParameterDirection.Output;
            objCommand20.Parameters.Add(outputParameter);

            DBConnect objDB = new DBConnect();
            DataSet myDataSet;
            myDataSet = objDB.GetDataSet(objCommand20);


            string profileUsername = objCommand20.Parameters["@accountUsername"].Value.ToString();
           

            return profileUsername;
        } 

        //adding a user account to the user account database table
        public void addUserAccount(string username, string password, string email, string accountType, string firstquestion, string secondquestion, string thirdquestion, string firstanswer, string secondanswer, string thirdanswer)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_AddUserAccount";


            objCommand.Parameters.AddWithValue("@theUsername", username);
            objCommand.Parameters.AddWithValue("@thePassword", password);
            objCommand.Parameters.AddWithValue("@accountType", accountType);
            objCommand.Parameters.AddWithValue("@theEmail", email);
            objCommand.Parameters.AddWithValue("@FirstSecurityQuestion", firstquestion);
            objCommand.Parameters.AddWithValue("@SecondSecurityQuestion", secondquestion);
            objCommand.Parameters.AddWithValue("@ThirdSecurityQuestion", thirdquestion);
            objCommand.Parameters.AddWithValue("@FirstAnswer", firstanswer);
            objCommand.Parameters.AddWithValue("@SecondAnswer", secondanswer);
            objCommand.Parameters.AddWithValue("@ThirdAnswer", thirdanswer);


            DBConnect objDB = new DBConnect();
            DataSet myDataSet;
            myDataSet = objDB.GetDataSet(objCommand);

           
        }
        //getting user id by entering the stored username
        public int GetIDByUsername(string username)
        {
            

            SqlCommand objCommand50 = new SqlCommand();
            objCommand50.CommandType = CommandType.StoredProcedure;
            objCommand50.CommandText = "TP_RetrieveUserID";


            objCommand50.Parameters.AddWithValue("@theUsername", username);


            SqlParameter outputParameter30 = new SqlParameter("@theID", SqlDbType.Int, 600);
            outputParameter30.Direction = ParameterDirection.Output;
            objCommand50.Parameters.Add(outputParameter30);




            DBConnect objDB46 = new DBConnect();
            objDB46.GetDataSet(objCommand50);

            int UserID = Convert.ToInt32(objCommand50.Parameters["@theID"].Value.ToString());

            return UserID;
        }


        public List<String> GetUsernameAccountybyID(int id)
        {
            List<String> infoArray = new List<String>();


            SqlCommand objCommand50 = new SqlCommand();
            objCommand50.CommandType = CommandType.StoredProcedure;
            objCommand50.CommandText = "TP_RetrieveUsernameAccount";


            objCommand50.Parameters.AddWithValue("@theID", id);


            SqlParameter outputParameter30 = new SqlParameter("@theAccount", SqlDbType.VarChar, 600);
            outputParameter30.Direction = ParameterDirection.Output;
            objCommand50.Parameters.Add(outputParameter30);

            SqlParameter outputParameter31 = new SqlParameter("@theUsername", SqlDbType.VarChar, 600);
            outputParameter31.Direction = ParameterDirection.Output;
            objCommand50.Parameters.Add(outputParameter31);




            DBConnect objDB46 = new DBConnect();
            objDB46.GetDataSet(objCommand50);

            string accountType = objCommand50.Parameters["@theAccount"].Value.ToString();
            string Username = objCommand50.Parameters["@theUsername"].Value.ToString();

            infoArray.Add(accountType);
            infoArray.Add(Username);

            return infoArray;
        }
        //adding the realestate company info after signup page
        public void AddRealEstateCompany(string username, int userID, string companyName, string phoneNumber, string agentName)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_AddToRealEstateComapnyInfo";


            objCommand.Parameters.AddWithValue("@theagentUsername", username);
            objCommand.Parameters.AddWithValue("@theID", userID);
            objCommand.Parameters.AddWithValue("@theCompanyName", companyName);
            objCommand.Parameters.AddWithValue("@theAgentName", agentName);
            objCommand.Parameters.AddWithValue("@thePhoneNumber", phoneNumber);
            


            DBConnect objDB = new DBConnect();
            DataSet myDataSet;
            myDataSet = objDB.GetDataSet(objCommand);


        }

        //adding to requested seller table from show real estate comapny
        public void AddToRequestedSeller(string username, int userID, string address, string amentities, string state, decimal price, string city, string garage,
           string description, List<Room> rooms, string houseImages, int year, int bathroom, int bedroom, string proptype, string utils, int AgentId)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_AddToRequestedSeller";


            objCommand.Parameters.AddWithValue("@theagentUsername", username);
            objCommand.Parameters.AddWithValue("@theID", userID);
            objCommand.Parameters.AddWithValue("@theAddress	", address);
            objCommand.Parameters.AddWithValue("@theAmentities", amentities);
            objCommand.Parameters.AddWithValue("@theState", state);
            objCommand.Parameters.AddWithValue("@thePrice", price);
            objCommand.Parameters.AddWithValue("@theCiy", city);
            objCommand.Parameters.AddWithValue("@theGarage", garage);
            objCommand.Parameters.AddWithValue("@theHomeDescription", description);
            objCommand.Parameters.AddWithValue("@theHomeSize", rooms);
            objCommand.Parameters.AddWithValue("@theHouseImages", houseImages);
            objCommand.Parameters.AddWithValue("@theHouseYear", year);
            objCommand.Parameters.AddWithValue("@theNumOfBathroom", bathroom);
            objCommand.Parameters.AddWithValue("@theNumOfBedrooms",  bedroom);
            objCommand.Parameters.AddWithValue("@thePropertyType", proptype);
            objCommand.Parameters.AddWithValue("@theUtilities", utils);
            objCommand.Parameters.AddWithValue("@agentId", AgentId);

            DBConnect objDB = new DBConnect();
            DataSet myDataSet;
            myDataSet = objDB.GetDataSet(objCommand);
        }


        public void UpdateHouse(string address, string amentities, string state, decimal price, string city, string garage,
         string description, int homesize, string houseImages, int year, int bathroom, int bedroom, string proptype, string utils, int HouseId)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_UpdateHouses";


            
            objCommand.Parameters.AddWithValue("@theAddress", address);
            objCommand.Parameters.AddWithValue("@theAmentities", amentities);
            objCommand.Parameters.AddWithValue("@theState", state);
            objCommand.Parameters.AddWithValue("@thePrice", price);
            objCommand.Parameters.AddWithValue("@theCity", city);
            objCommand.Parameters.AddWithValue("@theGarage", garage);
            objCommand.Parameters.AddWithValue("@theHomeDescription", description);
            objCommand.Parameters.AddWithValue("@theHomeSize", homesize);
            objCommand.Parameters.AddWithValue("@theHouseImages", houseImages);
            objCommand.Parameters.AddWithValue("@theHouseYear", year);
            objCommand.Parameters.AddWithValue("@theNumOfBathroom", bathroom);
            objCommand.Parameters.AddWithValue("@theNumOfBedrooms", bedroom);
            objCommand.Parameters.AddWithValue("@thePropertyType", proptype);
            objCommand.Parameters.AddWithValue("@theUtilities", utils);
            objCommand.Parameters.AddWithValue("@theHouseID", HouseId);





            DBConnect objDB = new DBConnect();
            DataSet myDataSet;
            myDataSet = objDB.GetDataSet(objCommand);


        }

        public void UpdateHouseStatus(string status, int HouseId)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_UpdateHouseStatus";



            objCommand.Parameters.AddWithValue("@theHouseStatus", status);
            objCommand.Parameters.AddWithValue("@theHouseID", HouseId);





            DBConnect objDB = new DBConnect();
            DataSet myDataSet;
            myDataSet = objDB.GetDataSet(objCommand);


        }
    }
}
