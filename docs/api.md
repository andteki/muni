# Dolgozói nyilvántartás

## Végpontok

|  Végpont           | Metódus  | Leírás                        |
|--------------------|----------|-------------------------------|
| /api/Employee      |  get     | Összes lekérdezése            |
| /api/Employee      |  post    | Hozzáadás                     |
| /api/Employee      |  put     | Módosítás                     |
| /api/Employee{id}  |  get     | Egyetlen dolgozó lekérdezése  |
| /api/Employee{id}  |  delete  | Dolgozó törlése               |

## Futtatás

```bash
dotnet run
```

## A Swagger elérése

[https://localhost:7040/swagger](https://localhost:7040/swagger)

A portot be kell helyettesíteni.

## Üzembehelyezés

### 2.0 verziótól

```bash
dotnet build
```

```bash
dotnet run
```

### 4.0 verziótól így is használható

```bash
nuget restore
```

```bash
dotnet restore
```
