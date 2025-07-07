Code Snippets

```bash
az containerapp env create \
    --name $myAppContEnv \
    --resource-group $rg1 \
    --location eastus
```

```bash
az containerapp create \
    --name my-container-app \
    --resource-group $rg1 \
    --environment $myAppContEnv \
    --image mcr.microsoft.com/azuredocs/containerapps-helloworld:latest \
    --target-port 80 \
    --ingress 'external' \
    --query properties.configuration.ingress.fqdn
```

```bash
az containerapp create \
  --name ipcheck-container-app \
  --resource-group $rg1 \
  --environment $myAppContEnv \
  --image derricktestregistry.azurecr.io/ipcheck:latest \
  --target-port 80 \
  --ingress 'external' \
  --registry-server derricktestregistry.azurecr.io \
  --registry-username <ACR_USERNAME> \
  --registry-password <ACR_PASSWORD> \
  --query properties.configuration.ingress.fqdn
```

