CREATE DATABASE IF NOT EXISTS avions;

CREATE TABLE avions
(av INT NOT NULL UNIQUE PRIMARY KEY,
marque CHAR(10) NOT NULL,
`type` CHAR(10) NOT NULL,
capacite INT NOT NULL,
localisation CHAR(10)NOT NULL);

INSERT INTO avions
(av, marque, `type`, capacite, localisation)
VALUES
(100, "AIRBUS", "A320", 300, "Nice"),
(101, "Boeing", "B707", 250, "Paris"),
(102, "Airbus", "A320", 300, "Toulouse"),
(103, "Caravelle", "Caravelle", 200, "Toulouse"),
(104, "Boeing", "B747", 400, "Paris"),
(105, "AIRBUS", "A320", 300, "Grenoble"),
(106, "ATR", "ATR42", 50, "Paris"),
(107, "BOEING", "B727", 300, "Lyon"),
(108, "BOEING", "B727", 300, "Nantes"),
(109, "AIRBUS", "A340", 350, "Bastia");

CREATE TABLE pilotes
(PIL INT AUTO_INCREMENT PRIMARY KEY,
nom CHAR(60) NOT NULL,
adresse CHAR(255) NOT NULL);

INSERT INTO pilotes
(PIL, nom, adresse)
VALUES
(1, "SERGE", "Nice"),
(2, "JEAN", "Paris"),
(3, "CLAUDE", "Grenoble"),
(4, "ROBERT", "Nantes"),
(5, "SIMON", "Paris"),
(6, "LUCIEN", "Toulouse"),
(7, "BERTRAND", "Lyon"),
(8, "HERVE", "Bastia"),
(9, "LUC", "Paris");

CREATE TABLE vol
(VOL CHAR(10) NOT NULL PRIMARY KEY,
avion INT NOT NULL,
pilote INT NOT NULL,
ville_depart CHAR(50) NOT NULL,
ville_arrivee CHAR(50) NOT NULL,
heure_depart INT NOT NULL,
heure_arrivee INT NOT NULL);

INSERT INTO vol
(VOL, avion, pilote, ville_depart, ville_arrivee, heure_depart, heure_arrivee)
VALUES
("IT100", 100, 1, "NICE", "PARIS", 7, 9),
("IT101", 100, 2, "PARIS", "TOULOUSE", 11, 12),
("IT102", 101, 1, "PARIS", "NICE", 12, 14),
("IT103", 105, 3, "GRENOBLE", "TOULOUSE", 9, 11),
("IT104", 105, 3, "TOULOUSE", "GRENOBLE", 17, 19),
("IT105", 107, 7, "LYON", "PARIS", 6, 7),
("IT106", 109, 8, "BASTIA", "PARIS", 10, 13),
("IT107", 106, 9, "PARIS", "BRIVE", 7, 8),
("IT108", 106, 9, "BRIVE", "PARIS", 19, 20),
("IT109", 107, 7, "PARIS", "LYON", 18, 19),
("IT110", 102, 2, "TOULOUSE", "PARIS", 15, 16),
("IT111", 101, 4, "NICE", "NANTES", 17, 19),
("IT112", 103, 5, "PARIS", "NICE", 11, 13),
("IT113", 104, 6, "NICE", "PARIS", 13, 15);

/* 1. Quels sont les vols au départ de Paris entre 12h et 14h */
SELECT VOL, heure_depart FROM vol WHERE ville_depart = "PARIS" AND heure_depart BETWEEN 12 AND 14; 

/* 2. Quels sont les pilotes dont le nom commence par "S" */
SELECT nom FROM pilotes WHERE nom LIKE 'S%';

/* 3. Pour chaque ville, donner le nombre et les capacités minimum et maximum des avions qui s'y trouvent */
SELECT localisation, 
COUNT(*) AS nb_avions,
MIN(capacite) AS capacite_min,
MAX(capacite) AS capacite_max 
FROM avions
GROUP BY localisation;

/* 4. Pour chaque ville, donner la capacité moyenne des avions qui s'y trouvent et 
cela par type d'avion. */
SELECT localisation, 
AVG(capacite) AS capacite_moyenne
FROM avions
GROUP BY `type`;

/* 5. Quelle est la capacité moyenne des avions pour chaque ville ayant plus de 1 
avion ? */
SELECT localisation,
AVG(capacite) AS capacite_moyenne
FROM avions
GROUP BY localisation 
HAVING COUNT(*) > 1;

/* 6. Quels sont les noms des pilotes qui habitent dans la ville de localisation d'un 
Airbus */
SELECT pilotes.nom,
pilotes.adresse,
avions.localisation
FROM pilotes
JOIN avions
WHERE pilotes.adresse = avions.localisation AND marque="airbus";

/* 7.  Quels sont les noms des pilotes qui conduisent un Airbus et qui habitent dans 
la ville de localisation d'un Airbus ? */
SELECT DISTINCT p.nom, p.PIL, v.avion, a.marque
FROM pilotes p
JOIN vol v ON p.PIL = v.pilote
JOIN avions a ON v.avion = a.av
WHERE UPPER(a.marque) = 'AIRBUS'
AND p.adresse = a.localisation;

/* 8. Quels sont les noms des pilotes qui conduisent un Airbus ou qui habitent dans 
la ville de localisation d'un Airbus */
SELECT nom, adresse
FROM pilotes
JOIN avions
WHERE avions.localisation = pilotes.adresse AND avions.marque = "Airbus";

/* 9. Quels sont les noms des pilotes qui conduisent un Airbus sauf ceux qui 
habitent dans la ville de localisation d'un Airbus ? */
SELECT nom
FROM pilotes
JOIN avions ON pilotes.av = avions.av
WHERE  avions.marque = "Airbus"
AND pilotes.adresse 
NOT IN (SELECT localisation FROM avions WHERE marque ="Airbus");

/* 10.  Quels sont les vols ayant un trajet identique ( VD, VA ) à ceux assurés par 
Serge ? */


/* 11. Donner toutes les paires de pilotes habitant la même ville ( sans doublon ). */
SELECT nom, COUNT(*)
FROM pilotes
WHERE 

/* 12. Quels sont les noms des pilotes qui conduisent un avion que conduit aussi le 
pilote n°1 ? */


/* 13. Donner toutes les paires de villes telles qu'un avion localisé dans la ville de 
départ soit conduit par un pilote résidant dans la ville d'arrivée */


/* 14.  Sélectionner les numéros des pilotes qui conduisent tous les Airbus ? */