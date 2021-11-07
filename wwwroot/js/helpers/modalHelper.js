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
    
    console.log(max, percentage, resultsVaccines)
    
    const formatVaccines = numberWithCommas(max)
    
    return ({formatVaccines, resultsVaccines, percentage})
}