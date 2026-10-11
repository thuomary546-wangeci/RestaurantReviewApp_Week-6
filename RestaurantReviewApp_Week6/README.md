# Restaurant Review App - Week 6 Blazor UI Components

This project follows the Week 6 PRG 320 Blazor lecture and assignment.

## Required UI operations

1. List all Restaurants
2. Edit one Restaurant
3. Delete a Restaurant
4. Add a Restaurant
5. Update a Restaurant
6. Add a Review

## Blazor concepts demonstrated

- `.razor` components
- HTML and C# together in a component
- `@code` blocks
- `@bind-Value` two-way data binding
- `EditForm`
- Data annotations validation
- `[Parameter]`
- Interactive Server rendering
- Fake in-memory restaurant data

The project does not call a RESTful API yet. The fake service is used so the UI can be tested this week. The API can replace the fake service in the next assignment.

## Run

Open this folder in Visual Studio Code and run:

```powershell
dotnet restore
dotnet build
dotnet watch run
```

Open the localhost address shown in the terminal.

## Suggested screenshots

1. VS Code project structure showing `.razor` files
2. List all Restaurants
3. Add Restaurant form
4. Restaurant list after adding
5. Edit Restaurant form
6. Restaurant list after updating
7. Delete confirmation
8. Restaurant list after deleting
9. Restaurant Details
10. Add Review form
11. Details page showing the added review
