# Task23

Create Web API methods that returns add / multiply results.
Notes:
http://localhost:18513/calculator/addtwonumbers
Postman: POST
{
    "FirstNumber":",hgvkhg",
    "SecondNumber":"35"
}

Result:
{
    "status": "Not Success",
    "message": "Please enter two Valid numbers"
}

http://localhost:18513/calculator/subtracttwonumbers
POstman: POST
{
    "FirstNumber":"20",
    "SecondNumber":"567"
}

Result:
{
    "status": "Success",
    "message": "The difference of two numbers is : -547"
}

# Task24
Create .net core Async API methods that returns add / multiply results
Notes:
http://localhost:18513/Asynccalculator/addtwonumbersAsync
Postman : POST
{
    "FirstNumber":"56",
    "SecondNumber":"345"
}

Result:
{
    "status": "Success",
    "message": "The sum of two numbers is : 401"
}

http://localhost:18513/Asynccalculator/subtracttwonumbersAsync
Postman : POST
{
    "FirstNumber":"20",
    "SecondNumber":"43"
}
Result:
{
    "status": "Success",
    "message": "The difference of two numbers is : -23"
}
