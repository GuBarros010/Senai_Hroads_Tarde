USE HROADS;
GO

INSERT INTO Classe (nomeClasse)
VALUES ('Bárbaro'),
       ('Cruzado'),
	   ('Caçadora de Demônios'),
	   ('Monge'),
	   ('Necromante'),
	   ('Feitiçeiro'),
	   ('Arcanista')
GO

INSERT INTO TipoHabilidade(nomeTipo)
VALUES ('Ataque'),
       ('Defesa'),
	   ('Cura'),
	   ('Magia')
GO

INSERT INTO Habilidade(idTipoHabilidade, nomeHabilidade)
VALUES (1, 'Lança Mortal'),
       (2, 'Escudo Supremo'),
	   (3, 'Recuperar Vida')
GO

INSERT INTO ClassesHabilidades(idHabilidade, idClasse)
VALUES (1,1),
       (1,3),
	   (2,1),
	   (2,4),
	   (2,2),
	   (3,4),
	   (3,6)
GO

INSERT INTO Personagem(nomePersonagem, idClasse, Vida, Mana, dataCriacao, dataAtualizacao)
VALUES ('DeuBug', 1, 100, 80, '17/03/2016', '10/08/2021'),
       ('BitBug', 4, 70, 100, '17/03/2016', '10/08/2021'),
	   ('Fer8', 7, 75, 60, '17/03/2016', '10/08/2021')
GO


--Tarefa 4: Atualizar o nome do personagem Fer8 para Fer7;
UPDATE Personagem SET nomePersonagem = 'Fer7'
WHERE idPersonagem = 3


--Tarefa 5: Atualizar o nome Necromante para Necromancer;
UPDATE Classe SET nomeClasse = 'Necromancer'
WHERE idClasse = 5