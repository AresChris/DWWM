<?php

$names = ["Joe", "Jack", "Léa", "Zoé", "Néo"];

function firstItem(array $names){
    if(empty($names)){
        return null;
    }
    return $names[0];
}

echo firstItem($names) . "\n";

function lastItem(array $names){
    if(empty($names)){
        return null;
    }
    return end($names);
}

echo lastItem($names) . "\n";

function sortItems(array $names): string{
    if(empty($names)){
        return "[]";
    }
    rsort($names);
    return "[" . implode(", ", $names) . "]";
}

echo sortItems($names) . "\n";

function stringItems(array $names): string{
    if(empty($names)){
        return "Nothing to display";
    }
    sort($names);
    return "[" . implode(", ", $names) . "]";
}

echo stringItems($names);

