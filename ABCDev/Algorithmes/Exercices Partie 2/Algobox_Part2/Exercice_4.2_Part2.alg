<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="seconde PREND_LA_VALEUR seconde+1"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2etat="inactif" F2defaut="" F2para=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param arrondiAuto="vrai" maxBoucle="500000" epaisseurLigne="2" nbDecimales="8" epaisseurPoint="2" totalAffichages="1000" totalBoucles="5000000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="minute EST_DU_TYPE NOMBRE" code="1#NOMBRE#minute"/>
        <item algoitem="heure EST_DU_TYPE NOMBRE" code="1#NOMBRE#heure"/>
        <item algoitem="seconde EST_DU_TYPE NOMBRE" code="1#NOMBRE#seconde"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Indiquer l'heure actuelle (hh) : &quot;" code="4#Indiquer l'heure actuelle (hh) : #0"/>
        <item algoitem="LIRE heure" code="2#heure#pasliste"/>
        <item algoitem="AFFICHER &quot;Indiquer les minutes (mm) : &quot;" code="4#Indiquer les minutes (mm) : #0"/>
        <item algoitem="LIRE minute" code="2#minute#pasliste"/>
        <item algoitem="AFFICHER &quot;Indiquer les secondes (ss) : &quot;" code="4#Indiquer les secondes (ss) : #0"/>
        <item algoitem="LIRE seconde" code="2#seconde#pasliste"/>
        <item algoitem="seconde PREND_LA_VALEUR seconde+1" code="5#seconde#seconde+1#pasliste"/>
        <item algoitem="AFFICHER &quot;Dans une seconde, il sera &quot;" code="4#Dans une seconde, il sera #0"/>
        <item algoitem="AFFICHER heure" code="3#heure#0#pasliste"/>
        <item algoitem="AFFICHER &quot;:&quot;" code="4#:#0"/>
        <item algoitem="AFFICHER minute" code="3#minute#0#pasliste"/>
        <item algoitem="AFFICHER &quot;:&quot;" code="4#:#0"/>
        <item algoitem="AFFICHER seconde" code="3#seconde#0#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
