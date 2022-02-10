import axios from 'axios'

const api = axios.create({
    baseURL: 'https://6205049e161670001741b316.mockapi.io'
})

export default api;