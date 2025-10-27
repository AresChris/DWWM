DROP TABLE IF EXISTS t_user;

CREATE TABLE t_user
(user_id INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
user_email VARCHAR(128) NOT NULL UNIQUE,
user_lastname CHAR(50) NOT NULL,
user_firstname CHAR(50) NOT NULL);

SELECT * FROM t_user;

INSERT INTO t_user
(user_id, user_lastname, user_firstname, user_email)
VALUES
('1', 'Rabbit', 'Zora', 'zorb@example.com'),
('2', 'Patchouli', 'Édouard', 'patchouli@example.fr'),
('3', 'Satiti', 'Eva', 'eva.stt@example.com');

DROP TABLE IF EXISTS t_categories;

CREATE TABLE t_categories
(categorie_name CHAR(30) NOT NULL,
categorie_description VARCHAR(255),
category_order INT(3) PRIMARY KEY NOT NULL UNIQUE);

INSERT INTO t_categories
(categorie_name, categorie_description, category_order)
VALUES
('Bases de données', 'Les questions relatives aux bases de données', 2),
('SQL', 'Les questions sur le langage SQL', 3),
('NoSQL', 'Les questions sur l\'approche NoSQL', 4),
('PHP', 'Les questions relatives à PHP', 1),
('Javascript', 'Les questions relatives à PHP', 5);

DROP TABLE IF EXISTS t_questions;

CREATE TABLE t_questions
(question_id INT AUTO_INCREMENT PRIMARY KEY,
question_date DATE NOT NULL,
question_label VARCHAR(255),
question_response TEXT,
identifiant_auteur INT,
category_order INT,
FOREIGN KEY(identifiant_auteur) REFERENCES t_user(user_id),
FOREIGN KEY(category_order) REFERENCES t_categories(category_order));

INSERT INTO t_questions
(question_id, question_date, question_label, question_response, identifiant_auteur, category_order)
VALUES
(1, '2024-11-23', 'Dans MySQL, quel type de données permet de stocker des valeurs numériques dont le maximum est 127 ?',
'Le type TINYINT stocke des valeurs numériques comprises entre -128 et 127', 3, 2),
(2, '2024-11-23', 'Quels sont les principaux serveurs SQL gratuits ? ', 'MySQL, MariaDB, PostgreSQL, SQLite', 2, 2),
(3, '2024-11-27', 'Que signifie le sigle SGBDR ?', 'Système de Gestion de Bases de Données Relationnelles', 1, 2),
(4, '2024-12-05', '	Que signifie le sigle SQL ?', 'Structured Query Language !', 2, 2),
(5, '2024-12-05', 'Que signifie le sigle noSQL ?', 'Not Only SQL !', 3, 4);

DROP TABLE IF EXISTS categories_questions;

CREATE TABLE categories_questions
(question_id INT(11), 
category_order INT NOT NULL);

INSERT INTO categories_questions
(question_id, category_order)
VALUES
(1, 2),
(1, 3),
(2, 2),
(2, 3),
(3, 2),
(4, 2),
(4, 3),
(5, 2),
(5, 4);

ALTER TABLE categories_questions
ADD CONSTRAINT PK_categories_questions PRIMARY KEY (question_id, category_order);

/* 1. Sélectionner tous les utilisateurs (identifiant, nom, prénom, email). */
SELECT user_id, user_lastname, user_firstname, user_email
FROM t_user;

/* 2. Sélectionner toutes les questions (date, intitulé, réponse, identifiant utilisateur) 
triées par date de la plus ancienne à la plus récente. */
SELECT question_date, question_label, question_response, t_user.user_id 
FROM t_questions
JOIN t_user ON t_user.user_id = t_questions.identifiant_auteur
ORDER BY question_date DESC;

/* 3. Sélectionner les questions (identifiant, date, intitulé, réponse) de l’utilisateur n°2. */
SELECT question_id, question_date, question_label, question_response
FROM t_questions
JOIN t_user
WHERE user_id = 2;

/* 4. Sélectionner les questions (date, intitulé, réponse, identifiant utilisateur) de l’utilisateur Eva Satiti. */
SELECT question_date, question_response, user_id
FROM t_questions
JOIN t_user
WHERE user_firstname = 'Eva' AND user_lastname = 'Satiti';

/* 5. Sélectionner les questions (identifiant, date, intitulé, réponse, identifiant utilisateur) 
dont l’intitulé contient “SQL”. Le résultat est trié par le titre et par ordre décroissant. */
SELECT question_id, question_date, question_response, user_id
FROM t_questions, t_user
WHERE question_label LIKE '%SQL%'
ORDER BY question_label DESC;

/* 6. Sélectionner les catégories (nom, description) sans question associée. */
SELECT categorie_name, categorie_description
FROM t_categories
WHERE category_order
NOT IN(SELECT DISTINCT category_order FROM t_questions);

/* 7. Sélectionner les questions triées par titre (ordre alphabétique) avec le nom et prénom de l’auteur (nécessite une jointure). */
SELECT question_label, t_user.user_lastname, t_user.user_firstname
FROM t_questions
JOIN t_user ON t_user.user_id = t_questions.identifiant_auteur
ORDER BY question_label ASC;

/* 8. Sélectionner les catégories (nom) avec, pour chaque catégorie le nombre de questions associées (nécessite une jointure). */
SELECT 
t_categories.category_order,
categorie_name, 
(SELECT COUNT(t_questions.category_order)) AS somme_questions
FROM t_categories
JOIN t_questions ON t_questions.category_order = t_categories.category_order
GROUP BY category_order;