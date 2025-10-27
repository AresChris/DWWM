/* 1. Donner nom, job, numéro et salaire de tous les employés, puis seulement des employés du département 10 */
SELECT ENAME, JOB, SAL FROM emp WHERE DEPTNO = 10;

/* 2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800 */
SELECT ENAME, JOB, SAL FROM emp WHERE JOB='MANAGER' AND SAL > 2800;

/* 3. Donner la liste des MANAGER n'appartenant pas au département 30 */
SELECT ENAME, JOB, DEPTNO FROM emp WHERE JOB ='MANAGER' AND DEPTNO <> 30;

/* 4. Liste des employés de salaire compris entre 1200 et 1400 */
SELECT ENAME, JOB, SAL FROM emp WHERE SAL BETWEEN 1200 AND 1400;

/* 5. Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique */
SELECT ENAME, DEPTNO FROM emp WHERE DEPTNO IN(10,30) ORDER BY ENAME ASC;

/* 6. Liste des employés du département 30 classés dans l'ordre des salaires croissants */
SELECT ENAME, DEPTNO, SAL FROM emp WHERE DEPTNO = 30 ORDER BY SAL ASC;

/* 7. Liste de tous les employés classés par emploi et salaires décroissants */
SELECT ENAME, JOB, SAL FROM emp ORDER BY JOB DESC, SAL DESC;

/* 8. Liste des différents emplois */
SELECT DISTINCT JOB FROM emp;
SELECT COUNT(*),JOB FROM emp group BY job;
/* 9. Donner le nom du département où travaille ALLEN */
SELECT ENAME, DNAME 
FROM emp 
JOIN dept ON emp.DEPTNO = dept.DEPTNO
WHERE ENAME LIKE 'ALLEN';

/* 10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et 
par salaires décroissants */
SELECT DNAME, ENAME, JOB, SAL 
FROM emp 
JOIN dept ON emp.DEPTNO = dept.DEPTNO
ORDER BY DNAME DESC, 
SAL DESC;

/* 11. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + 
commissions */
SELECT ENAME, SAL, COMM, ifnull(COMM,0)+SAL
FROM emp
WHERE JOB = 'SALESMAN';

/* 12. Liste des employés du département 20: nom, job, date d'embauche sous forme VEN 28 FEV 1997' */
SELECT ENAME, JOB, DATE_FORMAT(HIREDATE, '%W %e %M %Y')
FROM emp
WHERE DEPTNO = 20;

/* 13. Donner le salaire le plus élevé par département*/
SELECT ENAME, MAX(SAL) AS "salaire maximum", DNAME FROM emp
JOIN dept ON emp.DEPTNO = dept.DEPTNO
GROUP BY dept.DEPTNO;

/* 14. Donner département par département masse salariale, nombre d'employés, salaire moyen par type 
d'emploi. */
SELECT SUM(SAL+IFNULL(comm,0) ) AS "masse salariale", COUNT(*) AS "effectif",ROUND(AVG(SAL),2) AS " salaire moyen",deptno, job
FROM emp
GROUP BY DEPTNO,job;

/* 15. Même question mais on se limite aux sous-ensembles d'au moins 2 employés */
SELECT SUM(SAL+IFNULL(comm,0) ) AS "masse salariale", COUNT(*) AS "effectif",ROUND(AVG(SAL),2) AS " salaire moyen",deptno, job
FROM emp
GROUP BY DEPTNO, JOB
HAVING COUNT(*) >= 2;

/* 16. Liste des employés (Nom, département, salaire) de même emploi que JONES */
SELECT ENAME, DNAME, SAL 
FROM emp
JOIN dept ON emp.DEPTNO = dept.DEPTNO
WHERE emp.JOB =
(SELECT JOB
FROM emp
WHERE ENAME = 'JONES');

/* 17. Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires */
SELECT ENAME, SAL FROM emp WHERE SAL > (SELECT AVG(SAL) FROM emp);

LDD
/* 18.  Création d'une table PROJET avec comme colonnes numéro de projet (3 chiffres), nom de projet(5 
caractères), budget. Entrez les valeurs suivantes:
101, ALPHA, 96000
102, BETA, 82000
103, GAMMA, 15000 */
CREATE TABLE projet
(num_projet INT AUTO_INCREMENT PRIMARY KEY,
nom_projet VARCHAR(5), 
budget INT);
ALTER TABLE projet AUTO_INCREMENT=101;


INSERT INTO projet
VALUES
(num_projet,'ALPHA', 96000),
(num_projet,'BETA', 82000),
(num_projet,'GAMMA', 15000);

/* 19. Ajouter l'attribut numéro de projet à la table EMP et affecter tous les vendeurs du département 30 
au projet 101, et les autres au projet 102*/
ALTER TABLE emp
ADD num_projet INT;
UPDATE emp
SET num_projet = 101
WHERE JOB = 'Salesman' AND DEPTNO = 30;


UPDATE emp
SET num_projet = 102
WHERE empno NOT IN( Select empno FROM emp where JOB = 'Salesman' AND DEPTNO =30);
UPDATE emp
SET num_projet = 103
WHERE NOT(JOB = 'Salesman' AND DEPTNO =30);

/* 20. Créer une vue comportant tous les employés avec nom, job, nom de département et nom de projet */
Create VIEW liste AS SELECT ENAME, JOB, DNAME, nom_projet FROM emp JOIN dept ON emp.DEPTNO = dept.DEPTNO JOIN projet ON emp.num_projet = projet.num_projet;

/* 21. A l'aide de la vue créée précédemment, lister tous les employés avec nom, job, nom de département 
et nom de projet triés sur nom de département et nom de projet */
-- SELECT ename, job, dname, nom_projet 
-- FROM emp 
-- JOIN projet on emp.num_projet = projet.num_projet
-- JOIN dept ON emp.DEPTNO = dept.DEPTNO 
-- ORDER BY dname, nom_projet;

SELECT ename,job, dname, nom_projet FROM liste ORDER BY dname, nom_projet;


/* 22. Donner le nom du projet associé à chaque manager */
SELECT emp.ENAME, projet.nom_projet
FROM emp
JOIN projet ON emp.num_projet = projet.num_projet
WHERE emp.JOB = 'MANAGER';

/* -------------------------------------------- */
/* Deuxième partie */

/* 1. Afficher la liste des managers des départements 20 et 30 */
SELECT JOB, ENAME, DEPTNO FROM emp WHERE JOB='MANAGER' AND DEPTNO IN(30,20);

/* 2. Afficher la liste des employés qui ne sont pas manager et qui ont été embauchés en 81 */
SELECT ENAME, JOB, HIREDATE FROM emp WHERE JOB <> 'MANAGER' AND YEAR(HIREDATE) = 1981;

/* 3. Afficher la liste des employés ayant une commission */
SELECT ENAME, COMM FROM emp WHERE COMM > 0 ;
-- (comm IS NOT NULL);

/* 4. Afficher la liste des noms, numéros de département, job et date d'embauche triés par numéro de département et job les derniers embauchés d'abord */
SELECT ENAME, DEPTNO, JOB, HIREDATE FROM emp GROUP BY DEPTNO, JOB ORDER BY HIREDATE DESC;

/* 5. Afficher la liste des employés travaillant à DALLAS */
SELECT ENAME, emp.DEPTNO, dept.LOC
FROM emp
JOIN dept ON emp.DEPTNO = dept.DEPTNO
WHERE dept.LOC = 'DALLAS';

/* 6. Afficher les noms et dates d'embauche des employés embauchés avant leur manager, avec le nom et date d'embauche du manager */
SELECT 
e.ENAME AS employee_name, 
e.HIREDATE AS employee_hiredate,
m.ENAME AS manager_name,
m.HIREDATE AS manager_hiredate
FROM emp e
JOIN emp m ON e.MGR =m.EMPNO
WHERE e.HIREDATE < m.HIREDATE;

/* 7. Lister les numéros des employés n'ayant pas de subordonné. */
SELECT ENAME, JOB FROM emp WHERE emp.MGR IS NULL;

/* 8. Afficher les noms et dates d'embauche des employés embauchés avant BLAKE */
SELECT ename, hiredate FROM emp WHERE  hiredate <= (SELECT hiredate FROM emp WHERE ename ="BLAKE") AND ename!="blake";

/* 9. Afficher les employés embauchés le même jour que FORD */
SELECT ENAME, HIREDATE FROM emp WHERE hiredate = (SELECT hiredate FROM emp WHERE ENAME = "FORD");

/* 10. Lister les employés ayant le même manager que CLARK */
SELECT
e.ENAME AS "Nom employé",
e.HIREDATE AS "Date embauche employé",
m.ENAME AS "Nom manager"
FROM emp e
JOIN emp m ON e.MGR = m.EMPNO
WHERE e.MGR = (
  SELECT MGR
  FROM emp
  WHERE ENAME = 'CLARK'
)
AND e.ENAME <> 'CLARK';

/* 11. Lister les employés ayant le même job et même manager que TURNER */
SELECT 
  e.ENAME AS "Nom employé",
  e.JOB AS "Job employé",
  m.ENAME AS "Nom manager"
FROM emp e
JOIN emp m ON e.MGR = m.EMPNO
WHERE e.JOB = 
(SELECT JOB FROM emp WHERE ENAME = 'TURNER')
AND e.MGR = 
(SELECT MGR FROM emp WHERE ENAME = 'TURNER')
AND e.ENAME <> 'TURNER';

/* 12. Lister les employés du département research embauchés le même jour que quelqu'un du département SALES */
SELECT e1.ENAME, e1.JOB, e1.HIREDATE
FROM emp e1
WHERE e1.DEPTNO = 20
AND e1.HIREDATE IN 
(SELECT e2.HIREDATE
FROM emp e2
WHERE e2.DEPTNO = 30);

/* 13. Lister le nom des employés et également le nom du jour de la semaine correspondant à leur date d'embauche */
SELECT ENAME, TO_CHAR(Hiredate, 'DAY') FROM emp;

/* 14. Donner, pour chaque employé, le nombre de mois qui s'est écoulé entre leur date d'embauche et la date actuelle */
SELECT 
ENAME, 
HIREDATE, 
PERIOD_DIFF(DATE_FORMAT(CURDATE(), '%Y%m'), DATE_FORMAT(HIREDATE, '%Y%m')) AS "Mois écoulés" 
FROM emp;

/* 15. Afficher la liste des employés ayant un M et un A dans leur nom */
SELECT ENAME FROM emp WHERE ENAME LIKE '%A%' AND ENAME LIKE '%M%';

/* 16. Afficher la liste des employés ayant deux A dans leur nom */
SELECT ENAME FROM emp WHERE ENAME LIKE '%A%A%';

/* 17. Afficher les employés embauchés avant tous les employés du département 10 */
SELECT e.ENAME, e.HIREDATE
FROM emp e
WHERE e.HIREDATE <
(SELECT MIN(HIREDATE) FROM emp WHERE deptno = 10);

/* 18. Sélectionner le métier où le salaire est le plus faible */
SELECT JOB AS "Métier", MIN(SAL) AS "Salaire minimum" FROM emp;

/* 19. Sélectionner le département ayant le plus d'employés */
SELECT DEPTNO, COUNT(*) AS "Nombre d'employés" 
FROM emp
GROUP BY DEPTNO DESC
LIMIT 1;

/* 20. Donner la répartition en pourcentage du nombre d'employés par département selon le modèle ci-dessous */
SELECT DEPTNO, ROUND(COUNT(*) * 100.0 / (SELECT COUNT(*) FROM emp), 2) AS "pourcentage"
FROM emp
GROUP BY DEPTNO;



