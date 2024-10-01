# ASP.NET Core Configuration

ฺBlog in Thai: <https://medium.com/t-t-software-solution/%E0%B8%9A%E0%B8%97%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1%E0%B8%8A%E0%B8%B8%E0%B8%94-net-6-%E0%B9%81%E0%B8%9A%E0%B8%9A%E0%B8%88%E0%B8%B1%E0%B8%9A%E0%B8%A1%E0%B8%B7%E0%B8%AD%E0%B8%97%E0%B8%B3-6-configuration-6ca0086971bc>

## Linux/Mac

```
dotnet restore
MyAppSettings__ApplicationName="Minimal API from Env" dotnet run
```

## Windows

```
dotnet restore
$env:MyAppSettings__ApplicationName = "Minimal API from Env"
dotnet run
```

Enter the following URL in the browser to see the output.
http://localhost:5119/

## Output

```
{
  "appName": {
    "withGetSection": "Minimal API from Env",
    "withConfiguration": "Minimal API from Env"
  },
  "version": "1.0"
}
```