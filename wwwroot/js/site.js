let map, initialPosition

function initMap() {
    initialPosition = new google.maps.LatLng(12.483979477244299, -86.21416043359112)
    
    map = new google.maps.Map(document.getElementById('map'), {
        center: initialPosition,
        zoom: 5,
    })

    const marker = new google.maps.Marker({
        position: initialPosition,
        title: "Hello world"
    })

    marker.setMap(map)
}

document.addEventListener('DOMContentLoaded', () => {
    Highcharts.chart('highchart-bar', {
        chart: {
            type: 'column'
        },
        title: {
            text: 'Fruit Consumption'
        },
        xAxis: {
            categories: ['Apples', 'Bananas', 'Oranges']
        },
        yAxis: {
            title: {
                text: 'Fruit eaten'
            }
        },
        series: [{
            name: 'Jane',
            data: [1, 0, 4]
        }, {
            name: 'John',
            data: [5, 7, 3]
        }]
    })
})

document.addEventListener('DOMContentLoaded', () => {
    Highcharts.chart('highchart-line', {
        chart: {
            type: 'line'
        },
        title: {
            text: 'Fruit Consumption'
        },
        xAxis: {
            categories: ['Apples', 'Bananas', 'Oranges']
        },
        yAxis: {
            title: {
                text: 'Fruit eaten'
            }
        },
        series: [{
            name: 'Jane',
            data: [1, 0, 4]
        }, {
            name: 'John',
            data: [5, 7, 3]
        }]
    })
})