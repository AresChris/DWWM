<?php
require_once 'DAO/DbConnexion.php';
require_once 'DAO/RestoRepository.php';

try {
    $dbconnect=DbConnexion::getConnexion();
    var_dump($dbconnect);
} catch (Exception $e)   {
    echo "Erreur de connexion à la base de données : " . $e->getMessage();
}

$objResto = new RestoRepository();

var_export($objResto->searchAll());

var_export($objResto->searchById(1));
