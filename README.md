# UniversalLocator
This is a web application locates you!

# To get started
  - Run databse migrations using the following dotnet cli command
           ```dotnet ef databsae update```
  - This will read the `us-zip-code-latitude-and-longitude.json` dataset from the local diskfile and populate sqllite databse.
  - A table named `Places` will be created in Sqllite database
  - To start the web application, set up `UniversalLocator` as a startup project and run it in visual studio using IISExpress
  - Navigate to http://localhost:44317
  

# Note
 - The zipcode input accepts number input only (prevents user from entering any alphanumeric input)
 - If entered zipcode is a valid zipcode and can be found in our database, then the user will be shown corresponding City and State and distance of that place from Mindgrubs zipcode!
 - If entered zipcode cannot be found, then the user will see appropriate error message
