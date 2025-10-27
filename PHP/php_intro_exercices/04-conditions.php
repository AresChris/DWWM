<?php

function isMajor(int $age): bool{
    if($age < 18){
        return false;
    } else {
        return true;
    }
}

echo isMajor(12) . "\n";
echo isMajor(18) . "\n";
echo isMajor(42) . "\n";

function getRetired(int $a): string{
    $retirement = 60;
    if($a < 0){
        return "Vous n'êtes pas encore né";
    } else if($a < $retirement){
       $years = $retirement - $a;
       return "Il vous reste " . $years . " années avant la retraite";
    } else if($a > $retirement){
        $years = $a - $retirement;
        return "Vous êtes à la retraite depuis " . $years;
    } else{
        return "Vous êtes à la retraite cette année.";
    }
}

echo getRetired(12) . "\n";
echo getRetired(60) . "\n";
echo getRetired(72) . "\n";
echo getRetired(-2) . "\n";

function getMax(float $a, float $b, float $c){
    if($a > $b && $b > $c){
        return $a;
    } else if($b > $c && $c > $a){
        return $b;
    } else if($c > $b && $b > $a){
        return $c;
    } else if($c > $a && $a > $b){
        return $c;
    }else if($b > $a && $a > $c){
        return $b;
    }else if($a > $c && $c > $b){
        return $a;
    } else if($a == $b or $a == $c or $b == $c){
        return 0;
    }
}

echo number_format(getMax(2, 3, 4), 3) . "\n";
echo number_format(getMax(3, 4, 4), 3) . "\n";
echo number_format(getMax(3 , 4, 1), 3) . "\n";

$france = "Paris";
$allemagne = "Berlin";
$italie = "Rome";
$maroc = "Rabat";
$espagne = "Madrid";
$portugal = "Lisbonne";
$angleterre = "Londres";

function capitalCity(string $pays){
    switch($pays){
        case "France":
            return "Paris";
            break;
        case "Allemagne":
            return "Berlin";
            break;    
        case "Italie":
            return "Rome";
            break;
        case "Maroc":
            return "Rabat";
            break;
        case "Espagne":
            return "Madrid";
            break;
        case "Portugal":
            return "Lisbonne";
            break;
        case "Angleterre":
            return "Londres";
            break;
        default:
            return "Capitale inconnue";
            break;
    }
}

echo capitalCity("France") . "\n";
echo capitalCity("Japon") . "\n";
echo capitalCity("Angleterre") . "\n";

