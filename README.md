# Palo Zombie Saver app

The Palo Zombie Saver Application has been built to tackle the technical challenge presented by PALO IT for the hiring of their Junior Full Stack Developer position.

## Live Link
https://palozombiesserver20210502201127.azurewebsites.net/

## Techstack
* .NET Core 5 (Server)
* Blazor Web Assembly (Front-end)
* MongoDb Atlas
* XUnit and BUnit
* Bootstrap
* Github

## Architecture
![diagram](https://github.com/hdkaran/palo-zombies/blob/main/diagram.JPG)

## Available API Endpoints
* /api/hospital
* /api/illness

## Workflow

User is presented with a list of Illnesses -> User Selects an Illness -> User is presented with a Level of Pain Scale -> User Selects a Pain Level -> The application calculates and analyzes all available hospitals for that pain level and suggests a sorted list of hospitals to the user -> User selects a hospital -> User provides First Name and Last Name in an Input Form -> All recorded information is sent to MongoDb Atlas Database -> After receiving the id from Db a Thankyou page is displayed.

## Instructions to Run Locally
 To run the app locally, you will need to have **.NET Core 5 installed** on your computer.
 
### .NET Installation
* To install .NET please visit: https://dotnet.microsoft.com/download
* To check if .NET is installed, go to a command line client (For example, Command prompt, powershell or Terminal) and enter command: 
 ```
 dotnet --version
 ```
* If a version is returned, it indicates that .NET was installed successfully 

### To run the project
* Download(or clone) the project as ZIP from github and extract it.
* Use a command line client and cd(change directory) to "PaloZombies\PaloZombies\Server\"
* After you are in the Server folder, simply run the command: 
```
dotnet run
```
* After the command has finished processing, you can access the solution using any browser. Just type "localhost:5000" in your address bar. 

### To run the tests
* Use a command line client and cd(change directory) to "PaloZombies\PaloZombies.Tests"
* After you are in the PaloZombies.Tests folder, simply run the command: 
```
dotnet test
```

## Support
For any issues regarding this solution please email me at: karanbhatia0161@gmail.com
