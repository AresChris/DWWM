<?php

class VoitureDeCourse {
    protected $marque;
    protected $moteur;
    
    public function __construct($marque, $moteur) {
        $this->marque = $marque;
        $this->moteur = $moteur;
    }

    public function getDetails() {
        return "{$this->marque} {$this->moteur}";
    }
}

$voitureDeCourse = new VoitureDeCourse("Ferrari", 317 . "km/h");
echo $voitureDeCourse->getDetails();
