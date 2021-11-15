using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_Final
{
    public partial class vaccinated_student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Register_Click(object sender, EventArgs e)
        {
            if (Name.Text == "")
            {
                Label7.Visible = true;
                Label7.Text = "Please enter Name";
            }
            else if (RegID.Text == "")
            {
                Label7.Visible = true;
                Label7.Text = "Please enter Registration ID";
            }
            else if (DOV.Text == "" || DOV.Text == null)
            {
                Label7.Visible = true;
                Label7.Text = "Please choose Date of Vaccination";
            }
            else if (UsedVaccination.Text == "")
            {
                Label7.Visible = true;
                Label7.Text = "Please enter used vaccine";
            }
            else if (NoOfDosadge.Text == "")
            {
                Label7.Visible = true;
                Label7.Text = "Please enter number of dosage";
            }
            else
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into StudentVaccination values (@Name, @RegID, @DateofVaccination, @NumberofDosages, @VaccineUsed)", con);
                cmd.Parameters.AddWithValue("Name", Name.Text);
                cmd.Parameters.AddWithValue("RegID", RegID.Text);
                cmd.Parameters.AddWithValue("DateofVaccination", DOV.Text);
                cmd.Parameters.AddWithValue("VaccineUsed", UsedVaccination.Text);
                cmd.Parameters.AddWithValue("NumberofDosages", NoOfDosadge.Text);
                int isSaved = cmd.ExecuteNonQuery();
                if (isSaved == 0)
                {
                    Label7.Visible = true;
                    Label7.Text = "Vaccination not Saved";
                }
                else
                {
                    Label7.Visible = false;
                    lblSuccess.Visible = true;
                    lblSuccess.Text = "Vaccination Saved successfully";
                    Name.Text = "";
                    RegID.Text = "";
                    DOV.Text = "";
                    UsedVaccination.Text = "";
                    NoOfDosadge.Text = "";
                    Name.Focus();
                    getRecord();

                }
            }




        }
        public void getRecord()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            con.Open();
            string sql = "SELECT Id,RegID,DateofVaccination,VaccineUsed,NumberofDosages from StudentVaccination";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }
    }
}