### Restore packages
```
dotnet Restore
```
### Add Migrations
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
