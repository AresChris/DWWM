<?php
require_once './Personne.php';
require_once './Client.php';
require_once './Intervenant.php';
require_once './Intervention.php';

echo "-------------------------------" . "\n";
$personne1 = new Personne("Dupont", "Jean", "1960-05-15");
echo $personne1->toString();

$intervenant1 = new Intervenant($personne1, 3000, 500);

echo $intervenant1->toString() . "\n";
echo $intervenant1->calculer_age() . " ans" . "\n";
echo "Charges de l'intervenant : " . $intervenant1->calcul_charges() . " EUR" . "\n";

$client1 = new Client($intervenant1, 12345);
$client1->setadresse(10, "Rue de la Paix", "75002", "Paris");
$intervention1 = new Intervention("2025-12-01", "10:00");
echo "Client n°" . $client1->getnumero_client() . " habitant à " . $client1->getadresse() . "\n" . "Heure d'intervention : " . $intervention1->getheure_intervention() . "\n" . "Date d'intervention : " . $intervention1->getdate_intervention() . "\n";

echo "-------------------------------" . "\n";
