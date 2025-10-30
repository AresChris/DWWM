<?php

class Pret{
    public int $k; 
    public float $ta;
    public int $an;
    public int $tm;

    public function __construct(int $_k, float $_ta, int $_an, int $_tm)
    {
        $this->k = $_k;
        $this->ta = $_ta;
        $this->an = $_an;
        $this->tm = $_tm;
    }
    public function GetCapitalEmprunt(): int
    {
        return $this->k;
    }
    public function GetTauxAnnuel(): float
    {
        return $this->ta;
    }
    public function GetDureeRemboursement(): int
    {
        return $this->an;
    }
    public function calculMoisRemboursement()
    {
        $n = $this->an * 12;
    }
    public function calculMensualite()
    {
        $n = $this->an * 12;
        $tm = $this->ta / 12;
        $q = (1-(1 + $tm)** -$n);
        $a = ($this->k * $tm) /$q;
    }
}


// Le taux d’intérêt annuel : ta ;
// Le nombre d’années ( entières) de remboursement : an ;
// Et de la formule financière suivante :
// Tm est le taux mensuel d’intérêt :
// Tm=ta/12
// Soit n le nombre de mois de remboursement :
// n=an * 12
// Pour rappel K : le capital emprunté en €
// Q= (1-(1+ Tm )puissance -n)
// a : la mensualité constante recherché :
// a= (K x Tm)/Q

