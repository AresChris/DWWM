<?php

class Contribuable{
    private string $nom;
    private float $revenu;
    private const float TAUX1 = 0.09;
    private const float TAUX2 = 0.14;

    public function GetNom():float 
    {
        return $this->nom;
    }
    public function GetRevenu(): float
    {
        return $this->revenu;
    }
    public function SetRevenu(float $_revenu): void
    {
        $this->revenu = $_revenu;
    }

    public function __construct(string $_nom, float $_revenu)
    {
        $this->nom = $_nom;
        $this->revenu = $_revenu;
    }

    public function calculImpot(): string
    {
        $impot = 0;
        if($this->revenu < 15000){
            $impot = $this->revenu * self::TAUX1;
        } else {
            $impot = 15000 * self::TAUX1 + ($this->revenu - 15000) * self::TAUX2;
        }
        return $impot .=" €";
    }
}