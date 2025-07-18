// const monBouton = window // accède à tous les élément de la fenêtre
const monBouton2 = document.getElementById("#monBouton"); // accède à l'élément avec l'id "monBouton"

console.log(monBouton2); // affiche l'élément dans la console

setInterval(() => {
    monBouton.innerText = 'mon super bouton' + i++; // modifie le texte de l'élément
}, 2000);                               //i++ incrémente de 1 toutes les 2000ms(2s)


var mavariable1; // portée FONCTION
let variable2; // portée BLOC
const variable3 = 42;
variableGlobale =1; //interdit car accessible de partout

function maFonction()
{
    {
        let toto = "toto"; // n'est pas accessible en dehors de ce bloc
        tata = "titi"; // accessible de partout
        const titi ="Tonton"; 
    }
    console.log(toto, tata); // toto n'est pas défini, tata est accessible
}

//let et const ont une portée plus faible que var 
