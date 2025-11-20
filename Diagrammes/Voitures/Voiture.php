<?php
class Voiture
{
//attributes

	protected string $marque;
	protected string $modele;
	protected int $poids;
	protected ?Moteur $leMoteur;
	protected float $vitesseMax;

//propriétés

	function getmodele()
	{
		return $this->modele;
	}

	function getpoids()
	{
		return $this->poids;
	}
	
	function getleMoteur()
	{
		return $this->leMoteur;
	}

	function getmarque()
	{
		return $this->marque;
	}
	public function getvitesseMax():float
	{
		return $this->vitesseMax;
	}

//modifieurs
	function setpoids(int $value)
	{
		$this->poids = $value;
	}

	function setleMoteur(Moteur $monmoteur)
	{
		$this->leMoteur = $monmoteur;
	}


	/**
	 * 
	 * @param unMoteur
	 * @param marque
	 * @param modele
	 * @param poids
	 * @param vitesseMax
	 */
	public function __construct( ?Moteur $monmoteur, string $_marque, string $_modele, int $_poids, float $_vitesseMax)
	{
		$this->marque = $_marque;
		$this->modele = $_modele;
		$this->poids = $_poids;
		$this->vitesseMax = $_vitesseMax;
		$this->leMoteur = $monmoteur;
	}

	public function __toString():string
	{
		return "Voiture : " . $this->marque . " " . $this->modele . ", Poids : " . $this->poids . " kg, de  moteur : " . $this->leMoteur->toString().", vitesse max : " . $this->vitesseMax . " km/h";
	}


	function calculer_vitesse_max()
	{
		$this->vitesseMax = $this->leMoteur->getvitesse_max() - ($this->poids * 0.30);
	}
}
?>