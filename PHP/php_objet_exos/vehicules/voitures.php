<?php

class Voiture {
    private $marque;
    private $modele;
    private $poids;
    
    public function __construct($marque, $modele, $poids) {
        $this->marque = $marque;
        $this->modele = $modele;
        $this->poids = $poids;
    }

    public function getDetails() {
        return "{$this->marque} {$this->modele} {$this->poids}";
    }
}

$voiture = new Voiture("Toyota", "Corolla", 1300 . "kg");
echo $voiture->getDetails(); 
