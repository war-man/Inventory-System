# ClearlySystem
## Prerequisites
Create an Azure account with an active subscription. For details, see [Create an account for free](https://azure.microsoft.com/free/?WT.mc_id=A261C142F)

Install Node.js (12.12.0 recommended).

Install Postman

Install Docker

Create an Azure Communication Services resource. For details, see [Create an Azure Communication Resource](https://docs.microsoft.com/en-us/azure/communication-services/quickstarts/create-communication-resource?tabs=windows&pivots=platform-azp)

CREATE Service Bus (Standart SKU, sessions should be supported). For details, see [Create Service Bus](https://azure.microsoft.com/en-us/services/service-bus/)

CREATE 2 queues in Service Bus with sessions enabled: `users` and `threadcreated` 

### Run with docker-compose
Create file prod.env >>>
```
COMMUNICATION_SERVICES_CONNECTION_STRING=PUT_HERE_YOUR_COMMUNICATION_SERVICES_CONNECTION_STRING
COMMUNICATION_SERVICES_ENDPOINT_URL=PUT_HERE_COMMUNICATION_SERVICES_ENDPOINT_URL
SERVICE_BUS_CONNECTION_STRING=PUT_HERE_SERVICE_BUS_CONNECTION_STRING
PORT=8000
```

```
docker-compose up --build
```

### Local development 
ENVIRONMENT:

Define and store your connections strings, see how [here](<https://docs.microsoft.com/en-us/azure/communication-services/quickstarts/create-communication-resource?tabs=windows&pivots=platform-azp#store-your-connection-string>)
```
COMMUNICATION_SERVICES_CONNECTION_STRING=PUT_HERE_YOUR_COMMUNICATION_SERVICES_CONNECTION_STRING
COMMUNICATION_SERVICES_ENDPOINT_URL=PUT_HERE_COMMUNICATION_SERVICES_ENDPOINT_URL
SERVICE_BUS_CONNECTION_STRING=PUT_HERE_SERVICE_BUS_CONNECTION_STRING
VUE_APP_API_BASE_URL=http://localhost:8000/api
```


SERVER:
```
cd acs_server
npm install
npm start
```
CLIENT:
```
cd acs_client
npm install
npm run serve
```

## USEFUL LINKS:
<https://azure.microsoft.com/en-us/services/communication-services/>

<https://docs.microsoft.com/en-us/azure/communication-services/quickstarts/chat/get-started?pivots=programming-language-javascript>
