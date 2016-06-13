<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          <h2>Chart by VS wizard from database</h2>
        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSourceCountryByGdp" Height="346px" Width="439px">
            <series>
                <asp:Series Name="Series1" XValueMember="code" YValueMembers="gdp">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <asp:SqlDataSource ID="SqlDataSourceCountryByGdp" runat="server" ConnectionString="<%$ ConnectionStrings:countryByGdpConnectionString %>" SelectCommand="SELECT [code], [gdp] FROM [cgdp]"></asp:SqlDataSource>
    </div>

    <div>
        <h2 style="color: black;"> chart by code  from database</h2>  
        <asp:Chart ID="Chart2" runat="server" BackColor="0, 0, 64" BackGradientStyle="LeftRight"  
            BorderlineWidth="0" Height="360px" Palette="None" PaletteCustomColors="Maroon"  
            Width="460px" BorderlineColor="64, 0, 64">  
            <Titles>  
                <asp:Title ShadowOffset="10" Name="Items" />  
            </Titles>  
            <Legends>  
                <asp:Legend Alignment="Center" Docking="Bottom" IsTextAutoFit="False" Name="Default"  
                    LegendStyle="Row" />  
            </Legends>  
            <Series>  
                <asp:Series Name="Default" />  
            </Series>  
            <ChartAreas>  
                <asp:ChartArea Name="ChartArea2" BorderWidth="0" />  
            </ChartAreas>  
        </asp:Chart>  



    </div>
    
    
    </form>
</body>
</html>


