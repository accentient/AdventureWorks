USE Master
GO

IF DB_ID('AdventureWorks') IS NULL
  CREATE DATABASE [AdventureWorks] ON 
  ( FILENAME = N'C:\inetpub\wwwroot\App_Data\AdventureWorks_Data.mdf' ),
  ( FILENAME = N'C:\inetpub\wwwroot\App_Data\AdventureWorks_Data_log.ldf' )
  FOR ATTACH
GO

ALTER DATABASE [AdventureWorks] SET READ_WRITE
GO

USE MASTER
GO

IF NOT EXISTS (SELECT name FROM sys.server_principals WHERE name = 'IIS APPPOOL\DefaultAppPool')
BEGIN
    CREATE LOGIN [IIS APPPOOL\DefaultAppPool] 
      FROM WINDOWS WITH DEFAULT_DATABASE=[master]    
END
GO

USE [AdventureWorks]
GO

CREATE USER [DefaultAppPool] 
  FOR LOGIN [IIS APPPOOL\DefaultAppPool]
GO
EXEC sp_addrolemember 'db_owner', 'DefaultAppPool'
GO