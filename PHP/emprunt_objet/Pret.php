<?php

class Pret
{
    private int $k;
    private float $ta;
    private int $an;

    public function __construct(int $_k, float $_ta, int $_an)
    {
        $this->k = $_k;
        $this->ta = $_ta;
        $this->an = $_an;
    }

    public function getCapitalEmprunt(): int
    {
        return $this->k;
    }

    public function getTauxAnnuel(): float
    {
        return $this->ta;
    }

    public function getDureeRemboursement(): int
    {
        return $this->an;
    }

    public function calculMoisRemboursement(): int
    {
        return $this->an * 12;
    }

    private function calculTauxMensuel(): float
    {
        return $this->ta / 100 / 12; // Division par 100 car le taux est en pourcentage
    }

    public function calculMensualite(): float
    {
        $n = $this->calculMoisRemboursement();
        $tm = $this->calculTauxMensuel();
        $q = (1 - pow(1 + $tm, -$n));
        $mensualite = ($this->k * $tm) / $q;
        return round($mensualite, 2); // Arrondi à 2 décimales
    }

    public function tableauAmortissement()
    {
        $n = $this->calculMoisRemboursement();
        $tm = $this->calculTauxMensuel();
        $mensualite = $this->calculMensualite();
        $capitalRestant = $this->k;
        $table = '<table border="1" cellpadding="5" cellspacing="0" style="width:100%;border-collapse:collapse;text-align:center;">';
        $table .= '<thead><tr><th>Mois</th><th>Mensualité</th><th>Intérêts</th><th>Amortissement</th><th>Capital restant</th></tr></thead><tbody>';
        for ($i = 1; $i <= $n; $i++) {
            $interet = round($capitalRestant * $tm, 2);
            $amortissement = round($mensualite - $interet, 2);
            $capitalRestant = round($capitalRestant - $amortissement, 2);
            if ($capitalRestant < 0) $capitalRestant = 0;
            $table .= '<tr>';
            $table .= '<td>' . $i . '</td>';
            $table .= '<td>' . number_format($mensualite, 2, ',', ' ') . '</td>';
            $table .= '<td>' . number_format($interet, 2, ',', ' ') . '</td>';
            $table .= '<td>' . number_format($amortissement, 2, ',', ' ') . '</td>';
            $table .= '<td>' . number_format($capitalRestant, 2, ',', ' ') . '</td>';
            $table .= '</tr>';
        }
        $table .= '</tbody></table>';
        return $table;
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
