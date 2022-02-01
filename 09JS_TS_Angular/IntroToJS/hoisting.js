function enclosingFn() {
    localFn()
    function localFn() {
        console.log('local fn')
    }
}

globalScope()
function globalScope()
{
    console.log("I'm a globally scoped function")
}

console.log(globalVar) //the name exists in lexical env, but the value is undefined
var globalVar = "I'm a global variable" 
console.log(globalVar) //the value is now here


// console.log(auryn); //Reference Error
let auryn
console.log(auryn)
auryn = "be a cat"
console.log(auryn)

// console.log(there()); //Reference Error

let there = function() {
    console.log("Be light")
}
console.log(there())