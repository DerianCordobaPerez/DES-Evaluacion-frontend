﻿let map, initialPosition, marker

function initMap() {
    initialPosition = new google.maps.LatLng(12.483979477244299, -86.21416043359112)
    
    map = new google.maps.Map(document.getElementById('map'), {
        center: initialPosition,
        zoom: 5,
    })
}