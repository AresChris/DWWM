let userDate = null; // On déclare userDate ici pour qu'elle soit accessible partout

function displayDateHour() {
    const dateValue = document.getElementById("currentDate").value;
    const timeValue = document.getElementById("currentTime").value;

    if (dateValue && timeValue) {
        userDate = new Date(`${dateValue}T${timeValue}`);
        const dateFr = userDate.toLocaleDateString('fr-FR');
        const timeFr = userDate.toLocaleTimeString('fr-FR');

        document.getElementById("date").textContent = dateFr;
        document.getElementById("hour").textContent = timeFr;
    } else {
        document.getElementById("date").textContent = "non sélectionnée";
        document.getElementById("hour").textContent = "non sélectionnée";
    }
}

function calculInterval() {
    const dateValue = document.getElementById("currentDate").value;
    const timeValue = document.getElementById("currentTime").value;
    const nextDateValue = document.getElementById("nextDate").value;

    if (dateValue && timeValue && nextDateValue) {
        userDate = new Date(`${dateValue}T${timeValue}`);
        const nextDate = new Date(nextDateValue);

        const dateFr = userDate.toLocaleDateString('fr-FR');
        const timeFr = userDate.toLocaleTimeString('fr-FR');

        // Calcul de la différence en millisecondes
        const diffTime = nextDate.getTime() - userDate.getTime();
       
        // Conversion en jours
        const diffDays = Math.round(diffTime / (1000 * 60 * 60 * 24));

        document.getElementById("date2").textContent = nextDate.toLocaleDateString();
        document.getElementById("hour2").textContent = nextDate.toLocaleTimeString();
        document.getElementById("timeDiff").textContent = diffDays;
    } else {
        document.getElementById("date2").textContent = "non sélectionnée";
        document.getElementById("hour2").textContent = "non sélectionnée";
        document.getElementById("timeDiff").textContent = "";
    }
    displayDateHour();
}

    document.getElementById("display").addEventListener('click', displayDateHour);
    document.getElementById("calculInterval").addEventListener('click', calculInterval);
