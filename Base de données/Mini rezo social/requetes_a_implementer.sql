/* Requêtes à implémenter */

/* Sélectionner tous les utilisateurs (nom d’utilisateur + email). */
SELECT user_name, user_email FROM t_user;

/* Sélectionner toutes les publications (titre, date, contenu, id utilisateur) triées par date de la plus récente à la plus ancienne. */
SELECT publication_titre, publication_date, publication_contenu, publication_auteur
FROM t_publication
ORDER BY publication_date DESC;

/* Sélectionner les publications (pub_id, date, titre) de l’utilisateur N°2. */
SELECT publication_id, publication_date, publication_titre, publication_auteur
FROM t_publication
WHERE publication_auteur = 2;

/* Sélectionner les publications (pub_id, titre, contenu) dont le titre contient la lettre “a”. 
Le résultat est trié par le titre et par ordre décroissant. */
SELECT publication_id, publication_titre, publication_contenu
FROM t_publication
WHERE publication_titre LIKE '%a%'
ORDER BY publication_titre DESC;

/* Sélectionner les utilisateurs (id, nom, email) dont l’adresse email se termine par “com”. */
SELECT user_id, user_name, user_email
FROM t_user
WHERE user_email LIKE '%com';

/* Sélectionner les publications triées par titre (ordre alphabétique) avec le nom d’utilisateur de l’auteur (nécessite une jointure). */
SELECT publication_titre, user_name
FROM t_publication
JOIN t_user ON t_publication.publication_auteur = t_user.user_id
ORDER BY publication_titre ASC;






