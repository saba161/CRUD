﻿

// ------------ INSERT CODE HERE! ----------------------------
// Apply the projectionFunction to each item in the array and add
// each result to the results array.
// Note: you can add items to an array with the push() method.
// ------------ INSERT CODE HERE! ----------------------------

Array.prototype.map = function (projectionFunction) {
    var results = [];
    this.forEach(function (itemInArray) {
        results.push(projectionFunction(itemInArray));
    });

    return results;
};

//JSON.stringify([1, 2, 3].map(function (x) { return x + 1; })) === '[2,3,4]'
