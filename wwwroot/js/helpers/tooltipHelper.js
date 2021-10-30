const getCountryInformation = async () => 
    await getAllInformation("/countryInformation/getAll").then(response => this.data = response)

document.addEventListener('DOMContentLoaded', async () => {
    await getCountryInformation()
})