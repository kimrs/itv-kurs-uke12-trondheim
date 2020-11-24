# Linq 
#### Language Integrated Query
Note:
- Structured query language for retrieving data from different sources and formats
- Sql is also a structured query language, but it is limited to databases and not built into c#

---
# Example
From a list of names, retrieve all names starting with the letter 'A'

Note: 
- We can often replace ugly for-loops with beautiful linq querys

---

##### Possible solution

```
var result = new List<string>();
foreach (var name in names)
{
    if (name.StartsWith("A"))
    {
        result.Add(name);
    }
}
```
Note:
- Does not look to bad. 
- Go through the code
- https://dotnetfiddle.net/5aTkJl
---

LINQ to the rescue

```
var result = persons.Where(x => x.FirstName.StartsWith("A"));

```
Note:
- We used extension methods from the name space System.Linq
- We used a Lambda expression
- https://dotnetfiddle.net/X8JPRq