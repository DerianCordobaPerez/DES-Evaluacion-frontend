const addMaker = async (country, lat, lng) => {
    
    const marker = new google.maps.Marker({
        position: { lat, lng},
        map
    })
    
    this.modal = document.getElementById('modal')

    const {formatVaccines, resultsVaccines, percentage, totalVaccinations} = await createModalWindow(country)
    
    google.maps.event.addListener(marker, 'click', () => {
        closeInfoWindow()
        setCountryValues(country, formatVaccines, percentage, resultsVaccines, totalVaccinations)
        const infoWindow = new google.maps.InfoWindow({content: `${this.modal.innerHTML}`})
        infoWindow.open(map, marker)
        this.latestInfoWindow = infoWindow
    })
}

const closeInfoWindow = () => {
    if(this.latestInfoWindow)
        this.latestInfoWindow.close()
}

const setCountryValues = (country, vaccines, percentage, vaccinesNames, totalVaccinations) => {
    document.querySelector('.span-country').innerHTML = country
    document.querySelector('.span-vaccines-peoples').innerHTML = vaccines
    document.querySelector('.span-percentage').innerHTML = `${percentage}%`
    
    const select = document.querySelector('.modal-selector')
    select.innerText = null
    
    vaccinesNames.map(item => {
        const option = document.createElement('option')
        option.value = item
        option.innerHTML = item
        select.appendChild(option)
    })
    const {_ , latestDays} = getTotalDeathsPerDays()

    const properties = {
        name: 'modal-highchart',
        type: 'line',
        title: {text: ''},
        xAxis: latestDays,
    }
    const series = latestDays.map((item, index) => ({
        name: item,
        data: totalVaccinations[index]
    }))
    
    printHighChart(series, properties)
}