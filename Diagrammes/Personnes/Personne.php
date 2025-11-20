<?php


/**
 * @author CAres
 * @version 1.0
 * @created 19-nov.-2025 11:51:50
 */
class Personne
{

	var $nom;
	var $prenom;
	var $date_naissance;

	function __construct($nom, $prenom, $date_naissance)
	{
		$this->nom = $nom;
		$this->prenom = $prenom;
		$this->date_naissance = $date_naissance;
	}

	function toString()
	{
		return $this->nom . ' ' . $this->prenom . ' né le ' . $this->date_naissance . "\n";
	}

	function getDateNaissance()
	{
		return $this->date_naissance;
	}

	/**
	 * 
	 * @param value
	 */
	function setDateNaissance($value)
	{
		$this->date_naissance = $value;
	}

	function getnom()
	{
		return $this->nom;
	}

	function getprenom()
	{
		return $this->prenom;
	}

	/**
	 * 
	 * @param value
	 */
	function setnom($value)
	{
		$this->nom = $value;
	}
	public function calculer_age(){
		$birthDate = new DateTime($this->date_naissance);
		$today = new DateTime();
		$age = $today->diff($birthDate)->y;
		return $age;
	}
}
?>