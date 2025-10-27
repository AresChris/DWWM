<?php

/**
 * Affiche "Hello world"
 */
function helloworld() : void{
    echo "Hello world!\n";
}

helloworld();

/**
 * Retourne "Hello $name !"
 * @param string $name le nom à afficher
 */
function hello(string $name): string{
    if(empty($name)){
        return "Nobody";
    }else {
        return "Hello $name";
    }
    
}

// Test de la fonction (la fonction n'affiche rien. "echo" affichera la valeur retournée par la fonction)
echo hello("");

