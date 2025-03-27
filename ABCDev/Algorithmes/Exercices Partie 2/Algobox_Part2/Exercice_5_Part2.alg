<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="DEBUT_SINON" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2defaut="" F2lignes="" F2para="" F2etat="inactif"/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param epaisseurLigne="2" maxBoucle="500000" nbDecimales="8" totalBoucles="5000000" epaisseurPoint="2" totalAffichages="1000" arrondiAuto="vrai"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="nbPrint EST_DU_TYPE NOMBRE" code="1#NOMBRE#nbPrint"/>
        <item algoitem="facture EST_DU_TYPE NOMBRE" code="1#NOMBRE#facture"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Combien de photocopies voulez-vous ? &quot;" code="4#Combien de photocopies voulez-vous ? #0"/>
        <item algoitem="LIRE nbPrint" code="2#nbPrint#pasliste"/>
        <item algoitem="TANT_QUE (nbPrint&lt;0) FAIRE" code="15#nbPrint&lt;0">
            <item algoitem="DEBUT_TANT_QUE" code="16#debuttantque"/>
            <item algoitem="AFFICHER &quot;Le nombre est négatif ! &quot;" code="4#Le nombre est négatif ! #1"/>
            <item algoitem="AFFICHER &quot;Saisissez un nombre positif : &quot;" code="4#Saisissez un nombre positif : #0"/>
            <item algoitem="LIRE nbPrint" code="2#nbPrint#pasliste"/>
            <item algoitem="FIN_TANT_QUE" code="17#fintantque"/>
        </item>
        <item algoitem="SI (nbPrint >=0 et nbPrint &lt;=10) ALORS" code="6#nbPrint >=0 et nbPrint &lt;=10">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="facture PREND_LA_VALEUR nbPrint*0.10" code="5#facture#nbPrint*0.10#pasliste"/>
            <item algoitem="AFFICHER &quot;La facture est de : &quot;" code="4#La facture est de : #0"/>
            <item algoitem="AFFICHER facture" code="3#facture#0#pasliste"/>
            <item algoitem="AFFICHER &quot; €&quot;" code="4# €#0"/>
            <item algoitem="FIN_SI" code="8#finsi"/>
            <item algoitem="SINON" code="9#sinon">
                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                <item algoitem="SI (nbPrint >=11 et nbPrint&lt;=20) ALORS" code="6#nbPrint >=11 et nbPrint&lt;=20">
                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                    <item algoitem="facture PREND_LA_VALEUR nbPrint*0.9" code="5#facture#nbPrint*0.9#pasliste"/>
                    <item algoitem="AFFICHER &quot;La facture est de : &quot;" code="4#La facture est de : #0"/>
                    <item algoitem="AFFICHER facture" code="3#facture#0#pasliste"/>
                    <item algoitem="AFFICHER &quot; €&quot;" code="4# €#0"/>
                    <item algoitem="FIN_SI" code="8#finsi"/>
                    <item algoitem="SINON" code="9#sinon">
                        <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                        <item algoitem="facture PREND_LA_VALEUR nbPrint*0.08" code="5#facture#nbPrint*0.08#pasliste"/>
                        <item algoitem="AFFICHER &quot;La facture est de : &quot;" code="4#La facture est de : #0"/>
                        <item algoitem="AFFICHER facture" code="3#facture#0#pasliste"/>
                        <item algoitem="AFFICHER &quot; €&quot;" code="4# €#0"/>
                        <item algoitem="FIN_SINON" code="11#finsinon"/>
                    </item>
                </item>
                <item algoitem="FIN_SINON" code="11#finsinon"/>
            </item>
        </item>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
