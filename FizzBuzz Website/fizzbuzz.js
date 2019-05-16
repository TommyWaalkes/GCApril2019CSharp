function fizzBuzz() {

    console.log("Hello World");
    //let input = prompt("Please input a number");
    let input = document.getElementById("fizbiz").value;
    console.log(input);

    if (input % 3 === 0 && input % 5 === 0) {
        console.log("fizzbuzz");
    }
    else if (input % 3 === 0) {
        console.log("fizz");
    }
    else if (input % 5 === 0) {
        console.log("buzz");
    }

}