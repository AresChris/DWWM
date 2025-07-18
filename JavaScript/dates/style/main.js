let today;
const myDate = document.getElementById('myDate');
const calculate = document.getElementById('calculate');
const result = document.getElementById('result');
const astro = document.getElementById('astro')

/**
 * Calcule l'age à partir de la date fournie dans le champ "myDate"
 * 1. Récupérer la valeur dans le champ "myDate"
 * 2. Vérifier la validité de la date (format, date dans le passé)
 *      2.1 : Si la date est incorrecte : afficher le message d'erreur
 *      2.2 : Retour à l'étape 1
 * 3. Afficher la date au format français (DD/MM/YYYY) et l'heure au format (HH:II:SS).
 * 4. Calculer et afficher l'âge à partir de la date fournie.
 * 
 */
function calculateAge() {
    result.textContent = ""; 
    let userDate = myDate.value; // Récupère la valeur du champ sous forme de chaine de caractères
    userDate = Date.parse(userDate); // Convertit la chaine et nombre de millisecondes depuis EPOCH
    userDate = new Date(userDate); // Crée une instance de Date 
    today = new Date(); // date d'aujourd'hui

    if(userDate > today) {
        result.textContent = "ERREUR : Sélectionnez une date dans le passé.";
        return;
    }

    let dateFr = userDate.toLocaleDateString('fr-FR'); // Récupération de la date au format Français (DD/MM/YYYY)
    let timeFr = userDate.toLocaleTimeString(); // Récupération de l'heure au format HH:II:SS

    result.innerHTML = "Vous êtes né(e) le <span>" + dateFr + "</span> à <span>" + timeFr + "</span>";

    let dateDiff = today - userDate;
    dateDiff = dateDiff / 1000 / 60 / 60 / 24 / 365.25; // convertit millescondes en années
    dateDiff = Math.floor(dateDiff); // on conserve la partie entière du nombre, on aurait pu utiliser "parseInt(dateDiff)"

    result.innerHTML += "<br><br>Il s'est écoulé " + dateDiff + " année(s) depuis votre naissance";
    getMonth(userDate);
}
function getMonth(userDate) {
    astro.textContent = ""
    day = userDate.getDate();
    month = userDate.getMonth();

    if((month === 0 && day >= 20) || (month === 1 && day <= 18))
    {
        astro.textContent = "Verseau";
        return;
    }
    else if((month === 1 && day >=19) || (month === 2 && day <= 20))
    {
        astro.textContent = "Poisson"
    }
    else if((month === 2 && day >= 21) || (month === 3 && day <= 19))
    {
        astro.textContent = "Bélier"
    }
    else if ((month === 3 && day >20) || (month === 4 && day <= 20))
    {
        astro.textContent = "Taureau"
    }
    else if((month === 4 && day >= 21) || (month === 5 && day <= 20))
    {
        astro.textContent = "Gémeaux"
    }
    else if((month === 5 && day >= 21) || (month === 6 && day <= 22))
    {
        astro.textContent = "Cancer"
    }
    else if((month === 6 && day >=23) || (month === 7 && day <=22))
    {
        astro.textContent = "Lion"
    }
    else if((month === 7 && day >= 23) || (month === 8 && day <= 22))
    {
        astro.textContent = "Vierge"
    }
    else if((month === 8 && day >= 23) || (month === 9 && day <= 22))
    {
        astro.textContent = "Balance"
    }
    else if((month === 9 && day >= 23) || (month === 10 && day <= 21))
    {
        astro.textContent = "Scorpion"
    }
    else if((month === 10 && day >= 22) || (month === 11 && day <= 21))
    {
        astro.textContent = "Sagitaire"
    }
    else if((month === 11 && day >= 22) || (month === 0 && day <= 19))
    {
        astro.textContent = "Capricorne"
    }
    else{
        astro.textContent =  "signe inconnu";
        return;
    }
}

calculate.addEventListener('click', calculateAge);

/*
 si le mois est janvier et que le jour est superieur égal à 20 et inferieur égal à 31 ou le mois est février et le jour inferieur égal à 18
    si le mois est janvier
*/