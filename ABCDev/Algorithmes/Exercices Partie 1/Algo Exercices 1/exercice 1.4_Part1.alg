<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="interetCompose PREND_LA_VALEUR somme*pow((1+interet/100),annees)"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2defaut="" F2lignes="" F2etat="inactif" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalAffichages="1000" totalBoucles="5000000" epaisseurPoint="2" nbDecimales="8" arrondiAuto="vrai" epaisseurLigne="2" maxBoucle="500000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="somme EST_DU_TYPE NOMBRE" code="1#NOMBRE#somme"/>
        <item algoitem="interet EST_DU_TYPE NOMBRE" code="1#NOMBRE#interet"/>
        <item algoitem="annees EST_DU_TYPE NOMBRE" code="1#NOMBRE#annees"/>
        <item algoitem="interetSimple EST_DU_TYPE NOMBRE" code="1#NOMBRE#interetSimple"/>
        <item algoitem="interetCompose EST_DU_TYPE NOMBRE" code="1#NOMBRE#interetCompose"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Taux d'interet&quot;" code="4#Taux d'interet#1"/>
        <item algoitem="LIRE interet" code="2#interet#pasliste"/>
        <item algoitem="AFFICHER &quot;Quelle somme déposer ?&quot;" code="4#Quelle somme déposer ?#1"/>
        <item algoitem="LIRE somme" code="2#somme#pasliste"/>
        <item algoitem="AFFICHER &quot;Combien de temps ? (en années)&quot;" code="4#Combien de temps ? (en années)#1"/>
        <item algoitem="LIRE annees" code="2#annees#pasliste"/>
        <item algoitem="interetSimple PREND_LA_VALEUR somme*(1+annees*interet/100)" code="5#interetSimple#somme*(1+annees*interet/100)#pasliste"/>
        <item algoitem="AFFICHER &quot;interêt simples :&quot;" code="4#interêt simples :#1"/>
        <item algoitem="AFFICHER interetSimple" code="3#interetSimple#1#pasliste"/>
        <item algoitem="interetCompose PREND_LA_VALEUR somme*pow((1+interet/100),annees)" code="5#interetCompose#somme*pow((1+interet/100),annees)#pasliste"/>
        <item algoitem="AFFICHER &quot;Interêt composé :&quot;" code="4#Interêt composé :#0"/>
        <item algoitem="AFFICHER interetCompose" code="3#interetCompose#0#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
