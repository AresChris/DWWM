<?php

class Personne {
    private $nom;
    private $prenom;
    private $age;
    
    public function __construct($nom, $prenom, $age) {
        $this->nom = $nom;
        $this->prenom = $prenom;
        $this->age = $age;
    }

    public function getDetails() {
        return "{$this->prenom} {$this->nom}, {$this->age} ans";
    }
}

$personne = new Personne("Dupont", "Jean", 30);
echo $personne->getDetails();
