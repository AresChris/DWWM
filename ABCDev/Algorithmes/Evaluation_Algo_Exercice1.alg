<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="perimetre PREND_LA_VALEUR (largeur+longueur)*2"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2etat="inactif" F2defaut="" F2lignes="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalBoucles="5000000" epaisseurPoint="2" totalAffichages="1000" arrondiAuto="vrai" nbDecimales="8" epaisseurLigne="2" maxBoucle="500000"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#longueur" algoitem="longueur EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#largeur" algoitem="largeur EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#aire" algoitem="aire EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#perimetre" algoitem="perimetre EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Inscrire la longueur : #0" algoitem="AFFICHER &quot;Inscrire la longueur : &quot;"/>
        <item code="2#longueur#pasliste" algoitem="LIRE longueur"/>
        <item code="4#Inscrire la largeur : #0" algoitem="AFFICHER &quot;Inscrire la largeur : &quot;"/>
        <item code="2#largeur#pasliste" algoitem="LIRE largeur"/>
        <item code="5#perimetre#(largeur+longueur)*2#pasliste" algoitem="perimetre PREND_LA_VALEUR (largeur+longueur)*2"/>
        <item code="5#aire#largeur*longueur#pasliste" algoitem="aire PREND_LA_VALEUR largeur*longueur"/>
        <item code="4#Le périmètre est de : #0" algoitem="AFFICHER &quot;Le périmètre est de : &quot;"/>
        <item code="3#perimetre#1#pasliste" algoitem="AFFICHER perimetre"/>
        <item code="4#L'aire est de : #0" algoitem="AFFICHER &quot;L'aire est de : &quot;"/>
        <item code="3#aire#0#pasliste" algoitem="AFFICHER aire"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
