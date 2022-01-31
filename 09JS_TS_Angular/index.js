console.log("I'm an external js file")

if(true)
{
    var a = 1
    let b = 2

    console.log("I'm in the if block", a, b);
}

console.log("I'm outside of the if block", a)
// console.log(b) //Reference Error

const c = "this is a const value"

console.log(c)

// c = "lets change this value" //Type Error. Won't work

//This is global scope. Anything we declare here is put in global scope.

function callMe() {
    //We just created a function scope.
    //Things we declare here won't be available outside of this function.
    var foo = "bar"
    console.log(foo);
}
callMe();
// console.log(foo); //Reference Error

function falsyValues()
{
    //FUN0NE
    if(!null)
    {
        console.log("I'm Null and I'm falsy");
    }
    if(!undefined)
    {
        console.log("I'm undefined and I'm falsy")
    }
    if(!NaN)
    {
        console.log("I'm NaN and I'm falsy");
    }
    if("False")
    {
        console.log("'False' is truthy")
    }
}

// falsyValues();

let falsyFuncs = falsyValues;
let funcExp = function () {
    console.log("I'm a function expression!");
}

// falsyFuncs();
funcExp();

//Arrow function, function expression, and IFFY
let arrowFunc = (() => {
    console.log("I'm an arrow func")
    // return "arrowFunc"
})()

function fn()
{
    console.log("I'm a fnc")
    return {
        key: "value"
    }
}
let letVar = fn();
console.log("letvar is now holding the return value of the fn", letVar);

let arrowOneLiner = () => console.log("one liner")

// arrowFunc()
arrowOneLiner()

//Callback function
function caller(callee)
{
    console.log("I'm about to call the fn that's been passed to me")
    callee()
}

// caller(falsyValues)

//Closure
function outerFn()
{
    var privateVar = "I'm so private"

    function inner(str)
    {
        if(str)
        {
            privateVar = str;
        }
        console.log(privateVar);
    }

    return inner;
}

let closure = outerFn();
closure("something truthy");