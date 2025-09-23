let identifiant = document.getElementById('identifiant');
let reponse = await fetch('./tableau.json');
let utilisateurs = await reponse.json();
console.log(utilisateurs);


for(let i = 0; i < utilisateurs.length; i++) {
    let utilisateurCourant = utilisateurs[i];
    
    console.log(utilisateurCourant.lastname);
}
