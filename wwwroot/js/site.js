let map, initialPosition, marker

function initMap() {
    initialPosition = new google.maps.LatLng(12.483979477244299, -86.21416043359112)
    
    map = new google.maps.Map(document.getElementById('map'), {
        center: initialPosition,
        zoom: 5,
    })

    marker = new google.maps.Marker({
        position: initialPosition,
        title: "Hello world"
    })

    marker.setMap(map)

    marker.addListener('click', e => {
        // show modal window with all information
    })
}