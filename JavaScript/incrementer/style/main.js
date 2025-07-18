let compteur = 0;

    function incrementer() {
        compteur++;
        document.getElementById("compteur").textContent = compteur;
    }
    function reinitialiser() {
        compteur = 0;
        document.getElementById("compteur").textContent = compteur;
    }