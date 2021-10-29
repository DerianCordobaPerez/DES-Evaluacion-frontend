const uri = 'https://localhost:5001/'

const getAllExtendedInformation = async () => {
    return await fetch(`${uri}extendedCountryInformation/getAll`)
        .then(response => response.json())
        .then(data => data)
        .catch(error => console.error('Unable to get extended country information.', error));
}

