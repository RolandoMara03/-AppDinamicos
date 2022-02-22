CREATE DATABASE CV

RESTORE DATABASE CV
FROM DISK= 'D:\Rolando\CV.bak' with replace

USE CV
GO

sp_addlogin 'Rolando','facil123','CV'
sp_addsrvrolemember 'Rolando',sysadmin
sp_adduser 'Rolando','Rolando'
sp_addrolemember 'db_ddladmin','Rolando'

select* from Productos

CREATE PROCEDURE ADDPRODUCTO
@CodP char(5),@Nombre nvarchar(25),@precio float,@exist int,@desc nvarchar(35),
@idprov char(5)
as
DECLARE
@codprod2 as char(5) 
set @codprod2 =(select CodProd from Productos where  CodProd = @CodP)
DECLARE
@idProv2 as char(5) 
set @idProv2 =(select Id_Prov from Proveedor where  Id_Prov = @idprov)
DECLARE
@union as char(5) 
set @union =(select CodProd from Productos where  Id_Prov = @idprov and CodProd =@CodP)
if(@cod)
