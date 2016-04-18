using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class singleTableInheritance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        sampleDataContext dbContext = new sampleDataContext();
        dbContext.Log = Response.Output;

        switch (RadioButtonList1.SelectedValue)
        {
            case "permanent":
               GridView1.DataSource= dbContext.Employees.OfType<PermanentEmployee>().ToList();
                GridView1.DataBind();
                break;
            case "contract":
                GridView1.DataSource = dbContext.Employees.OfType<ContractEmployee>().ToList();
                GridView1.DataBind();
                break;

            default:
                GridView1.DataSource = dbContext.Employees.ToList();
                GridView1.DataBind();
                break;
                
        }
    }

    private DataTable ConvertEmployeeForDisplay(List<Employee> employees)
    {
     DataTable dt = new DataTable();
        dt.Columns.Add("ID");
        dt.Columns.Add("Name");
        dt.Columns.Add("Gender");
        dt.Columns.Add("Anuual Salary");
        dt.Columns.Add("Hourly Worked");
        dt.Columns.Add("Hourly Pay");

        return dt;
    }
}