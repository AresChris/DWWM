const credits = document.getElementById('credits');
const username = document.getElementById('username');
const validate = document.getElementById('validate');
const password1 = document.getElementById('password1');
const password2 = document.getElementById('password2');

document.getElementById('credits').textContent = ('Christopher Ares');

function checkUsernamePassword(event){
    event.preventDefault();
    if(username.value.length < 3)
        {
        return result.textContent = "Le nom d'utilisateur est trop court (3 caractères minimum)";
        } 
    else if(password1.value.length <12 || password2.value.length <12)
        {
        return result.textContent = "Le mot de passe est trop court";
        } 
    else if(password1.value != password2.value) 
        {
        return result.textContent= "Les mot de passe ne correspondent pas";
        } 
    else
        {
        return result.textContent = "Le formulaire est valide !";
    }
}
validate.addEventListener('click', checkUsernamePassword);
