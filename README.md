# C# app connected to Oracle database
  For this project I am working with Oracle using SQL and Visual Studio using C#.
  I have created two tables, one stores the employees of a company along with data about their salaries, while the other stores the tax values used to calculate their monthly payments.
  My goal was being able to add new employees, edit some of the data about them, erase any of them from the table and even modify the tax values in case they might change, using my C# app.
  For anybody to access the table with the tax values through my app, they need to know the password. The person will insert the password and this password will be encrypted and compared to the value stored in the same tax table, this value being the encryption of the correct password. After the insertion of the correct password, the user will be able to edit the tax values as well as the password, the decrypted value being available into a textbox that serves this purpose.
