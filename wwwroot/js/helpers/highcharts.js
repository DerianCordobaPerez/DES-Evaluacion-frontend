/**
 * They display the highchart with the data 
 * passed as parameters.
 * 
 * @param {Object} series
 * @param {Object} properties
 * @returns void
 * */
const printHighChart = (series, properties) => {
    const {name, type, title, xAxis} = properties

    Highcharts.chart(`${name}`, {
        chart: {type},
        title,
        xAxis: {categories: xAxis},
        yAxis: {title: ''},
        series
    })
}

/**
 *
 * @param {Object} theme
 **/
const changeThemeHighchart = theme => {
    
    const {colors, chart, fonts} = theme
    
    Highcharts.theme = {
        colors,
        chart,
        title: {
            style: {
                color: '#00ACEC',
                font: fonts.title
            },
            floating: true,
            align: 'left',
            x: 30,
            y: 30
        },
        subtitle: {
            style: {
                color: '#666666',
                font: fonts.subtitle
            }
        },
        legend: {
            itemStyle: {
                font: fonts.legend,
                color: 'black'
            },
            itemHoverStyle:{
                color: 'gray'
            }
        }
    }

    Highcharts.setOptions(Highcharts.theme);
}

document.addEventListener('DOMContentLoaded', async () => {
    
    let data = []

    await getAllExtendedInformation()
        .then(response => data = response)
    
    const locations = data.map(item => item.location)
    
    const properties = {
        name: 'highchart-bar',
        type: 'column',
        title: {text: 'Total de Casos por pais (%)'},
        xAxis: locations,
    }

    const series = data.map(item => ({
        name: item.location,
        data: [item.population]
    }))
    
    printHighChart(series, properties)
})

document.addEventListener('DOMContentLoaded', async () => {

    let data = []

    await getAllExtendedInformation()
        .then(response => data = response)
    
    const properties = {
        name: 'highchart-line',
        type: 'line',
        title: {text: 'Fallecidos por COVID-19'},
        xAxis: data.map(item => item.location),
    }

    const series = data.map(item => ({
        name: item.location,
        data: [item.population, item.population * 4, item.population * -3, item.population * -2, item.population * 10]
    }))

    printHighChart(series, properties)
})