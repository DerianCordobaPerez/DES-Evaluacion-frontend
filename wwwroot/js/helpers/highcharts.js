document.addEventListener('DOMContentLoaded', () => {
    Highcharts.theme = {
        colors: ['#058DC7', '#50B432', '#ED561B', '#DDDF00', '#24CBE5', '#64E572',
            '#FF9655', '#FFF263', '#6AF9C4'],
        chart: {
            backgroundColor: {
                linearGradient: [0, 0, 500, 500],
                stops: [
                    [0, 'rgb(255, 255, 255)'],
                    [1, 'rgb(240, 240, 255)']
                ]
            },
        },
        title: {
            style: {
                color: '#00ACEC',
                font: 'bold 14px "Trebuchet MS", Verdana, sans-serif'
            },
            floating: true,
            align: 'left',
            x: 30,
            y: 30
        },
        subtitle: {
            style: {
                color: '#666666',
                font: 'bold 10px "Trebuchet MS", Verdana, sans-serif'
            }
        },
        legend: {
            itemStyle: {
                font: '9pt Trebuchet MS, Verdana, sans-serif',
                color: 'black'
            },
            itemHoverStyle:{
                color: 'gray'
            }
        }
    }

    Highcharts.setOptions(Highcharts.theme);
})

document.addEventListener('DOMContentLoaded', () => {
    Highcharts.chart('highchart-bar', {
        chart: {
            type: 'column'
        },
        title: {
            text: 'Total de Casos por pais (%)'
        },
        xAxis: {
            categories: ['Guatemala', 'Belice', 'Salvador', 'Honduras', 'Nicaragua', 'Costa Rica', 'Panama']
        },
        series: [{
            name: 'Guatemala',
            data: [3.2]
        }, {
            name: 'Belice',
            data: [4.5]
        }, {
            name: 'Salvador',
            data: [1.5]
        }, {
            name: 'Honduras',
            data: [3.69]
        }, {
            name: 'Nicaragua',
            data: [0.20]
        }, {
            name: 'Costa Rica',
            data: [10.12]
        }, {
            name: 'Panama',
            data: [10.92]
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