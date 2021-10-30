const uri = 'https://localhost:5001'

const getAllInformation = async (url) => {
    return await fetch(`${uri}/${url}`)
        .then(response => response.json())
        .then(data => data)
        .catch(error => console.error('Unable to get extended country information.', error));
}