<?php

/**
 * @author CAres
 * @version 1.0
 * @created 19-nov.-2025 11:51:53
 */
class Intervenant extends Personne
{
	private $salaire;
	private $autres_revenus;
	private $date_intervention;
	private $heure_intervention;

	function __construct(Personne $personne, $salaire, $autres_revenus)
	{
		parent::__construct($personne->getnom(), $personne->getprenom(), $personne->getDateNaissance());
		$this->salaire = $salaire;
		$this->autres_revenus = $autres_revenus;
	}

	function toString()
	{
		return 'Salaire: ' . $this->salaire . ' EUR, Autres revenus: ' . $this->autres_revenus . ' EUR';
	}
	function getdate_intervention()
	{
		return $this->date_intervention;
	}

	function getsalaire()
	{
		return $this->salaire;
	}

	/**
	 * 
	 * @param newVal
	 */
	function setsalaire($newVal)
	{
		$this->salaire = $newVal;
	}

	function getautres_revenus()
	{
		return $this->autres_revenus;
	}

	function getheure_intervention()
	{
		return $this->heure_intervention;
	}

	/**
	 * 
	 * @param newVal
	 */
	function setautres_revenus($newVal)
	{
		$this->autres_revenus = $newVal;
	}

	/**
	 * charges = (salaire x 20%) + (autres-revenus x 15%)
	 * taxes divis�es par 2 si l'age > 55 ans
	 */
	function calcul_charges()
	{
		$charges = ($this->salaire * 0.2) + ($this->autres_revenus * 0.15);
		$age = $this->calculer_age($this->date_naissance);
		if ($age > 55) {
			$charges = $charges / 2;
		}
		return $charges;
	}
}
?>