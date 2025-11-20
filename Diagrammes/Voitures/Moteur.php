<?php
class Moteur
{

	protected string $marque;
	protected float $vitesse_max;

	/**
	 * 
	 * @param vitesse_max
	 * @param marque
	 */
	function __construct(float $vitesse_max, string $marque)
	{
		$this->vitesse_max = $vitesse_max;
		$this->marque = $marque;
	}

	public function toString():string
	{
		return "Moteur de marque : " . $this->marque . " avec une vitesse max de " . $this->vitesse_max . " km/h";
	}

	function affiche_vitesse()
	{
		echo "Vitesse max : " . $this->vitesse_max . " km/h";
	}

	function getmarque()
	{
		return $this->marque;
	}

	function getvitesse_max()
	{
		return $this->vitesse_max;
	}

	/**
	 * 
	 * @param value
	 */
	function setvitesse_max($value)
	{
		$this->vitesse_max = $value;
	}

}
?>