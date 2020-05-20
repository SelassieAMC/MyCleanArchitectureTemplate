### Restore packages
```
dotnet Restore
```
### Add Migrations
Go to Infraestructure project and execute this instructions
```
dotnet ef migrations remove -s ../MyDevPortfolioAPI.Api -o Persistence/Migrations
```
**Where**
-s specify the startup project
-o output directory for migrations

### Remove last Migrations
```
dotnet ef migrations remove -s ../MyDevPortfolioAPI.Api 
```
