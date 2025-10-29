<?php

class Moteur{
    protected $marque;
    protected $puissance;

    public function __construct($marque, $puissance) {
        $this->marque = $marque;
        $this->puissance = $puissance;
    }

    public function getDetails() {
        return "{$this->marque} {$this->puissance}";
    }
}

$moteur = new Moteur("Toyota", 250 ."km/h");
echo $moteur->getDetails(); // Affiche "Toyota 250km/h"