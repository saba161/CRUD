﻿function() {
	var ratings = [2, 3, 1, 4, 5];

	return ratings.
		reduce(function (acc, curr) {
			if (acc > curr) {
				return acc;
			}
			else {
				return curr;
			}
		});
}
