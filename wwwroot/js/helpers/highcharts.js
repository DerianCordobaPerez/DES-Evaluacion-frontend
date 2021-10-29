const data = [
    {location: 'Nicaragua', value: 110},
    {location: 'Honduras', value: 20},
    {location: 'El Salvador', value: 10},
]

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

document.addEventListener('DOMContentLoaded', () => {
    const properties = {
        name: 'highchart-bar',
        type: 'column',
        title: {text: 'Total de Casos por pais (%)'},
        xAxis: data.map(item => item.location),
    }
    
    const series = data.map(item => ({
        name: item.location,
        data: [item.value]
    }))
    
    printHighChart(series, properties)
})

document.addEventListener('DOMContentLoaded', () => {
    
    const properties = {
        name: 'highchart-line',
        type: 'line',
        title: {text: 'Fallecidos por COVID-19'},
        xAxis: data.map(item => item.location),
    }

    const series = data.map(item => ({
        name: item.location,
        data: [item.value, item.value * 2, item.value * 3]
    }))

    printHighChart(series, properties)
})