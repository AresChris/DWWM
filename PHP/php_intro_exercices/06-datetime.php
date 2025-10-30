<?php

function getToday(){
    return new DateTime();
}

echo getToday() . "\n";

function getTimeLeft(string $date){
    $target = DateTime::createFromFormat('Y-m-d', $date);
    $errors = DateTime::getLastErrors();
    if($errors['warning_count'] > 0 || $errors['error_count'] > 0){
        return "Format de date invalide";
    }

    $today = getToday();
    
    if($date < $today){
        return "Evenement passé";
    }else if($target == $today){
        return "Aujourd'hui";
    }
}

echo getTimeLeft("2019-09-29") . "\n";
echo getTimeLeft("2025-10-27") . "\n";
echo getTimeLeft("2025-10-28") . "\n";
echo getTimeLeft("2020-05-16") . "\n";
echo getTimeLeft("2021-05-30") . "\n";
echo getTimeLeft("2022-10-17") . "\n";

