<?php


/**
 * @author CAres
 * @version 1.0
 * @created 19-nov.-2025 11:51:54
 */
class Intervention
{

	private $date_intervention;
	private $heure_intervention;

	function __construct($date_intervention, $heure_intervention)
	{
		$this->date_intervention = $date_intervention;
		$this->heure_intervention = $heure_intervention;
	}

	function getdate_intervention()
	{
		return $this->date_intervention;
	}

	/**
	 * 
	 * @param newVal
	 */
	function setdate_intervention($newVal)
	{
		$this->date_intervention = $newVal;
	}

	function getheure_intervention()
	{
		return $this->heure_intervention;
	}

	/**
	 * 
	 * @param newVal
	 */
	function setheure_intervention($newVal)
	{
		$this->heure_intervention = $newVal;
	}

}
?>