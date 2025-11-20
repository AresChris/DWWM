<?php

class VoitureDeCourse extends Voiture
{

	
	/**
	 * 
	 * @param unMoteur
	 * @param marque
	 * @param modele
	 * @param poids
	 */
	function __construct(?Moteur $_unMoteur, string $_marque, string $_modele, int $_poids, float $_vitesseMax)
	{

		if($_unMoteur->getMarque() == $_marque){
		
			parent::__construct($_unMoteur, $_marque, $_modele, $_poids, $_vitesseMax);
		}else{
			throw new Exception("Le moteur n'est pas compatible avec la marque de la voiture");
		}
	}

	public function __toString():string
	{
		return "Voiture de course : " . $this->marque . " " . $this->modele . ", Poids : " . $this->poids . " kg, de  moteur : " . $this->leMoteur->toString().", Vitesse max : " . $this->calculer_vitesse_max() . " km/h";
	}
		/**
	 * 
	 * @param unMoteur
	 */
	public function calculer_vitesse_max()
	{
		$this->vitesseMax = $this->leMoteur->getvitesse_max() - ($this->poids * 0.05);
	}

	/**
	 * 
	 * @param value
	 */
	function setleMoteur(Moteur $value)
	{
		$this->leMoteur = $value;
	}

}
?>