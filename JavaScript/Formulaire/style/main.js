const nameInput = document.getElementById("nameInput")
const ageInput = document.getElementById("ageInput")
const nameDisplay = document.getElementById("name")
const ageDisplay = document.getElementById("age")
const valider = document.getElementById("valider")
const vider = document.getElementById("vider")
const majeur = document.getElementById("majeur")
const retraite = document.getElementById("retraite")

function displayValues() {
  const name = nameInput.value.trim();
  const age = parseInt(ageInput.value);

  nameDisplay.textContent = nameInput.value
  ageDisplay.textContent = ageInput.value

  if(!isNaN(age))
  {
    if(age === 64)
    {
      majeur.textContent = "majeur"
      retraite.textContent = "Vous prenez votre retraite cette année"
    }
    if(age >=18 && age < 64) {
        majeur.textContent = "majeur"
        retraite.textContent = "Il vous reste " + (64 - age) + " annnées avant la retraite"
    } else if(age < 18){
        majeur.textContent = "mineur"
        retraite.textContent = "Il vous reste " + (64 - age) + " années avant la retraite"
    }
    else if(age >64)
    {
        majeur.textContent = "majeur"
        retraite.textContent = " Vous êtes à la retraite depuis " + (age - 64) + " années"
    }
  } else{
    messageMaj.textContent = ""
  }  
}

function displayName() {
  document.getElementById("nameInput").addEventListener("input", function () {
    document.getElementById("name").textContent = this.value
  });
}

function displayAge() {
  document.getElementById("ageInput").addEventListener("input", function () {
    document.getElementById("age").textContent = this.value
  });
}

function empty() {
  document.getElementById("nameInput").value = ""
  document.getElementById("ageInput").value = ""
  document.getElementById("name").textContent = ""
  document.getElementById("age").textContent = ""
  document.removeChild("majeur").textContent = ""
  document.removeChild("retraite").textContent = ""
}
valider.addEventListener("click", displayValues)
vider.addEventListener("click", empty)
