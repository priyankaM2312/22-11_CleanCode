review_1.cs
int d; // elapsed time in days
---
int elapsedTimeInDays;

review_2.cs
var dataFromDb = db.GetFromService().ToList(); // Get List of employees 
---
var dataFromEmployees= employees.GetFromService().ToList();

review_3.cs
int iCounter;
string strFullName;
DateTime dModifiedDate;
----
int Counter;
string FullName;
DateTime ModifiedDate;

review_4.cs
public bool IsShopOpen(string pDay, int pAmount)
{
    // some logic
}
-----
public bool IsShopOpen(string Day, int Amount)
{
    // some logic
}

review_5.cs
const int DAYS_IN_WEEK = 7;
const int daysInMonth = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var Artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool EraseDatabase() {}
bool Restore_database() {}

class animal {}
class Alpaca {}
-----
const int daysInWeek = 7;
const int daysInMonth = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool EraseDatabase() {}
bool RestoreDatabase() {}

class animal {}
class alpaca {}

review_6.cs
public class Employee
{
    public Datetime sWorkDate { get; set; } // get set Start Working Date
    public Datetime modTime { get; set; } // get set Modification Time
}
------
public class Employee
{
    public Datetime startWorkDate { get; set; } // get set Start Working Date
    public Datetime modificationTime { get; set; } // get set Modification Time
}

review_7.cs
var employeephone;

public double CalculateSalary(int workingdays, int workinghours)
{
    // some logic
}
-------
var employeePhone;

public double CalculateSalary(int workingDays, int workingHours)
{
    // some logic
}
