const getCountryInformation = async () => 
    await getAllInformation("countryInformation/getAll").then(response => this.results = response)

const numberWithCommas = (number) => 
    number.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");

const createModalWindow = async (country) => {
    
    await getCountryInformation()    
    const results = this.results.filter(item => item.country === country)
    const totalVaccinations = results.map(item => item.data.map(element => element.totalVaccinations))
    const max = Math.max(...totalVaccinations.flat())
    
    console.log(results)
    
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
                        <h3 class="modal-title-span">${numberWithCommas(max)}</h3>
                        <p class="modal-subtitle-span">Personas vacunadas</p>                    
                    </div>
                </div>
            </div>
            
            <div class="modal-body">
                
            </div>
        </div>
    `
}

document.addEventListener('DOMContentLoaded', async () => {
    //await getCountryInformation()
})