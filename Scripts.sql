CREATE TABLE PRODUTO(
ID            UNIQUEIDENTIFIER           PRIMARY KEY,
NOME          VARCHAR(50)                NOT NULL,
DESCRICAO     VARCHAR(255)               NOT NULL,
PRECO         DECIMAL(10, 2)             NOT NULL,
QUANTIDADE    INT                        NOT NULL,
DATACADASTRO  DATETIME                   NOT NULL,
ATIVO         BIT                        NOT NULL 
);
--CADASTRANDO PRODUTOS
INSERT INTO PRODUTO 
(ID, NOME, DESCRICAO, PRECO, QUANTIDADE, DATACADASTRO, ATIVO) 
VALUES
(NEWID(),'Notebook hp','core i7 8GB SSD',4599.99,10,GETDATE(),1),
(NEWID(),'Mouse gamer','Mouse com 6 botões e iluminação RGB',99.99,25,GETDATE(),1),
(NEWID(),'Teclado mecânico','Teclado com switches azuis e iluminação RGB',199.99,15,GETDATE(),1),
(NEWID(),'Monitor 24 polegadas','Monitor Full HD com tempo de resposta de 1ms',3999.99,30,GETDATE(),1),
(NEWID(),'Headset gamer','Headset com microfone e som surround 7.1',3599.99,20,GETDATE(),1);
go

--CONSULTANDO PRODUTOS
SELECT
ID,NOME,DESCRICAO,PRECO,QUANTIDADE,DATACADASTRO,ATIVO
FROM PRODUTO
WHERE ATIVO = 1
ORDER BY NOME;



