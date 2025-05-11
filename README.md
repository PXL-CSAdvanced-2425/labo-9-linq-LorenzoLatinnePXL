# Labo 9 - LINQ

## Opdracht
In deze labo-opdracht werken we met LINQ in C#. Je zal gebruik maken van **method syntax** en **query syntax** om data te filteren, sorteren, groeperen en samen te voegen (*joins*). 

Je werkt in een **console applicatie** en drukt alle resultaten af in de console.

- **Console output** met `Console.WriteLine()`
- Elk resultaat druk je af in **de vorm:**  
  `FullName - Age - DepartmentId - Salary` *(of andere relevante properties)*

---

## Setup

Gebruik volgende klassen:

```csharp
public class Employee
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public int DepartmentId { get; set; }
    public double Salary { get; set; }
}

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```
### Gebruik de volgende dummydata
```csharp
List<Employee> employees = new List<Employee>
{
    new Employee { Id = 1, FullName = "Alice Janssens", Age = 30, DepartmentId = 1, Salary = 3500 },
    new Employee { Id = 2, FullName = "Bob Peeters", Age = 45, DepartmentId = 2, Salary = 4200 },
    new Employee { Id = 3, FullName = "Charlie Van Dijk", Age = 28, DepartmentId = 1, Salary = 3100 },
    new Employee { Id = 4, FullName = "Dina Maes", Age = 50, DepartmentId = 3, Salary = 5000 },
    new Employee { Id = 5, FullName = "Eva Willems", Age = 22, DepartmentId = 2, Salary = 2800 },
};

List<Department> departments = new List<Department>
{
    new Department { Id = 1, Name = "Development" },
    new Department { Id = 2, Name = "HR" },
    new Department { Id = 3, Name = "Management" }
};
```
---

## Opdrachten
#### 1. Filtering
Toon alle medewerkers ouder dan 30 via method syntax

Doe hetzelfde via query syntax

#### 2. Sorting & Selecting
Sorteer medewerkers op loon (hoog → laag) en toon FullName - Salary

Sorteer medewerkers per afdeling op leeftijd

Toon de jongste medewerker (FullName - Age)

#### 3. Groeperen
Groepeer medewerkers per afdeling. Toon: DepartmentId - Aantal medewerkers

Toon per afdeling het gemiddelde loon
#### 4. Join
Join medewerkers met afdelingen zodat je ook de afdelingsnaam ziet

Toon als: "Alice Janssens - 30 - Development - 3500"

Schrijf deze join in query syntax én method syntax
#### 5. Combinatie
Toon medewerkers jonger dan 30 of met loon > 3000 euro

Toon medewerkers waarvan de naam een “a” bevat én loon > 3000

**Veel succes!**
