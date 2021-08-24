const typeSchedules = [
  {
    name: "morning",
    recharge: 0.1,
  },
  {
    name: "night",
    recharge: 0.2,
  },
  {
    name: "extra",
    recharge: 0,
  },
];

const riskTypes = [
  {
    type: "I",
    percent: 0.0125,
  },
  {
    type: "II",
    percent: 0.0225,
  },
  {
    type: "III",
    percent: 0.0325,
  },
  {
    type: "IV",
    percent: 0.0425,
  },
  {
    type: "V",
    percent: 0.0525,
  },
];

const minimalSalary = 908526;
let generalReductions = 0;

function numberWithCommas(x) {
  return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}

$(document).ready(function () {
  $("#reductionHealth").text(`- $ ${numberWithCommas(minimalSalary * 0.15)}`);
  $("#reductionPension").text(`- $ ${numberWithCommas(minimalSalary * 0.145)}`);
  generalReductions = minimalSalary * 0.15 + minimalSalary * 0.145;

  $("#schedule").change(() => {
    const currentType = typeSchedules.find(
      (oneSchedule) => oneSchedule.name === $("#schedule option:selected").val()
    );
    $("#scheduleAlert").text(
      `Recargo de horas extra del ${currentType.recharge * 100}%`
    );
    $("#rechargeExtras").text(
      `+ $ ${numberWithCommas(minimalSalary * currentType.recharge)}`
    );

    const currentRisk = riskTypes.find(
      (oneRisk) => oneRisk.type === $("#risk option:selected").val()
    );
    $("#final").text(
      `$ ${numberWithCommas(
        parseInt(
          minimalSalary +
            minimalSalary * currentType.recharge -
            generalReductions -
            minimalSalary * currentRisk.percent
        )
      )}`
    );
  });

  $("#risk").change(() => {
    const currentRisk = riskTypes.find(
      (oneRisk) => oneRisk.type === $("#risk option:selected").val()
    );
    $("#riskAlert").text(
      `Deducción por riesgo ${$("#risk option:selected").val()} del ${
        currentRisk.percent * 100
      }%`
    );
    $("#reductionProfessional").text(
      `+ $ ${numberWithCommas(minimalSalary * currentRisk.percent)}`
    );

    const currentType = typeSchedules.find(
      (oneSchedule) => oneSchedule.name === $("#schedule option:selected").val()
    );
    $("#final").text(
      `$ ${numberWithCommas(
        parseInt(
          minimalSalary +
            minimalSalary * currentType.recharge -
            generalReductions -
            minimalSalary * currentRisk.percent
        )
      )}`
    );
  });
});
