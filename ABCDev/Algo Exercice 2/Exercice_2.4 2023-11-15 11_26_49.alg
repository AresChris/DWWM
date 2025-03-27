<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="SI (anneeA/100 != floor(anneeA) ET anneeA/400 != floor(anneeA)) ALORS"/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2etat="inactif" F2para="" F2lignes="" F2defaut=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param nbDecimales="8" epaisseurLigne="2" arrondiAuto="vrai" epaisseurPoint="2" totalBoucles="5000000" totalAffichages="1000" maxBoucle="500000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="anneeA EST_DU_TYPE NOMBRE" code="1#NOMBRE#anneeA"/>
        <item algoitem="bissextile EST_DU_TYPE NOMBRE" code="1#NOMBRE#bissextile"/>
        <item algoitem="nonBissextile EST_DU_TYPE NOMBRE" code="1#NOMBRE#nonBissextile"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Quelle année ? : &quot;" code="4#Quelle année ? : #0"/>
        <item algoitem="LIRE anneeA" code="2#anneeA#pasliste"/>
        <item algoitem="AFFICHER &quot;Valeur de anneeA = &quot;" code="4#Valeur de anneeA = #0"/>
        <item algoitem="AFFICHER anneeA" code="3#anneeA#1#pasliste"/>
        <item algoitem="SI (anneeA/100 != floor(anneeA) ET anneeA/400 != floor(anneeA)) ALORS" code="6#anneeA/100 != floor(anneeA) ET anneeA/400 != floor(anneeA)">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="SI (anneeA/4 == floor(anneeA)) ALORS" code="6#anneeA/4 == floor(anneeA)">
                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                <item algoitem="AFFICHER &quot;L'année est bissextile ! &quot;" code="4#L'année est bissextile ! #0"/>
                <item algoitem="FIN_SI" code="8#finsi"/>
            </item>
            <item algoitem="FIN_SI" code="8#finsi"/>
            <item algoitem="SINON" code="9#sinon">
                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                <item algoitem="SI (anneeA/100 == floor(anneeA) ET anneeA/400 == floor(anneeA)) ALORS" code="6#anneeA/100 == floor(anneeA) ET anneeA/400 == floor(anneeA)">
                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                    <item algoitem="SI (anneeA/4 != floor(anneeA)) ALORS" code="6#anneeA/4 != floor(anneeA)">
                        <item algoitem="DEBUT_SI" code="7#debutsi"/>
                        <item algoitem="AFFICHER &quot;L'année n'est pas bissextile !&quot;" code="4#L'année n'est pas bissextile !#0"/>
                        <item algoitem="FIN_SI" code="8#finsi"/>
                    </item>
                    <item algoitem="FIN_SI" code="8#finsi"/>
                </item>
                <item algoitem="FIN_SINON" code="11#finsinon"/>
            </item>
        </item>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
