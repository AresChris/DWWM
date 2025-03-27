<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="AFFICHER resultat2"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode="resultat1"/>
    <F2 F2etat="inactif" F2lignes="" F2para="" F2defaut=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param maxBoucle="500000" arrondiAuto="vrai" totalBoucles="5000000" nbDecimales="8" epaisseurLigne="2" epaisseurPoint="2" totalAffichages="1000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="nombre1 EST_DU_TYPE NOMBRE" code="1#NOMBRE#nombre1"/>
        <item algoitem="nombre2 EST_DU_TYPE NOMBRE" code="1#NOMBRE#nombre2"/>
        <item algoitem="resultat EST_DU_TYPE NOMBRE" code="1#NOMBRE#resultat"/>
        <item algoitem="resultat2 EST_DU_TYPE NOMBRE" code="1#NOMBRE#resultat2"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;saisir le 1er nombre&quot;" code="4#saisir le 1er nombre#0"/>
        <item algoitem="LIRE nombre1" code="2#nombre1#pasliste"/>
        <item algoitem="AFFICHER &quot;saisir le 2eme nombre&quot;" code="4#saisir le 2eme nombre#0"/>
        <item algoitem="LIRE nombre2" code="2#nombre2#pasliste"/>
        <item algoitem="resultat PREND_LA_VALEUR nombre1 + nombre2" code="5#resultat#nombre1 + nombre2#pasliste"/>
        <item algoitem="resultat2 PREND_LA_VALEUR resultat/2" code="5#resultat2#resultat/2#pasliste"/>
        <item algoitem="AFFICHER &quot;Le résultat est :&quot;" code="4#Le résultat est :#0"/>
        <item algoitem="AFFICHER resultat2" code="3#resultat2#0#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
