# File-Execute

Executes your ROBLOX script file in a directory without using:
```lua
print(readfile("")) --too cheap to buy functions? we have another method
```

If you want to use it, make sure the format is like this:
```csharp
string my_root = "scripts\\print.txt";//put your script root here
FileExecute(my_root);//run the file script
```

If you want to read and print out the script file:
```csharp
string my_root = "scripts\\print.txt";
FileExecute("print('" + my_root + "');
```
