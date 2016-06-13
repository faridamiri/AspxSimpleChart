# Aspx Simple Charting 
make a simple chart in Asp is so easy 
##this is a sample charting in aspx 

###1-Create A database (in this Example CountryByGdp) in SQL SERVER
###2- crerate a table for example as below:

`CREATE TABLE [dbo].[cgdp] `

`(    [Id]      INT          IDENTITY (1, 1) NOT NULL`
    
`   [country] VARCHAR (50) NOT NULL,`
    
`   [code]    VARCHAR (3)  NULL,`
    
`   [gdp]     INT          DEFAULT ((0)) NOT NULL,`
    
`   PRIMARY KEY CLUSTERED ([Id] ASC));`

###3. in the web.config edit data source:
 
`<connectionStrings \>`
 
`   <add name="countryByGdpConnectionString" connectionString="Data Source=(localdb)\ProjectsV13;Initial Catalog=countryByGdp;Integrated Security=True"       providerName="System.Data.SqlClient" />`
 
`</connectionStrings \>`

  
