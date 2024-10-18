const baseURL = process.env.REACT_APP_API_URL;

const endpoints = {
  Tickets: 'api/v1/tickets'
};

export function getUrl(endpoint) {
  return baseURL + endpoints[endpoint];
}

export default endpoints;
