/* 1.  */
SELECT client_ref, client_nom FROM clients WHERE client_telephone LIKE '04%';

/* 2. */
SELECT client_ref, client_nom
FROM clients
JOIN type_clients ON type_clients.type_client_id = clients.type_client_id
WHERE clients.type_client_id = 1;

/* 3. */
SELECT client_ref, type_client_id FROM clients WHERE type_client_id != 1;

/* 4. */
SELECT projet_ref FROM projets WHERE projet_date_fin_prevue < projet_date_fin_effective;

/* 5. */
SELECT 
projet_date_depot, 
projet_date_fin_prevue, 
projet_superficie_totale, 
projet_superficie_batie,
projet_prix,
client_nom,
employes.emp_nom
FROM projets
JOIN clients ON clients.client_ref = projets.client_ref
JOIN employes ON employes.emp_matricule = projets.emp_matricule;

/* 6. */
/*SELECT 
projet_date_depot, 
projet_date_fin_prevue, 
projet_date_fin_effective,
projet_superficie_totale,
projet_superficie_batie,
projet_prix... */
/* Personne d'autre que le client ou l'architecte dans les projets */

/* 7. ------------------------------------------------------ */
SELECT COUNT(type_projets.type_projet_libelle), AVG(projet_prix)
FROM type_projets
JOIN projets ON projets.type_projet_id = type_projets.type_projet_id
ORDER BY projets.type_projet_id;
/* -----------------------------------------------------------*/

/* 8. */
SELECT type_travaux_libelle, MAX(projet_superficie_totale)
FROM type_travaux
JOIN projets ON projets.type_travaux_id = type_travaux.type_travaux_id
GROUP BY projets.type_travaux_id;

/* 9. */
SELECT 
projet_date_depot, 
projet_date_fin_prevue, 
projet_date_fin_effective,
projet_prix,
client_nom,
client_telephone,
adresse_code_postal,
adresse_ville,
adresse_num_voie,
adresse_voie,
type_travaux_libelle,
type_projet_libelle
FROM projets
JOIN clients ON clients.client_ref = projets.client_ref
JOIN adresses ON clients.adresse_id = adresses.adresse_id
JOIN type_travaux ON type_travaux.type_travaux_id = projets.type_travaux_id
JOIN type_projets ON type_projets.type_projet_id = projets.type_projet_id;

/* 10. */
SELECT 
projet_ref, 
projets.adresse_id, 
clients.adresse_id
FROM projets
JOIN clients ON clients.adresse_id = projets.adresse_id
WHERE clients.adresse_id = projets.adresse_id;