--SELECT Nome, Sobrenome, Email FROM Clientes
--ORDER BY Nome

--INSERT INTO Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
--Values('João', 'Victor', 'email@gmail.com', 1, GETDATE())

SELECT * FROM Clientes

--BEGIN TRAN
--ROLLBACK

--UPDATE Clientes
--SET Email = 'emailatualizado@email.com',
--	AceitaComunicados = 0,
--	Sobrenome = 'Victor'

BEGIN TRAN
ROLLBACK

DELETE Clientes
WHERE Id= 6

