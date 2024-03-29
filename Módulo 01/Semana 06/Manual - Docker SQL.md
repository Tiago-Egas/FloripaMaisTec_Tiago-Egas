# Manual Docker de SQL Express e conectar no VSCode

## Pré-requistos

1. Docker
2. MsSqlCmdLnutils.msi (v15)
3. msodbc.msi (17)

## Criação do ambiente

Identificar versão do Docker: 

> docker --version

Baixar imagem da última versão do SQL Server 2022 alterar o "2022-latest" para "2019" para baixar o SQL Express: 

> docker pull mcr.microsoft.com/mssql/server:2022-latest

Criar container a partir da imagem baixada 
Pode alterar "sqlserver" para o nome que preferir alterar "Senh@Sup3RseguR@" para sua senha de preferência: 

> docker run -v ~/docker --name sqlserver --hostname sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Senh@Sup3RseguR@" -p 1433:1433 -d mcr.microsoft.com/mssql/server

--- 

## Comunicação básica com o SQL Server

Inicia container com bash: 

> docker exec -it sqlserver "bash"

Inicia SQLCMD com usuário especificado e pede senha: 

> /opt/mssql-tools/bin/sqlcmd -S localhost -U SA

---

## Como alterar a senha do user sa?

Conectar com o SQLCMD: 

> docker exec -it sqlserver "bash"

> /opt/mssql-tools/bin/sqlcmd -S .\MSSQLINSTANCE -E

Informar a nova senha em "newpassword" no comando abaixo e digitar 

> sp_password @new = 'newpassword', @loginame = 'sa'
> GO
> EXIT

Caso tenha errado várias vezes a senha então precisa desbloquear o login com: 

> ALTER LOGIN sa WITH PASSWORD = 'newpassword' UNLOCK
> GO
> EXIT

---

## Testes com o novo ambiente SQL Server

Criar banco de dados e mostra todos do BD existentes: 

>  CREATE DATABASE TestDB;
>  SELECT Name from sys.databases;
>  GO

Informa qual BD a ser usado, cria tabelas e insere dados nas tabelas: 

> USE TestDB;

> CREATE TABLE Inventory (id INT, name NVARCHAR(50), quantity INT);

> INSERT INTO Inventory VALUES (1, 'banana', 150); INSERT INTO Inventory VALUES (2, 'orange', 154);

> GO

Busca por resultados: 

> SELECT * FROM Inventory WHERE quantity > 152;
> GO

Sair do SQLCMD: 

> exit

Sair do bash Docker: 

> exit

Parar container Docker: 

> docker stop sqlserver

Remover o container: 

> docker rm sqlserver

---

## Validar informações do container: 

> docker inspect --format='{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' sqlserver

## Conectar SQLCMD por fora do container: 

> sqlcmd -S <ip_address>,1433 -U SA -P "Senh@Sup3RseguR@"

## Por VSCode: 

> localhost,1433

ou

> host.docker.internal,1433

---