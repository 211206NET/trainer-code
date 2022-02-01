"use strict";
let populateRestaurantTable = function (dataArray) {
    // let tableElem: HTMLElement | null = document.getElementById('restaurant-table')
    // if(tableElem)
    // {
    //     //we know this table element exists
    //     let tbody: HTMLElement | null = tableElem.querySelector('tbody')
    //     if(tbody)
    //     {
    //         for(let i = 0; i < dataArray.length; i++)
    //         {
    //         }
    //         for(let resto of dataArray)
    //         {
    //             let tr = document.createElement('tr')
    //             let idTd = document.createElement('td')
    //             idTd.innerText = resto.id.toString()
    //             let nameTd = document.createElement('td')
    //             nameTd.innerText = resto.name
    //             let saTd = document.createElement('td')
    //             saTd.innerText = resto.streetAddress
    //             let cityTd = document.createElement('td')
    //             cityTd.innerText = resto.city ?? ""
    //             let stateTd = document.createElement('td')
    //             stateTd.innerText = resto.state ?? ""
    //             tr.appendChild(idTd)
    //             tr.appendChild(nameTd)
    //             tr.appendChild(saTd)
    //             tr.appendChild(cityTd)
    //             tr.appendChild(stateTd)
    //             tbody.appendChild(tr)
    //         }
    //     }
    // }
    let tableHTMLElem = document.querySelector('table#restaurant-table');
    if (tableHTMLElem) {
        for (let resto of dataArray) {
            let row = tableHTMLElem.tBodies[0].insertRow();
            row.insertCell().textContent = resto.id.toString();
            row.insertCell().textContent = resto.name;
            row.insertCell().textContent = resto.streetAddress;
            row.insertCell().textContent = resto.city;
            row.insertCell().textContent = resto.state;
        }
    }
};
let getRestaurants = function () {
    let awsurl = 'http://rrwebapi-prod.us-west-2.elasticbeanstalk.com/api/Restaurant';
    /**
     * send an http request to our RR api to grab all restaurants
     * the first promise gets us the whole server response, with the status code and everything
     * We get the body in json format by calling .json() method on the response,
     * which also resturns a promise.
    */
    fetch(awsurl).then((res) => res.json(), (err) => console.log(err)).then((resJson) => {
        //in here, now we have the body of the response.
        populateRestaurantTable(resJson);
    });
};
