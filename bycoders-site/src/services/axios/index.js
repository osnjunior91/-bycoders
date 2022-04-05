import axios from 'axios';

const BycodersApi = axios.create({
    baseURL: 'https://localhost:44373/api/v1',
    headers: {
        'Content-type': 'application/json'
    }
});

export { BycodersApi }