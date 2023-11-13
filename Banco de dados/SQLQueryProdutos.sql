--SELECT COUNT(*) FROM Produtos WHERE Tamanho = 'M'   contando os itens baseado no where
--SELECT COUNT(*) FROM Produtos  contando todos os itens

--SELECT SUM(Preco) PrecoTotal FROM Produtos WHERE Tamanho = 'M' SOMANDO TODOS OS VALORES QUE CONDIZEM COM O FILTRO
--SELECT SUM(Preco) PrecoTotal FROM Produtos SOMANDO TODOS OS VALORES DA COLUNA PRECO 

--SELECT MAX(Preco) ProdutoMaisCaro FROM Produtos
--SELECT MAX(Preco) ProdutoMaisCaro FROM Produtos WHERE Cor = 'Branco'    OBTENDO O MAIOR VALOR DA COLUNA
--SELECT MIN(Preco) ProdutoMaisBarato FROM Produtos
--SELECT MIN(Preco) ProdutoMaisBarato FROM Produtos WHERE Cor = 'Branco' OBTENDO O MENOR VALOR DA COLUNA
--SELECT AVG(Preco) MediaProdutos FROM Produtos 
--SELECT AVG(Preco) MediaProdutos FROM Produtos WHERE Cor = 'Branco'   OBTENDO A MEDIA

--SELECT Nome + ' - ' + Cor ColunaFiltrada FROM Produtos CRIACAO DE UMA COLUNA NOVA PARA FILTRAR CARACTERISTICAS

--SELECT UPPER(Nome) Nome, LOWER(Cor) Cor FROM Produtos  MANIPULAÇÃO DE CASES

SELECT * FROM Produtos
--ALTER TABLE Produtos
--ADD DataCadastro DATETIME2     CRIANDO UMA TABELA NOVA

--UPDATE Produtos SET DataCadastro = GETDATE()     ADICIONANDO CONTEÚDO DE DATA NESTA TABELA

Select FORMAT(DataCadastro, 'dd/MM/yyyy HH:mm') FROM Produtos

SELECT Tamanho, COUNT(*) Quantidade FROM Produtos WHERE Tamanho <> '' GROUP BY Tamanho ORDER BY Quantidade DESC



