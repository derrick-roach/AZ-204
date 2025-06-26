Here is a full example using specific values. You can copy and modify these as needed:

Example Values
- Resource Group: my-funcapp-rg
- Location: eastus
- Function App Name: myuniquefuncapp2025
- Storage Account Name: myuniquestorage2025
- Runtime: dotnet

Step 1: Create a new resource group
`az group create --name my-funcapp-rg --location eastus`

Step 2: Create a new storage account
Storage account names must be globally unique and only lowercase letters/numbers.
```
az storage account create \
  --name myuniquestorage2025 
  --location eastus 
  --resource-group my-funcapp-rg 
  --sku Standard_LRS
```

Step 3: Create the Function App
After running these commands, your Function App will be created in a resource group where you are the "Owner," allowing role assignments to succeed.
```
az functionapp create \
  --resource-group my-funcapp-rg \
  --consumption-plan-location eastus \
  --runtime dotnet \
  --functions-version 4 \
  --name myuniquefuncapp2025 \
  --storage-account myuniquestorage2025
```
