/**
 * Gets the total sum of the value associated with the key passed 
 * as a parameter.
 * 
 * @param {String} key
 * @param {Object} data
 * @return {Number}
 **/
const getSumFromKey = (key, data) => data.reduce((sum, item) => sum + item[key], 0)