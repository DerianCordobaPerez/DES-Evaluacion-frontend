let lastMarker

const addMaker = async (country, lat, lng) => {
    const marker = new google.maps.Marker({
        position: { lat, lng},
        map
    })
    
    const modal = await createModalWindow(country)
    
    const infoWindow = new google.maps.InfoWindow({
        content: `${modal}`
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