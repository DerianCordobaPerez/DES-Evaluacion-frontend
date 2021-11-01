/**
 * Obtains the data in an extended way from the countries api.
 * 
 * @return {Promise} 
 **/
const getExtendedCountryInformation = async () => 
    await getAllInformation("extendedCountryInformation/getAll").then(response => this.data = response)

const getCasesPerPercentage = () => {
    const data = this.data.map(item => item.data)
    const sum = data.map(item => getSumFromKey('totalCases', item))
    return sum.map(item => item / sum.reduce((sum, item) => sum + item, 0) * 100)
}

const getLatestDays = (data) => {
    
}

const getTotalDeathsPerDays = () => {
    const data = this.data.map(item => item.data)
   
    // get first four days
    let index = 0
    const latestDays = data.map(item => item[index++].date).slice(0, 4)
    
    // filter the data to get the total deaths per day
    const deathsPerDays = data.map(item => 
        item.filter(item => latestDays.includes(item.date)))
    
    const totalDeaths = deathsPerDays.map(item => 
        item.map(item => item.totalDeaths))
    
    return {totalDeaths, latestDays}
}

const createMarker = () => this.data.map(async item => 
    await addMaker(item.location, parseFloat(item.latitude), parseFloat(item.longitude)))

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
        xAxis: ' ',
    }

    let index = 0
    const percentage = getCasesPerPercentage()
    
    const series = this.data.map((item) => ({
        name: item.location,
        data: [parseFloat(percentage[index++].toFixed(2))]
    }))
    
    printHighChart(series, properties)
}

/**
 * Create the graph in a line fashion.
 *
 * @returns {void} 
 **/
const createHighChartLine = () => {
    const {totalDeaths, latestDays} = getTotalDeathsPerDays()
    
    const properties = {
        name: 'highchart-line',
        type: 'line',
        title: {text: 'Fallecidos por COVID-19'},
        xAxis: latestDays,
    }
    
    const series = this.data.map((item, index) => ({
        name: item.location,
        data: totalDeaths[index]
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