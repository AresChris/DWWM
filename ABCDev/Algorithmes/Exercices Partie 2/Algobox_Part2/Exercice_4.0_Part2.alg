<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="AFFICHER heure"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2defaut="" F2para="" F2etat="inactif" F2lignes=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param totalAffichages="1000" totalBoucles="5000000" epaisseurPoint="2" arrondiAuto="vrai" nbDecimales="8" epaisseurLigne="2" maxBoucle="500000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="minute EST_DU_TYPE NOMBRE" code="1#NOMBRE#minute"/>
        <item algoitem="heure EST_DU_TYPE NOMBRE" code="1#NOMBRE#heure"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Indiquer l'heure actuelle (hh) : &quot;" code="4#Indiquer l'heure actuelle (hh) : #0"/>
        <item algoitem="LIRE heure" code="2#heure#pasliste"/>
        <item algoitem="AFFICHER &quot;Indiquer les minutes (mm) : &quot;" code="4#Indiquer les minutes (mm) : #0"/>
        <item algoitem="LIRE minute" code="2#minute#pasliste"/>
        <item algoitem="minute PREND_LA_VALEUR minute+1" code="5#minute#minute+1#pasliste"/>
        <item algoitem="AFFICHER &quot;Dans une minute, il sera &quot;" code="4#Dans une minute, il sera #0"/>
        <item algoitem="AFFICHER heure" code="3#heure#0#pasliste"/>
        <item algoitem="AFFICHER &quot;:&quot;" code="4#:#0"/>
        <item algoitem="AFFICHER minute" code="3#minute#0#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
