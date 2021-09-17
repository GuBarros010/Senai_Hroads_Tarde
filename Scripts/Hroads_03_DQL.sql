USE HROADS;
GO

--Classes
--Tarefa 7: Selecionar todas as classes;
SELECT * FROM Classe


--Tipo de Hbilidades
SELECT * FROM TipoHabilidade


--Habilidades
SELECT * FROM Habilidade


--Tabela interligada: Habilidades/Classes
SELECT * FROM ClassesHabilidades


--Personagens
--Tarefa 6: Selecionar todos os personagens;
SELECT * FROM Personagem


--Tarefas

--Tarefa 6: Selecionar todos os personagens;
SELECT nomePersonagem
FROM Personagem

--Tarefa 7: Selecionar todas as classes;
--Tarefa 8: Selecionar somente o nome das classes;
SELECT nomeClasse
FROM Classe

--Tarefa 9: Selecionar todas as habilidades;
SELECT nomeHabilidade
FROM Habilidade

--Tarefa 10: Realizar contagem de quantas habilidades estão cadastradas;
SELECT COUNT(idHabilidade) FROM Habilidade;

--Tarefa 11: Selecionar somente os id's das habilidades classificando-os por ordem crescente;
SELECT idHabilidade FROM Habilidade
ORDER BY idHabilidade;

--Tarefa 12: Selecionar todos os tipos de habilidades;
SELECT * FROM TipoHabilidade

--Tarefa 13: Selecionar todas as habilidades e a quais tipos de habilidades elas fazem parte;
SELECT nomeHabilidade Habilidade, nomeHabilidade  FROM Habilidade H
LEFT JOIN TipoHabilidade TH
ON H.idTipoHabilidade = TH.idTipoHabilidade

--Tarefa 14: Selecionar todos os personagens e suas respectivas classes;
SELECT nomePersonagem Personagem, nomeClasse Classe FROM Personagem P
LEFT JOIN Classe C
ON P.idClasse = C.idClasse

--Tarefa 15: Selecionar todos os personagens e as classes (mesmo que elas não tenham correspondencia em personagens);
SELECT nomePersonagem Personagem, nomeClasse Classe FROM Personagem P
RIGHT JOIN Classe C
ON P.idClasse = C.idClasse

--Tarefa 16: Selecionar todas as classes e suas respectivas habilidades;
SELECT nomeClasse Classe, nomeHabilidade Habilidade FROM Classe C
LEFT JOIN ClassesHabilidades CH
ON C.idClasse = CH.idClasse
LEFT JOIN Habilidade H
ON CH.idHabilidade = H.idHabilidade

--Tarefa 17: Selecionar todas as habilidades e suas classes (somente as que possuem correspondência);
SELECT nomeHabilidade Habilidade, nomeClasse Classe FROM Classe C
LEFT JOIN ClassesHabilidades CH
ON C.idClasse = CH.idClasse
INNER JOIN Habilidade H
ON CH.idHabilidade = H.idHabilidade

--Tarefa 18: Selecionar todas as habilidades e suas classes (mesmo que elas não tenham correspondência).
SELECT nomeHabilidade Habilidade, nomeClasse Classe FROM Classe C
FULL OUTER JOIN ClassesHabilidades CH
ON C.idClasse = CH.idClasse
FULL OUTER JOIN HABILIDADE H
ON CH.idHabilidade = H.idHabilidade
