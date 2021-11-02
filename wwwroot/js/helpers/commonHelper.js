/**
 * Gets the total sum of the value associated with the key passed 
 * as a parameter.
 * 
 * @param {String} key
 * @param {Object} data
 * @return {Number}
 **/
const getSumFromKey = (key, data) => data.reduce((sum, item) => sum + item[key], 0)

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

/**
 * Set theme for highchart
 **/
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
