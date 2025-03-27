<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER &quot;Aire : &quot;" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2etat="inactif" F2defaut="" F2lignes="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param epaisseurPoint="2" epaisseurLigne="2" maxBoucle="500000" totalBoucles="5000000" totalAffichages="1000" arrondiAuto="vrai" nbDecimales="8"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="rayon EST_DU_TYPE NOMBRE" code="1#NOMBRE#rayon"/>
        <item algoitem="aire EST_DU_TYPE NOMBRE" code="1#NOMBRE#aire"/>
        <item algoitem="volume EST_DU_TYPE NOMBRE" code="1#NOMBRE#volume"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Ecrire rayon&quot;" code="4#Ecrire rayon#0"/>
        <item algoitem="LIRE rayon" code="2#rayon#pasliste"/>
        <item algoitem="aire PREND_LA_VALEUR 4*Math.PI*pow(rayon,2)" code="5#aire#4*Math.PI*pow(rayon,2)#pasliste"/>
        <item algoitem="AFFICHER &quot;Aire : &quot;" code="4#Aire : #0"/>
        <item algoitem="AFFICHER aire" code="3#aire#1#pasliste"/>
        <item algoitem="volume PREND_LA_VALEUR 4/3*Math.PI*pow(rayon,3)" code="5#volume#4/3*Math.PI*pow(rayon,3)#pasliste"/>
        <item algoitem="AFFICHER &quot;Volume : &quot;" code="4#Volume : #0"/>
        <item algoitem="AFFICHER volume" code="3#volume#0#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
