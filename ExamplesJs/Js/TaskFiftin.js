﻿function() {
	var boxarts = [
		{ width: 200, height: 200, url: "http://cdn-0.nflximg.com/images/2891/Fracture200.jpg" },
		{ width: 150, height: 200, url: "http://cdn-0.nflximg.com/images/2891/Fracture150.jpg" },
		{ width: 300, height: 200, url: "http://cdn-0.nflximg.com/images/2891/Fracture300.jpg" },
		{ width: 425, height: 150, url: "http://cdn-0.nflximg.com/images/2891/Fracture425.jpg" }
	],

	var currentSize = 0;
	var maxSize = 0;

	boxarts.forEach(function (item) {
		currentSize = item.height * item.width;
		if (currentSize > maxSize) {
			maxSize = currentSize;
		}
	});

	return maxSize;
}
