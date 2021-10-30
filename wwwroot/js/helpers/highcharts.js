/**
 * They display the highchart with the data
 * passed as parameters.
 *
 * @param {Object} series
 * @param {Object} properties
 * @returns {void}
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

const setThemeHighChart = () => {
    Highcharts.theme = {
        colors: ["#017E73", "#E91D63", "#673AB7", "#FDCD36", "#DAE8F0", "#DDE0E3", "#FADEC7"],
        chart: {
            backgroundColor: null,
            style: {
                fontFamily: "Tahoma, serif"
            }
        },
        title: {
            style: {
                color: '#00ACEC',
                font: 'bold 16px, Tahoma, sans-serif'
            }
        },
        subtitle: {
            style: {
                color: '#00ACEC',
                font: 'bold 16px, Tahoma, sans-serif'
            }
        },
        tooltip: {
            borderWidth: 0
        },
        legend: {
            itemStyle: {
                fontWeight: '',
                fontSize: '11px'
            }
        },
        xAxis: {
            labels: {
                style: {
                    color: '#6e6e70'
                }
            }
        },
        yAxis: {
            labels: {
                style: {
                    color: '#6e6e70'
                }
            }
        }
    };
    Highcharts.setOptions(Highcharts.theme);
}

/**
 * Obtains the data in an extended way from the countries api.
 * 
 * @return {Promise} 
 **/
const getExtendedCountryInformation = async () => 
    await getAllInformation("extendedCountryInformation/getAll").then(response => this.data = response)

const getCasesPercentage = () => {
    const data = this.data.map(item => item.data)
    const sum = data.map(item => getSumFromKey('totalCases', item))
    return sum.map(item => item / sum.reduce((sum, item) => sum + item, 0) * 100)
}

/**
 * Create the chart in a columnar fashion.
 *
 * @returns {void}
 * */
const createHighChartBar = () => {
    const properties = {
        name: 'highchart-bar',
        type: 'column',
        title: {text: 'Total de Casos por pais (%)'},
        xAxis: this.data.map(item => item.location),
    }

    let index = -1
    const percentage = getCasesPercentage()
    
    const series = this.data.map((item) => {
        ++index
        return ({
            name: item.location,
            data: [parseFloat(percentage[index].toFixed(2))]
        })
    })
    
    printHighChart(series, properties)
}

const createMarker = () => this.data.map(item => addMaker(parseFloat(item.latitude), parseFloat(item.longitude)))

/**
 * Create the graph in a line fashion.
 *
 * @returns {void} 
 **/
const createHighChartLine = () => {
    const properties = {
        name: 'highchart-line',
        type: 'line',
        title: {text: 'Fallecidos por COVID-19'},
        xAxis: this.data.map(item => item.location),
    }
    
    const series = this.data.map(item => ({
        name: item.location,
        data: []
    }))

    printHighChart(series, properties)
}

document.addEventListener('DOMContentLoaded', async () => {
    await getExtendedCountryInformation()
    setThemeHighChart()
    createHighChartBar()
    createHighChartLine()
    createMarker()
})