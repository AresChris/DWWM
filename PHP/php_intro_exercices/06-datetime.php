<?php

function getToday(){
    $today = date("d/m/Y");
    return $today;
}

echo getToday() . "\n";

function getTimeLeft(string $date){
    $today = new DateTime();
    $target = DateTime::createFromFormat("Y-m-d", $date);

    if(!$target){
        return "Format de date invalide";
    }

    $diff = $today->diff($target);
    $days = $diff->days;

    if($target < $today){
        return "Evenement passé";
    }else if($target == $today){
        return "Aujourd'hui";
    }else{
        return "Dans " . $days . " jours";
    }
}

echo getTimeLeft("2019-09-29") . "\n";
echo getTimeLeft("2025-10-27") . "\n";
echo getTimeLeft("2025-10-28") . "\n";
echo getTimeLeft("2020-05-16") . "\n";
echo getTimeLeft("2021-05-30") . "\n";
echo getTimeLeft("2022-10-17") . "\n";

