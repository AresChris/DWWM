Variables
    ageA est un entier
Début du programme
    Ecrire "Quel âge avez-vous ? "
    Lire ageA
    SI (ageA < 0) Alors
        Ecrire " Vous n'êtes pas né"
            SINON
                SI (ageA >= 0 ET ageA < 18) Alors
                Ecrire "Vous êtes mineur"
                    SINON
                    Ecrire "Vous êtes majeur"
                    FIN SINON     
Fin du programme