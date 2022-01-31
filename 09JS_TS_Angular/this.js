function globalThis()
{
    return this;
}

(function()
{
    let x = true;
    console.log(globalThis());
})()

class sampleClass
{
    fn() {
        return this;
    }
}

let cls = new sampleClass()

console.log(cls.fn())

let global = cls.fn.bind(this)

console.log(global())