const myForm = document.getElementById('myForm');
const myName = document.getElementById('myName');
const myBirthDate = document.getElementById('myBirthDate');
const myPhone = document.getElementById('myPhone');
const myPassword1 = document.getElementById('myPassword1');
const myPassword2 = document.getElementById('myPassword2');

myForm.addEventListener('submit', function (event) {
    event.preventDefault();

    // controles de saisies
    const isNameValid = validateName(myName.value);
    const isDateValid = validateBirtDate(myBirthDate.value);
    const isPhoneValid = validatePhoneNumber(myPhone.value);
    /*const isPassword1Valid = validatePassword(myPassword1.value);
    const isPassword2Valid = validatePassword(myPassword2.value);*/

    if(isNameValid && isDateValid && isPhoneValid) {
        alert('Formulaire valide !');
    } else {
        alert('Erreur: Vérifier votre saisie');
    }
});


/** 
 * Valide un nom
 * 3 caractères minimum, uniquement des lettres _name 
 * @param {string} _name le nom à valider
 * @returns {Boolean} VRAI si le nom est valide, FAUX sinon
 */
function validateName(_name) {
    let regexName = /^[A-Za-z]{3,}$/;
    _name = _name.trim();

   /* if(regexName.test(_name)) {
        return true;
    } else {
        return false;
    }*/

    return regexName.test(_name);  
}

/**
 * Contrôle la validité d'une date
 * @param {String} _birthDate la date à vérifier
 * @returns {Boolean} 
 */
function validateBirtDate(_birthDate) {
    console.log(_birthDate);
    try {
        const dateTest = new Date(_birthDate);
        console.log(dateTest);

        if(isNaN(dateTest)) {
            throw new Error();
        } 
        return true;
    } catch(error) {
        alert('Date non valide');
        return false;
    }   
}

/**
 * Valide un numéro de téléphone
 * 0607080910
 * +33607080910
 * @param {*} _phoneNumber 
 * @returns 
 */
function validatePhoneNumber(_phoneNumber) {
    let regexNumber = /^0[0-7|9]\d{8}$/;

    return regexNumber.test(_phoneNumber);
}

/**
 * Valider que les 2 mots de passe sont identiques 
 * ET
 * longueur de 12 caractères minimum
 * au moins 1 majuscule
 * au moins 1 minuscule
 * au moins 1 chiffre
 * @param {*} _password1 
 * @param {*} _password2 
 * @returns 
 */
function validatePassword(_password1, _password2) {
    let regexPassword = /^[A-Za-z][0-9]{12,}$/;
    if((regexPassword.test(_password1) && regexPassword.test(_password2)) && _password1 === _password2) {
        console.log(_password1);
        console.log(_password2);
        return true;
    } else {
        console.log(_password1);
        console.log(_password2);
        return false;
    }
    //return regexPassword.test(_password1);
} 

/*
 test passwords :
    Abcdefghijkl1 = true -- 13 caractères une majuscule et un chiffre
    abcdefghijkl = false -- 12 caractères, sans majuscules et sans chiffre
    Abcdefghijk1
*/