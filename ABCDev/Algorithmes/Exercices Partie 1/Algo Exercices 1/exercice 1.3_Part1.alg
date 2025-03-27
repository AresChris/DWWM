<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER &quot;entrer rayon : &quot;" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2lignes="" F2para="" F2etat="inactif" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param epaisseurPoint="2" arrondiAuto="vrai" nbDecimales="8" totalAffichages="1000" epaisseurLigne="2" totalBoucles="5000000" maxBoucle="500000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="rayon EST_DU_TYPE NOMBRE" code="1#NOMBRE#rayon"/>
        <item algoitem="angle EST_DU_TYPE NOMBRE" code="1#NOMBRE#angle"/>
        <item algoitem="aireSecteurCirculaire EST_DU_TYPE NOMBRE" code="1#NOMBRE#aireSecteurCirculaire"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;entrer rayon : &quot;" code="4#entrer rayon : #0"/>
        <item algoitem="LIRE rayon" code="2#rayon#pasliste"/>
        <item algoitem="AFFICHER &quot;entrer angle : &quot;" code="4#entrer angle : #0"/>
        <item algoitem="LIRE angle" code="2#angle#pasliste"/>
        <item algoitem="aireSecteurCirculaire PREND_LA_VALEUR (Math.PI*pow(rayon,2)*angle)/360" code="5#aireSecteurCirculaire#(Math.PI*pow(rayon,2)*angle)/360#pasliste"/>
        <item algoitem="AFFICHER &quot;l'aire du secteur circulaire = &quot;" code="4#l'aire du secteur circulaire = #0"/>
        <item algoitem="AFFICHER aireSecteurCirculaire" code="3#aireSecteurCirculaire#1#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
