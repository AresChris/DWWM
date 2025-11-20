<?php

require_once ('./Moteur.php');
require_once ('./Voiture.php');
require_once ('./VoitureDeCourse.php');

// Création d'un moteur
$moteurPeugeot = new Moteur(350.0, "Peugeot");
$moteurFerrari = new Moteur(450.0, "Ferrari");
try {
    // Création d'une voiture de course avec un moteur compatible
    $maVoiture = new VoitureDeCourse($moteurPeugeot, "Ferrari", "208", 1475, 200.0);
  //echo $maVoiture . "\n";
} catch (Exception $e) {
    echo "Erreur lors de la création de la voiture de course : " . $e->getMessage() . "\n";
    die();
}
//$maVoiture = new VoitureDeCourse($moteurPeugeot, "Peugeot", "208", 1475, 200.0);
echo $maVoiture. "\n";
// echo $maVoiture->calculer_vitesse_max() . "\n";
echo "Vitesse max calculée : " . $maVoiture->getvitesseMax() . " km/h\n";