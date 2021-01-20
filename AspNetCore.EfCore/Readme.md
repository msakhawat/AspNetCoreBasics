
WebApi Database Efcore
1. Create webapi project 3.1
2. Nuget Package for EfCore
  Microsoft.EntityFrameworkCore.SqlServer
  Microsoft.EntityFrameworkCore.Tools
3. Create model from database
Scaffold-DbContext "Data Source=.\SQLEXPRESS;Initial Catalog=AspNetCoreBasics;User ID=sa;Password=sa" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
4. Add connectionstring in appsetting.json
5. Configure Dbcontext in startup.cs
6. Create a controller and use dbcontext to intrect with database

