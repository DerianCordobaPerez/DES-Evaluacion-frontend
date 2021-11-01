const getCountryInformation = async () => 
    await getAllInformation("countryInformation/getAll").then(response => this.results = response)

const numberWithCommas = (number) => 
    number.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");

const createModalWindow = async (country) => {
    
    await getCountryInformation()
    const results = this.results.filter(item => item.country === country)
    const totalVaccinations = results.map(item => item.data.map(element => element.totalVaccinations))
    const max = Math.max(...totalVaccinations.flat())
    let vaccines = this.results.map(item => item.data.map(element => element.vaccine.split(',').flat())).flat().flat()
    vaccines = vaccines.map(item => item.trim())
    const resultsVaccines = vaccines.filter((item, index) => vaccines.indexOf(item.trim()) === index)
    
    let percentage = (max / 10000).toFixed(2)
    if(percentage > 100)
        percentage /= 10

    return `
        <div class="modal">
            <div class="modal-header">
                <div class="modal-header-country">
                    <img class="modal-img" src="img/ICN_Poblacion.svg" alt="img" />
                    <span class="modal-title-span">${country}</span>
                </div>
                
                <div class="modal-header-vaccine">
                   
                    <div class="modal-container-img">
                        <img class="modal-img" src="img/ICN_Vacunas.svg" alt="img" />
                    </div>
                
                    <div class="modal-multiple-lines-content">
                        <h3 class="modal-title-span">${numberWithCommas(max)}</h3>
                        <p class="modal-subtitle-span">Personas vacunadas</p>                    
                    </div>              
                </div>
                
                <div class="modal-header-percentage">
                    <div class="modal-multiple-lines-content">
                        <h3 class="modal-title-span">${percentage}%</h3>
                        <p class="modal-subtitle-span">Porcentaje vacunados</p>                    
                    </div>
                </div>
                
                <div class="modal-header-selector">
                    <select class="modal-selector">
                        ${resultsVaccines.map(item => `<option value="${item}">${item}</option>`).join('')}
                    </select>
                </div>
            </div>
            
            <div class="modal-body">
                <div id="modal-highchart"></div>
            </div>
        </div>
    `
}

const printModalHighchart = () => {
    const days = [
        "2021-09-01",
        "2021-09-02",
        "2021-09-03",
        "2021-09-04"
    ]

    const properties = {
        name: 'modal-highchart',
        type: 'line',
        title: {text: ''},
        xAxis: days,
    }

    const results = this.results.map(item => item.data)

    const vaccinesPerDay = results.map(item =>
        item.filter(item => item.date).slice(0, 4))

    const totalVaccines = vaccinesPerDay.map(item =>
        item.map(item => item.totalVaccinations))

    const series = this.results.map((item, index) => ({
        name: days[index],
        data: totalVaccines[index]
    }))

    printHighChart(series, properties)
}

document.addEventListener('DOMContentLoaded', async () => {
    await getCountryInformation()
    printModalHighchart()
})