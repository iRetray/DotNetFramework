function numberWithCommas(x) {
  return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}

function applyDiscount(percentDiscount, subtotal) {
  if (percentDiscount !== 0) {
    $("#discountLabel").text(
      `Obtenido un descuento del ${percentDiscount * 100}%`
    );
    $("#discount").text(`- $ ${numberWithCommas(subtotal * percentDiscount)}`);
    $("#bonus").show();
  } else {
    $("#bonus").hide();
  }
  return percentDiscount === 0 ? 0 : subtotal - subtotal * percentDiscount;
}

$(document).ready(function () {
  $("#bonus").hide();

  $("#valueProduct").keyup(() => {
    const currentPrice = $("#valueProduct").val();
    const mainIVA = parseInt(currentPrice * 0.16);
    const subtotal = parseInt(currentPrice) + mainIVA;
    const total = applyDiscount(
      mainIVA >= 1000 && mainIVA <= 1999
        ? 0.02
        : (mainIVA >= 2000 && mainIVA <= 4999) || mainIVA >= 5000
        ? 0.06
        : 0,
      subtotal
    );
    $("#mainIVA").text(`+ $ ${numberWithCommas(mainIVA)}`);
    $("#subtotal").text(`$ ${numberWithCommas(subtotal)}`);
    $("#total").text(`$ ${numberWithCommas(total)}`);
  });
});
