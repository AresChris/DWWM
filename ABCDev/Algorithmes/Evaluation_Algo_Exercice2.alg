<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="AFFICHER mail"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2etat="inactif" F2defaut="" F2lignes="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalBoucles="5000000" epaisseurPoint="2" totalAffichages="1000" arrondiAuto="vrai" nbDecimales="8" epaisseurLigne="2" maxBoucle="500000"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#CHAINE#nom" algoitem="nom EST_DU_TYPE CHAINE"/>
        <item code="1#CHAINE#prenom" algoitem="prenom EST_DU_TYPE CHAINE"/>
        <item code="1#CHAINE#mail" algoitem="mail EST_DU_TYPE CHAINE"/>
        <item code="1#CHAINE#point" algoitem="point EST_DU_TYPE CHAINE"/>
        <item code="1#NOMBRE#departement" algoitem="departement EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Inscrivez votre nom #0" algoitem="AFFICHER &quot;Inscrivez votre nom &quot;"/>
        <item code="2#nom#pasliste" algoitem="LIRE nom"/>
        <item code="4#Inscrivez votre prénom #0" algoitem="AFFICHER &quot;Inscrivez votre prénom &quot;"/>
        <item code="2#prenom#pasliste" algoitem="LIRE prenom"/>
        <item code="4#Inscrivez votre département : #0" algoitem="AFFICHER &quot;Inscrivez votre département : &quot;"/>
        <item code="2#departement#pasliste" algoitem="LIRE departement"/>
        <item code="5#mail#&quot;@arfp.asso.fr&quot;#pasliste" algoitem="mail PREND_LA_VALEUR &quot;@arfp.asso.fr&quot;"/>
        <item code="5#point#&quot;.&quot;#pasliste" algoitem="point PREND_LA_VALEUR &quot;.&quot;"/>
        <item code="4#Mail 1 : #0" algoitem="AFFICHER &quot;Mail 1 : &quot;"/>
        <item code="3#nom#0#pasliste" algoitem="AFFICHER nom"/>
        <item code="3#prenom#0#pasliste" algoitem="AFFICHER prenom"/>
        <item code="3#departement#0#pasliste" algoitem="AFFICHER departement"/>
        <item code="3#mail#1#pasliste" algoitem="AFFICHER mail"/>
        <item code="4#Mail 2 : #0" algoitem="AFFICHER &quot;Mail 2 : &quot;"/>
        <item code="3#prenom#0#pasliste" algoitem="AFFICHER prenom"/>
        <item code="3#point#0#pasliste" algoitem="AFFICHER point"/>
        <item code="3#nom#0#pasliste" algoitem="AFFICHER nom"/>
        <item code="3#point#0#pasliste" algoitem="AFFICHER point"/>
        <item code="3#departement#0#pasliste" algoitem="AFFICHER departement"/>
        <item code="3#mail#0#pasliste" algoitem="AFFICHER mail"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
