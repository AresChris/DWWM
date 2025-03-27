<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="FIN_SI"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2defaut="" F2para="" F2etat="inactif" F2lignes=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param totalAffichages="1000" epaisseurPoint="2" maxBoucle="500000" nbDecimales="8" totalBoucles="5000000" arrondiAuto="vrai" epaisseurLigne="2"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="a EST_DU_TYPE NOMBRE" code="1#NOMBRE#a"/>
        <item algoitem="b EST_DU_TYPE NOMBRE" code="1#NOMBRE#b"/>
        <item algoitem="c EST_DU_TYPE NOMBRE" code="1#NOMBRE#c"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Valeur de a = &quot;" code="4#Valeur de a = #0"/>
        <item algoitem="LIRE a" code="2#a#pasliste"/>
        <item algoitem="AFFICHER &quot;Valeur de b = &quot;" code="4#Valeur de b = #0"/>
        <item algoitem="LIRE b" code="2#b#pasliste"/>
        <item algoitem="AFFICHER &quot;Valeur de c = &quot;" code="4#Valeur de c = #0"/>
        <item algoitem="LIRE c" code="2#c#pasliste"/>
        <item algoitem="SI (a&lt;b et b&lt;c) ALORS" code="6#a&lt;b et b&lt;c">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="AFFICHER &quot;a = &quot;" code="4#a = #0"/>
            <item algoitem="AFFICHER a" code="3#a#1#pasliste"/>
            <item algoitem="AFFICHER &quot;b = &quot;" code="4#b = #0"/>
            <item algoitem="AFFICHER b" code="3#b#1#pasliste"/>
            <item algoitem="AFFICHER &quot;c = &quot;" code="4#c = #0"/>
            <item algoitem="AFFICHER c" code="3#c#1#pasliste"/>
            <item algoitem="FIN_SI" code="8#finsi"/>
            <item algoitem="SINON" code="9#sinon">
                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                <item algoitem="SI (b&lt;c et c&lt;a) ALORS" code="6#b&lt;c et c&lt;a">
                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                    <item algoitem="AFFICHER &quot;b = &quot;" code="4#b = #0"/>
                    <item algoitem="AFFICHER b" code="3#b#1#pasliste"/>
                    <item algoitem="AFFICHER &quot;c = &quot;" code="4#c = #0"/>
                    <item algoitem="AFFICHER c" code="3#c#1#pasliste"/>
                    <item algoitem="AFFICHER &quot;a = &quot;" code="4#a = #0"/>
                    <item algoitem="AFFICHER a" code="3#a#1#pasliste"/>
                    <item algoitem="FIN_SI" code="8#finsi"/>
                    <item algoitem="SINON" code="9#sinon">
                        <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                        <item algoitem="SI (c&lt;a et a&lt;b) ALORS" code="6#c&lt;a et a&lt;b">
                            <item algoitem="DEBUT_SI" code="7#debutsi"/>
                            <item algoitem="AFFICHER &quot;c = &quot;" code="4#c = #0"/>
                            <item algoitem="AFFICHER c" code="3#c#1#pasliste"/>
                            <item algoitem="AFFICHER &quot;a = &quot;" code="4#a = #0"/>
                            <item algoitem="AFFICHER a" code="3#a#1#pasliste"/>
                            <item algoitem="AFFICHER &quot;b = &quot;" code="4#b = #0"/>
                            <item algoitem="AFFICHER b" code="3#b#1#pasliste"/>
                            <item algoitem="FIN_SI" code="8#finsi"/>
                            <item algoitem="SINON" code="9#sinon">
                                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                                <item algoitem="SI (a&lt;c et c&lt;b) ALORS" code="6#a&lt;c et c&lt;b">
                                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                                    <item algoitem="AFFICHER &quot;a = &quot;" code="4#a = #0"/>
                                    <item algoitem="AFFICHER a" code="3#a#1#pasliste"/>
                                    <item algoitem="AFFICHER &quot;c = &quot;" code="4#c = #0"/>
                                    <item algoitem="AFFICHER c" code="3#c#1#pasliste"/>
                                    <item algoitem="AFFICHER &quot;b = &quot;" code="4#b = #0"/>
                                    <item algoitem="AFFICHER b" code="3#b#1#pasliste"/>
                                    <item algoitem="FIN_SI" code="8#finsi"/>
                                    <item algoitem="SINON" code="9#sinon">
                                        <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                                        <item algoitem="SI (b&lt;a et a&lt;c) ALORS" code="6#b&lt;a et a&lt;c">
                                            <item algoitem="DEBUT_SI" code="7#debutsi"/>
                                            <item algoitem="AFFICHER &quot;b = &quot;" code="4#b = #0"/>
                                            <item algoitem="AFFICHER b" code="3#b#1#pasliste"/>
                                            <item algoitem="AFFICHER &quot;a = &quot;" code="4#a = #0"/>
                                            <item algoitem="AFFICHER a" code="3#a#1#pasliste"/>
                                            <item algoitem="AFFICHER &quot;c = &quot;" code="4#c = #0"/>
                                            <item algoitem="AFFICHER c" code="3#c#1#pasliste"/>
                                            <item algoitem="FIN_SI" code="8#finsi"/>
                                            <item algoitem="SINON" code="9#sinon">
                                                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                                                <item algoitem="SI (c&lt;b et b&lt;a) ALORS" code="6#c&lt;b et b&lt;a">
                                                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                                                    <item algoitem="AFFICHER &quot;c = &quot;" code="4#c = #0"/>
                                                    <item algoitem="AFFICHER c" code="3#c#1#pasliste"/>
                                                    <item algoitem="AFFICHER &quot;b = &quot;" code="4#b = #0"/>
                                                    <item algoitem="AFFICHER b" code="3#b#1#pasliste"/>
                                                    <item algoitem="AFFICHER &quot;a = &quot;" code="4#a = #0"/>
                                                    <item algoitem="AFFICHER a" code="3#a#1#pasliste"/>
                                                    <item algoitem="FIN_SI" code="8#finsi"/>
                                                </item>
                                                <item algoitem="FIN_SINON" code="11#finsinon"/>
                                            </item>
                                        </item>
                                        <item algoitem="FIN_SINON" code="11#finsinon"/>
                                    </item>
                                </item>
                                <item algoitem="FIN_SINON" code="11#finsinon"/>
                            </item>
                        </item>
                        <item algoitem="FIN_SINON" code="11#finsinon"/>
                    </item>
                </item>
                <item algoitem="FIN_SINON" code="11#finsinon"/>
            </item>
        </item>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
