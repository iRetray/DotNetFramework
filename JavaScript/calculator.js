function addNumbers(number1, number2) {
  return parseInt(number1) + parseInt(number2);
}

const inputNumber1 = document.querySelector("#inputNumber1");
inputNumber1.addEventListener("input", (event) => {
  const inputNumber2 = document.querySelector("#inputNumber2");
  const buttonFinal = document.querySelector("#buttonFinal");
  buttonFinal.innerHTML =
    "El resultado de la suma es: " +
    addNumbers(event.target.value, inputNumber2 ? inputNumber2.value : 0);
});

const inputNumber2 = document.querySelector("#inputNumber2");
inputNumber2.addEventListener("input", (event) => {
  const inputNumber1 = document.querySelector("#inputNumber1");
  const buttonFinal = document.querySelector("#buttonFinal");
  buttonFinal.innerHTML =
    "El resultado de la suma es: " +
    addNumbers(event.target.value, inputNumber1 ? inputNumber1.value : 0);
});
