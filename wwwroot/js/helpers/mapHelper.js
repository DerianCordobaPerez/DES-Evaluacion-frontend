let lastMarker

const addMaker = (lat, lng) => {
    const marker = new google.maps.Marker({
        position: { lat, lng}, 
        map
    })
    
    const infoWindow = new google.maps.InfoWindow({
        content: '<h1>Hola mundo</h1>'
    })

    google.maps.event.addListener(marker, 'click', ((marker, infoWindow) => {
        return () => {
            closeLastInfoWindow()
            infoWindow.open(map, marker)
            lastMarker = infoWindow
        }
    })(marker, infoWindow))
}

const closeLastInfoWindow = () => {
    if (lastMarker)
        lastMarker.close()
}