// Création d'une variable = cherche dans le document.fonction pour 
// trouver tous les button des tableaux
  const boutonsSupprimer = document.querySelectorAll("table button");

    boutonsSupprimer.forEach(button => {
    button.addEventListener("click", function () {
    const ligne = this.closest("tr"); // Trouve le tr le plus proche
    ligne.remove(); // Supprime le tr le plus proche qui s'appel ligne
    });
});
