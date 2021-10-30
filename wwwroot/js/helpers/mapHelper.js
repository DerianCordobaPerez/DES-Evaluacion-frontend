const addMaker = (map, lat, lng) => {
    console.log(lat, lng);
    
    new google.maps.Marker({
        position: { lat, lng}, map
    })   
}