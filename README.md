### Restore packages
```
dotnet Restore
```
### Add Migrations
Go to Infraestructure project and execute this line of code
```
dotnet ef migrations add initial -s ../MyDevPortfolioAPI.Api -o Persistence/Migrations
```
**Where**
-s specify the startup project
-o output directory for migrations
initial migration name's

### Remove last Migrations
```
dotnet ef migrations remove -s ../MyDevPortfolioAPI.Api 
```
### Create or update database from migrations
```
dotnet ef database update -s ../MyDevPortfolioAPI.Api
```
