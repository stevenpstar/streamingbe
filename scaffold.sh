dotnet ef dbcontext scaffold "UserID=postgres;Password=admin;Host=localhost;Port=5432;Database=streamingdev;Pooling=true;MinPoolSize=0;MaxPoolSize=1024;ConnectionLifetime=0;" Npgsql.EntityFrameworkCore.PostgreSQL --context-dir Data --output-dir Models --force
find Models/ -type f -exec dos2unix '{}' '+'
find Data/ -type f -exec dos2unix '{}' '+'
