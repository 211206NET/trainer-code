'use strict';

function globalThis()
{
    return this;
}

function logThis()
{
    console.log(this)
}

class sampleClass
{
    fn(x) {
        console.log(x)
        console.log(this)
        return this;
    }
}

let cls = new sampleClass()

console.log(cls.fn())

let global = cls.fn.bind(this)

console.log(global())