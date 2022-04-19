# SpaceShipDatabase
Final project for EFA Blue Badge

## Usage
This program is designed to be able to create a database of different space-fairing vessels from various sources, both real and fictional.

It's designed to be able to both create, edit, grab, and delete items from its database, using SQL code instructions such as Get, Pull, Put, and Delete.

By using such commands through programs such as Postman, you will be able to access the database as well, including the seeded in content pre-prepared for use.

The prograsm is also equipped with Swagger capabilities for ease of use as well.

To delete and update any inputs on the table, it requires a token of use from authorization along with a registered account. Putting and getting do not require such keys.

### Origin 
Origin comes with these required properties for uploading them. Aspects  such as creation date and owner id are handled automatically.
```csharp
string OriginName
int RegisteredShips
```

### Ship
Ships come with these required properties for uploading, with aspects as creation date, owner ID, and ship ID being handled automatically. Speed set as string to allow for specific universe speed descriptors.
```csharp
string ShipName
int? OriginId
string Manufacturer
string ShipSize
string ShipPurpose
string CaptainName
int CrewSize
string Capacity
string TopSpeed
```

### Crew
Crew comes with these required properties for uploading. 
```csharp
string Ship
virtual string OriginName
string CrewName
string CrewRole
string CrewDescription
string CrewMembers
```

### Manufacturer
Manufacturer comes with these required properties for uploading
```csharp
string ManufacturerName
List<Ship> ListOfShips
int? NumberOfShips
```

## Contributions
At this current state, the project is not open for outside contributions, and is only for use in ElevenFifty Academy and the students/teachers affiliated with the project.


## Downloading
The code and database should all be set to run after copying it in. Once you have, you can either use programs like postmate, or even typing in /swagger at the end to access more ease of use.

It should be noted that individual accounts must be registered beforehand to access, acquiring a token to be able to edit and delete posts. However, posting and retrieving data need no such information.

## Authors
Avery Finchum - Origin Table, Joining Tables

Corey Pfleiger - Crew Table, Foreign Key Relationships

Victor Ryan - Ship Table, Manufacturer Table, Git Master

## License
MIT
