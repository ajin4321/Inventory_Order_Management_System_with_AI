import axios from 'axios';

export default axios.create({
  baseURL: 'https://localhost:7248/api', // change to your API port
});
