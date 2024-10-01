# ASP.NET Core Configuration

```
dotnet restore
MyAppSettings__ApplicationName="Minimal API from Env" dotnet run
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