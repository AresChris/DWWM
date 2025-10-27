<?php

function stringLength(string $password): bool{
    if(strlen($password) >= 9){
        return true;
    } else{
        return false;
    }
}

echo stringLength("MotDePasseLong") . "\n";
echo stringLength("azer") . "\n";

function passwordCheck(string $password): bool{
    if(!stringLength($password)){
        return false;
    }
    if(!preg_match("/\d/", $password)){
        return false;
    }
    if(!preg_match("/[A-Z]/", $password)){
        return false;
    }
    if(!preg_match("/[a-z]/", $password)){
        return false;
    }
    if(!preg_match("/[\W_]/", $password)){
        return false;
    }   
    return true;
}

echo passwordCheck("PassWord123!") . "\n";
echo passwordCheck("PassWord123") . "\n";

