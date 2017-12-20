USE Master
GO

IF DB_ID('AdventureWorks') IS NULL
  CREATE DATABASE [AdventureWorks] ON 
  ( FILENAME = N'C:\inetpub\wwwroot\AdventureWorksMVC_deploy\App_Data\AdventureWorks_Data.mdf' ),
  ( FILENAME = N'C:\inetpub\wwwroot\AdventureWorksMVC_deploy\App_Data\AdventureWorks_Data_log.ldf' )
  FOR ATTACH
GO
