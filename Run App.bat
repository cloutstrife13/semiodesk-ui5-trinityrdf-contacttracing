start /b dotnet run --project ./Backend/Trinity
start /b npm start --prefix ./Backend/OData
start /b npm start --prefix ./Frontend/ui5-contacttracing
explorer "http://localhost:3000/"