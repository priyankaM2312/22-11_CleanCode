review_1.cs
public bool IsShopOpen(string day)
{
    if (!string.IsNullOrEmpty(day))
    {
        day = day.ToLower();
        if (day == "friday"||day == "saturday"||day == "sunday")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }

}
review_3.cs
public long Fibonacci(int n)
{
    if (n > 50)
    {
        throw new System.Exception("Not supported");
    }

    if (n == 0 || n == 1)
    {
        return n;
    }

    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

review_4.cs
var city = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < city.Count(); i++)
{
    var cityName = city[i];
    Dispatch(cityName);
}

review_5.cs
int adminRole="Admin";.
if (userRole == adminRole) // Check if Admin 
{
    
}

review_6.cs
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
}

review_7.cs
var year_month_day = DateTime.UtcNow.ToString("MMMM dd, yyyy");

review_9.cs
public void CreateMicrobrewery(string name = "Hipster Brew Co.")
{
}
