function increaseCount() {
    console.log("increase")
    //var input = b.previousElementSibling;
    @quantity++;


    //var value = parseInt(input.value, 10);
    //value = isNaN(value) ? 0 : value;
    //value++;
    //input.value = value;
}

function decreaseCount() {
    //var input = b.nextElementSibling;
    @quantity--;
    //var value = parseInt(input.value, 10);
    //if (value > 1) {
    //    value = isNaN(value) ? 0 : value;
    //    value--;
    //    input.value = value;
    //}
}

document.getElementById("increase").addEventListener("click", increaseCount());
document.getElementById("decrease").addEventListener("click", decreaseCount());