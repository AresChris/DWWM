<?php

/**
 * @author CAres
 * @version 1.0
 * @created 19-nov.-2025 11:51:51
 */
class Client
{
	private $numero_client;
	private $adresse;
	private $date_intervention;
	private $heure_intervention;
	
	function __construct(Personne $personne, $_numero_client)
	{
		$this->numero_client = $_numero_client;
	}

	function getdate_intervention()
	{
		return $this->date_intervention;
	}

	function getnumero_client()
	{
		return $this->numero_client;
	}

	/**
	 * num�ro de rue, nom de rue, code postal, nom de commune
	 */
	function getadresse()
	{
		return $this->adresse;
	}

	function getheure_intervention()
	{
		return $this->heure_intervention;
	}

	/**
	 * num�ro de rue, nom de rue, code postal, nom de commune
	 * 
	 * @param numero_rue, nom_rue, code_postal, nom_commune
	 */
	function setadresse($numero_rue, $nom_rue, $code_postal, $nom_commune)
	{
		$this->adresse = $numero_rue . ', ' . $nom_rue . ', ' . $code_postal . ' ' . $nom_commune;
	}

}
?>