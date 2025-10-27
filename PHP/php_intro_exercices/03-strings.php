<?php

function getMC2(string $name){
    return $name;
}

echo getMC2("Albert Einstein") . "\n";

function getUserName(string $prenom, string $nom): string{
    return $prenom . " " . $nom;
}

echo getUserName("Christopher", "Ares") . "\n";

function getFullName(string $nom, string $prenom): string{
    return $prenom . " " . $nom;
}

echo getFullName("Christopher", "Ares") . "\n";

function askUser(string $nom, string $prenom): string{
    $fullName = getFullName($nom, $prenom);
    $mc2 = getMC2("Einstein");
    return "Bonjour " . $fullName . ", connaissez-vous " . $mc2 . "?";
}

echo askUser("Ares", "Christopher");

