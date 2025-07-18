let fontSize = 16;
let increase = document.getElementById("increase");
let decrease = document.getElementById("decrease");
let tailleActuelle = document.getElementById("tailleActuelle");
let texte = document.getElementById("texte");

function increaseSize() {
  if (fontSize < 32) {
    fontSize += 1;
  } else {
    fontSize = 16;
  }
}

function decreaseSize() {
  if (fontSize >= 8) {
    fontSize -= 1;
  } else {
    fontSize = 16;
  }
}

increase.addEventListener("click", function (event) {
  increaseSize();
  tailleActuelle.innerText = fontSize;
  texte.style.fontSize = fontSize + "px";
});

decrease.addEventListener("click", function (event) {
  decreaseSize();
  tailleActuelle.innerText = fontSize;
  texte.style.fontSize = fontSize + "px";
});

textarea.addEventListener("input", function () {
  const size = parseInt(this.value, 10);
  if (!isNaN(size) && size > 0) {
    texte.style.fontSize = size + "px";
    tailleActuelle.textContent = size;
  }
});
