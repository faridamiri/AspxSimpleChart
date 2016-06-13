# AspxSimpleChart

this is a sample of charting in aspx

Create A database (in this Example CountryByGdp)
and crerate a table for example

CREATE TABLE [dbo].[cgdp] 

(
    [Id]      INT          IDENTITY (1, 1) NOT NULL
    
    [country] VARCHAR (50) NOT NULL,
    
    [code]    VARCHAR (3)  NULL,
    
    [gdp]     INT          DEFAULT ((0)) NOT NULL,
    
    PRIMARY KEY CLUSTERED ([Id] ASC)
    
);

then in web.config edit data source:
 
\<connectionStrings \>
 
    <add name="countryByGdpConnectionString" connectionString="Data Source=(localdb)\ProjectsV13;Initial Catalog=countryByGdp;Integrated Security=True"
 
      providerName="System.Data.SqlClient" />
 
  \</connectionStrings \>

  
