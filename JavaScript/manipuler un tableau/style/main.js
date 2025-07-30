const tableBody = document.getElementById("tableBody");
const ajouter = document.getElementById("ajouter");
const prenomInput = document.getElementById("prenom");
const nomInput = document.getElementById("nom");
const people = ["Mike Dev", "John Makenzie", "Léa Grande"];
const fieldset = document.querySelectorAll("fieldset");
const targetFieldset = fieldset;
const liste = document.getElementById('liste');

//   people.forEach((person) => {
//   const li = document.createElement("li");
//    li.textContent = person;
//    ul.appendChild(li);
//  });


  for (let person of people) {
    
    let [prenom, nom] = person.split(" ");

    let tr = document.createElement("tr");
    let tdPrenom = document.createElement("td");
    let tdNom = document.createElement("td");
    let tdMail = document.createElement("td");
    let btnSupprimer = document.createElement("button");

    tdPrenom.textContent = prenom;
    tdNom.textContent = nom;
    tdMail.textContent = person.replace(" ", ".") + "@exemple.com";
    btnSupprimer.textContent = "X";

    tr.append(tdPrenom, tdNom, tdMail, btnSupprimer);
    btnSupprimer.addEventListener("click", function () {
      const ligne = this.closest("tr");
      ligne.remove();
    });

    tableBody.appendChild(tr);
  }

  
  ajouter.addEventListener("click", () => {
    const prenom = prenomInput.value.trim();
    const nom = nomInput.value.trim();

    if (prenom && nom) {

      const fullName = `${prenom} ${nom}`;
      
      if (people.includes(fullName))
        {
          alert("Cette personne est déjà connue !");
          return;
        }
        else
        {
          people.push(fullName);
        }


      const li = document.createElement("li");
      li.textContent = fullName;
      document.getElementById('liste').appendChild(li);

      const tr = document.createElement("tr");
      const tdPrenom = document.createElement("td");
      const tdNom = document.createElement("td");
      const tdMail = document.createElement("td");
      const btnSupprimer = document.createElement("button");

      tdPrenom.textContent = prenom;
      tdNom.textContent = nom;
      tdMail.textContent = `${prenom}.${nom}@exemple.com`;
      btnSupprimer.textContent = "X";

      btnSupprimer.addEventListener("click", function () {
        const ligne = this.closest("tr");
        ligne.remove();
      });

      tr.append(tdPrenom, tdNom, tdMail, btnSupprimer);
      tableBody.appendChild(tr);

      const message = document.createElement("p");
      message.textContent = `${prenom} ${nom} a été ajouté.`;
      people.push = `${prenom} ${nom}`;
      fieldset[0].appendChild(message);

        
    } else {
      alert("Veuillez remplir les deux champs !");
    }
  });
  //const ul = document.createElement("ul");

  people.forEach((person) => {
    const li = document.createElement("li");
    li.textContent = person;
    document.getElementById('liste').append(li);
  });




