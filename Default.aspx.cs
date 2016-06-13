using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    private SqlConnection sqlConn;
    private SqlCommand sqlComm;
    private string connString;
    private void connectionfunction()
    {
        connString = ConfigurationManager.ConnectionStrings["countryByGdpConnectionString"].ToString();
        sqlConn = new SqlConnection(connString);
        sqlConn.Open();

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bindchart();
            //Enabled 3D  
           Chart2.ChartAreas["ChartArea2"].Area3DStyle.Enable3D = true;

        }
    }


    private void Bindchart()
    {
        connectionfunction();
        sqlComm = new SqlCommand("getGdp", sqlConn);
        sqlComm.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(sqlComm);
        DataSet ds = new DataSet();
        da.Fill(ds);

        DataTable ChartData = ds.Tables[0];

        //storing total rows count to loop on each Record  
        string[] XPointMember = new string[ChartData.Rows.Count];
        int[] YPointMember = new int[ChartData.Rows.Count];

        for (int count = 0; count < ChartData.Rows.Count; count++)
        {
            //storing Values for X axis  
            XPointMember[count] = ChartData.Rows[count]["code"].ToString();
            //storing values for Y Axis  
            YPointMember[count] = Convert.ToInt32(ChartData.Rows[count]["gdp"]);

        }
        //binding chart control  
        Chart2.Series[0].Points.DataBindXY(XPointMember, YPointMember);

        //Setting width of line  
        Chart2.Series[0].BorderWidth = 10;
        //setting Chart type   
        Chart2.Series[0].ChartType = SeriesChartType.Pie;

        KnownColor[] valuescolor = (KnownColor[])Enum.GetValues(typeof(KnownColor));
        int kc = 1;
        foreach (Series charts in Chart2.Series)
        {
            foreach (DataPoint point in charts.Points)
            {
                
                    point.Color = Color.FromKnownColor(valuescolor[kc]); ;
                      kc = kc + 1;              
                    point.Label = string.Format("{0:0} - {1}", point.YValues[0], point.AxisLabel);

            }
        }


         
        sqlConn.Close();

    }
}
