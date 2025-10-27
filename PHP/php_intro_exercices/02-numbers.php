<?php

/**
 * 
 */
function getSum(int $a, int $b): int{
    return $a + $b;
}

echo getSum(5, 3) . "\n";

function getSub(int $a, int $b): int{
    return $a - $b;
}

echo getSub(5, 3) . "\n";
echo getSub(3, 5) . "\n";

function getMulti(float $a, float $b): float{
    return $a * $b;
}

echo number_format(getMulti(5.6, 3), 2) . "\n";
echo number_format(getMulti(5.6, -3.7), 2) . "\n";

function getDiv(float $a, float $b): float{
    if($a == 0 or $b == 0){
        return 0;
    }else {
        return $a / $b;
    } 
} 


echo number_format(getDiv(20, 3), 2) . "\n";

echo number_format(getDiv(20, 0), 2) . "\n";

