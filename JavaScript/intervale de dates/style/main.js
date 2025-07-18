const myDate = document.getElementById('myDate');
const hour = document.getElementById('hour');

function displayDateHour()
{
    let userDate = myDate.value; // Récupère la valeur du champ sous forme de chaine de caractères
    userDate = Date.parse(userDate); // Convertit la chaine et nombre de millisecondes depuis EPOCH
    userDate = new Date(userDate); // Crée une instance de Date 
    today = new Date(); // date d'aujourd'hui

    let dateFr = userDate.toLocaleDateString('fr-FR'); // Récupération de la date au format Français (DD/MM/YYYY)
    let timeFr = userDate.toLocaleTimeString(); // Récupération de l'heure au format HH:II:SS

    date.textContent(today);
}

display.addEventListener('click', displayDateHour);