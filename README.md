# Airport Distance Calculator

REST service to measure distance in miles between two airports. 

## How to Test

Run the fallowing command

```bash
dotnet run
```

then go to url https://localhost:7000/AirportDistance/?formIATACode=AMS&toIATACode=IST will calculate distance between Istanbul and Amsterdam Airports.

## Test with docker
```bash
docker build -t cteleportassingment .
docker run -it --rm -p 3000:80 --name cteleportairportservicecontainer cteleportassingment
```

then go to url http://localhost:3000/AirportDistance/?formIATACode=AMS&toIATACode=IST will calculate distance between Istanbul and Amsterdam Airports.