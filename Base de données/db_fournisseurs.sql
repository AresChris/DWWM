DROP TABLE IF EXISTS ligne_bon_de_livraison;
DROP TABLE IF EXISTS articles;
DROP TABLE IF EXISTS employe;
DROP TABLE IF EXISTS rayon;
DROP TABLE IF EXISTS fournisseurs;

CREATE TABLE fournisseurs(
   codeF CHAR(6),
   nomF VARCHAR(50) NOT NULL,
   adresse VARCHAR(50) NOT NULL,
   PRIMARY KEY(codeF)
);

CREATE TABLE rayon(
   nomR VARCHAR(50),
   etage INT NOT NULL,
   PRIMARY KEY(nomR)
);

CREATE TABLE employe(
   codeEmpl INT,
   nom VARCHAR(50) NOT NULL,
   salaire INT NOT NULL,
   nomR VARCHAR(50) NOT NULL,
   codeSupHierarchique INT NOT NULL,
   PRIMARY KEY(codeEmpl),
   FOREIGN KEY(nomR) REFERENCES rayon(nomR),
   FOREIGN KEY(codeSupHierarchique) REFERENCES employe(codeEmpl)
);

CREATE TABLE articles(
   codeA CHAR(8),
   nomA VARCHAR(255) NOT NULL,
   type VARCHAR(50),
   nomR VARCHAR(50) NOT NULL,
   prix INT(10),
   PRIMARY KEY(codeA),
   FOREIGN KEY(nomR) REFERENCES rayon(nomR)
);

CREATE TABLE ligne_bon_de_livraison(
   codeF CHAR(6),
   codeA CHAR(8),
   quantité VARCHAR(50),
   PRIMARY KEY(codeF, codeA),
   FOREIGN KEY(codeF) REFERENCES fournisseurs(codeF),
   FOREIGN KEY(codeA) REFERENCES articles(codeA)
);


-- Insertion des fournisseurs
INSERT INTO fournisseurs VALUES
('FABCDE', 'Alpha', '12 rue des Lilas'),
('FABCFG', 'Beta', '34 avenue des Roses'),
('FBCDEF', 'Gamma', '56 boulevard des Pins'),
('FCDEFG', 'Delta', '78 impasse des Tulipes'),
('FDEFGH', 'Epsilon', '90 place des Marguerites');

-- Insertion des rayons
INSERT INTO rayon VALUES
('Electroménager', 1),
('Jouets', 2),
('Vêtements', 1),
('Alimentation', 0),
('Bricolage', 2);

-- Insertion des employés
INSERT INTO employe VALUES
(1, 'Martin', 2000, 'Electroménager', 1),
(2, 'Durand', 1800, 'Jouets', 1),
(3, 'Lefevre', 1700, 'Vêtements', 1),
(4, 'Bernard', 1600, 'Alimentation', 1),
(5, 'Dubois', 1850, 'Bricolage', 1);

-- Insertion des articles
INSERT INTO articles VALUES
('A0000001', 'Aspirateur', 'Electroménager', 'Electroménager', 50),
('A0000002', 'Poupée', 'Jouet', 'Jouets', 17),
('A0000003', 'T-shirt', 'Vêtement', 'Vêtements', 25),
('A0000004', 'Pain', 'Aliment', 'Alimentation', 1),
('A0000005', 'Marteau', 'Outil', 'Bricolage', 8),
('A0000006', 'Réfrigérateur', 'Electroménager', 'Electroménager', 150),
('A0000007', 'Voiture télécommandée', 'Jouet', 'Jouets', 75),
('A0000008', 'Jean', 'Vêtement', 'Vêtements', 70),
('A0000009', 'Lait', 'Aliment', 'Alimentation', 2),
('A0000010', 'Tournevis', 'Outil', 'Bricolage', 6);


-- Insertion des lignes de bon de livraison
INSERT INTO ligne_bon_de_livraison VALUES
('FABCDE', 'A0000001', '10'),
('FABCFG', 'A0000002', '20'),
('FBCDEF', 'A0000003', '15'),
('FCDEFG', 'A0000004', '50'),
('FDEFGH', 'A0000005', '5'),
('FABCDE', 'A0000006', '8'),
('FABCFG', 'A0000007', '12'),
('FBCDEF', 'A0000008', '18'),
('FCDEFG', 'A0000009', '30'),
('FDEFGH', 'A0000010', '7'),
('FABCDE', 'A0000002', '5'),
('FABCFG', 'A0000003', '9'),
('FBCDEF', 'A0000004', '22'),
('FCDEFG', 'A0000005', '3'),
('FDEFGH', 'A0000001', '6'),
('FABCDE', 'A0000003', '11'),
('FABCFG', 'A0000004', '14'),
('FBCDEF', 'A0000005', '9'),
('FCDEFG', 'A0000006', '7'),
('FDEFGH', 'A0000007', '13'),
('FABCDE', 'A0000008', '16'),
('FABCFG', 'A0000009', '21'),
('FBCDEF', 'A0000010', '4'),
('FCDEFG', 'A0000001', '12'),
('FDEFGH', 'A0000002', '8');

 /* 1.  Sélectionner tous les employés (codeEmpl, nom, salaire) triés par nom et par ordre alphabétique */
SELECT codeEmpl, nom, salaire FROM employe ORDER BY nom ASC;

/* 2. Sélectionner tous les employés (codeEmpl, nom, salaire) avec, pour chaque employé, le nom du rayon dans lequel il travaille */
SELECT codeEmpl, nom, salaire, nomR FROM employe;

/* 3. Sélectionner tous les fournisseurs (codeFourn, nom) 
et le nombre de produits qu'ils fournissent, triés par nombre de produits décroissant */
SELECT fournisseurs.codeF AS codeFourn, fournisseurs.nomF AS nomFourn, COUNT(codeA) AS quantite
FROM fournisseurs
INNER JOIN ligne_bon_de_livraison ON fournisseurs.codeF = ligne_bon_de_livraison.codeF
GROUP BY nomFourn
ORDER BY quantite DESC;

/* 4. Sélectionner le nom des produits, leur prix, et le nom du fournisseur associé */
SELECT nomA AS nom_produit, prix AS prix_article, nomF AS nom_fournisseur 
FROM ligne_bon_de_livraison 
JOIN articles ON articles.codeA = ligne_bon_de_livraison.codeA
JOIN fournisseurs ON fournisseurs.codeF = ligne_bon_de_livraison.codeF;

/* 5. Sélectionner le nom des produits, leur prix, et le nom du fournisseur 
pour chaque produit dont le prix est superieur à la moyenne des prix des produits */
SELECT nomA AS nom_produit, prix, nomF AS nom_fournisseur
FROM ligne_bon_de_livraison
JOIN articles ON articles.codeA = ligne_bon_de_livraison.codeA
JOIN fournisseurs ON fournisseurs.codeF = ligne_bon_de_livraison.codeF
WHERE prix > (SELECT AVG(prix) FROM articles);

/* 6. Sélectionner tous les employés (codeEmpl, nom). 
Pour chaque employé, indiquer le nom du rayon, le nombre d'articles associés au rayon */
SELECT codeEmpl, nom, articles.nomR, COUNT(articles.nomR) AS nombre_articles
FROM employe
JOIN articles ON articles.nomR = employe.nomR
GROUP BY codeEmpl;

/* 7. Sélectionner tous les articles (codeA, nomA). Pour chaque article, 
indiquer le nombre de livraisons et la quantité totale livrée. */
SELECT articles.codeA, nomA, 
COUNT(ligne_bon_de_livraison.codeF) AS nombre_livraisons, 
SUM(ligne_bon_de_livraison.quantité) AS quantite_livre
FROM articles
JOIN ligne_bon_de_livraison ON articles.codeA = ligne_bon_de_livraison.codeA
GROUP BY codeA;

/* 8. Sélectionner tous les articles (codeA, nomA). Pour chaque article, 
indiquer le nom du fournisseur, le nom et l'étage du rayon où il est stocké, 
et l'employé qui y travaille (codeEmpl, nom). */
SELECT 
articles.codeA AS code_article, 
nomA AS nom_article, 
fournisseurs.nomF AS nom_fournisseur,
articles.nomR AS nom_rayon,
rayon.etage AS etage_rayon,
employe.codeEmpl AS code_employe,
employe.nom AS nom_employe
FROM articles
JOIN rayon ON rayon.nomR = articles.nomR
JOIN employe ON employe.nomR = articles.nomR
JOIN ligne_bon_de_livraison
JOIN fournisseurs;

SELECT * FROM articles;
SELECT * FROM fournisseurs;
SELECT * FROM ligne_bon_de_livraison;
DELIMITER |
CREATE PROCEDURE afficher_prod_outFournisseur(IN p_codeF CHAR(6), OUT p_nomfournisseur VARCHAR(50))
BEGIN
 SELECT
  A.nomA AS "Nom Article",
  A.`type` AS "Type Article",
  A.nomR AS "Rayon",
  F.nomF AS "Nom Fournisseur" INTO p_nomfournisseur
 FROM
  ligne_bon_de_livraison AS L
 INNER JOIN
  articles AS A ON A.codeA = L.codeA
 INNER JOIN
  fournisseurs AS F ON F.codeF = L.codeF
 WHERE
 L.codeF = p_codeF;
END|
DELIMITER ;

SET @p_nomfournisseur := '';
CALL afficher_prod_outFournisseur('FABCFG', @p_nomfournisseur);


