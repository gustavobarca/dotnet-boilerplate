<div align="center">
  <img alt="oxe-dsign" src="https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/Microsoft_.NET_logo.svg/2048px-Microsoft_.NET_logo.svg.png" width="100">
</div>
<div align="center">
  <h3 style="font-size: 22px"><b>Dotnet Boilerplate</b></h3>
  <p>A boilerplate created using dotnet and entity framework</p>
</div>

---
</br>

## 🖥️ Technologies
- Entity Framework 7
- Dotnet Core 7
- Swagger

## 🚀 Running

To run de project, execute the command:

```bash
dotnet run --project Web
```

## 🛢️ Migrations

To generate a migration, run the following command:

```bash
dotnet ef migrations add InitialCreate --project Infrastructure
```

To apply the migrations into the database, run the following command:

```bash
dotnet ef database update --project Infrastructure
```
