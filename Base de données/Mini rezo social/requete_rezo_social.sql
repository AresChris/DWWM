DROP TABLE IF EXISTS t_user;

CREATE TABLE t_user
(user_id INT(11) NOT NULL PRIMARY KEY, 
user_name VARCHAR(50), 
user_email VARCHAR(50));

CREATE TABLE t_publication
(publication_id INT(11) NOT NULL PRIMARY KEY,
publication_date DATE NOT NULL,
publication_titre VARCHAR(50) NOT NULL,
publication_contenu TEXT NOT NULL,
publication_auteur INT(11) NOT NULL,
FOREIGN KEY(publication_auteur) REFERENCES t_user(user_id));



