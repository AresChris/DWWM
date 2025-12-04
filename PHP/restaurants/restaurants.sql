CREATE DATABASE if not exists guide;

CREATE TABLE if not exists restaurants
(Id INT AUTO_INCREMENT PRIMARY KEY,
Nom TEXT NOT NULL,
Adresse TEXT NOT NULL,
Prix DECIMAL(10, 2),
Commentaire TEXT,
Note DOUBLE,
Visite DATE);

DROP TABLE if EXISTS restaurants;

INSERT INTO restaurants (Nom, Adresse, Prix, Commentaire, Note, Visite)
VALUES
('Jean_Yves SCHILLINGER', '17 Rue de la Poissonnerie, 68000 Colmar', 50,
'Le JY\'S est un restaurant différent des autres avec un décor cosy et résolument contemporain qui attire une 
très belle clientèle cosmopolite. Jean-Yves Schillinger est un chef doublement étoilé créatif qui vous entraînera 
dans une ronde dépaysante à souhait où la cuisine du monde est à l\'honneurLe chef décline la cuisine fusion à 
sa façon. Une carte régulièrement renouvelée s\'égaye de créations audacieuses et de plats revisités avec 
modernité et pertinence',
9, '2019-05-12');

INSERT INTO restaurants (Nom, Adresse, Prix, Commentaire, Note, Visite)
VALUES
('L\'ADRIATICO', '6 route de Neuf Brisach\, 68000\, Colmar',
25,
'Une des meilleurs pizzéria de la région Service très agréable, efficace et souriant Salle principale un peu 
bruyante mais cela donne un côté italien je recommande',
8, '2020-02-04');

INSERT INTO restaurants (Nom, Adresse, Prix, Commentaire, Note, Visite)
VALUES
('Le Petit Gourmet', '12 Rue des Tanneurs, 68000 Colmar',
32,
'Cuisine traditionnelle revisitée avec finesse. Plats généreux et élégants. Service impeccable.',
9, '2021-03-18'),
('La Table de Louise', '5 Rue Vauban, 68000 Colmar',
45,
'Cadre chaleureux et cuisine authentique. Les desserts sont particulièrement excellents.',
8.5, '2022-07-09'),
('Bistrot du Marché', '21 Place de la Cathédrale, 68000 Colmar',
18,
'Bistrot convivial avec une carte simple mais efficace. Très bon rapport qualité-prix.',
7.5, '2019-10-22'),
('Chez Auguste', '3 Rue des Écoles, 68000 Colmar',
28,
'Cuisine maison savoureuse. Mention spéciale au risotto. Service un peu lent mais sympathique.',
7.8, '2023-01-14'),
('L\'Épicurien', '15 Avenue de la République, 68000 Colmar',
60,
'Restaurant gastronomique d\'excellente qualité. Présentation magnifique et saveurs subtiles.',
9.3, '2021-11-05'),
('La Flamme', '2 Boulevard du Champ de Mars, 68000 Colmar',
20,
'Flammekueche traditionnelle réussie. Ambiance simple et conviviale. Prix abordables.',
8.2, '2020-08-27'),
('Sushi Sakura', '10 Rue des Jardins, 68000 Colmar',
26,
'Sushis très frais, grande variété de makis. Service rapide et agréable.',
8.7, '2024-02-11'),
('Le Plaisir du Pain', '1 Rue de la Gare, 68000 Colmar',
12,
'Petite boulangerie café très cosy. Sandwichs et pâtisseries délicieux. Idéal pour le déjeuner.',
7.9, '2023-09-03'),
('Brasserie du Musée', '8 Rue du Musée Bartholdi, 68000 Colmar',
22,
'Brasserie typiquement alsacienne. Choucroute excellente et service efficace.',
8.1, '2022-05-29');
DELIMITER |
CREATE PROCEDURE afficherListeNote (IN p_limite DOUBLE)
BEGIN
SELECT nom, adresse, prix, commentaire, note, visite AS "Date de visite"
FROM restaurants
WHERE note >= p_limite;
END |
DELIMITER ;

DELIMITER |
CREATE PROCEDURE prix_moyen (IN p_prixMoyen DOUBLE)
BEGIN
SELECT nom, adresse, prix, commentaire, note, visite AS "Date de visite"
FROM restaurants
WHERE prix = AVG(prix);
END |
DELIMITER ;

DELIMITER |
CREATE PROCEDURE afficherListePrix (IN prix_limite_inf DOUBLE, IN prix_limite_sup DOUBLE)
BEGIN
SELECT nom, adresse, prix, commentaire, note, visite AS "Date de visite"
FROM
restaurants
WHERE prix BETWEEN prix_limite_inf AND prix_limite_sup;
END |
DELIMITER ;

SET @varInf:=30;
SET @varMax:=50;

CALL afficherListePrix(@varInf, @varMax);
