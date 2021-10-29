const uri = 'https://localhost:5001/'

const getAllExtendedInformation = () => {
    return fetch(`${uri}extendedCountryInformation/getAll`)
        .then(response => response.json())
        .catch(error => console.error('Unable to get extended country information.', error));
}

