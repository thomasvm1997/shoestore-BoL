# shoestore-BoL

# Lokaal runnen
- Visual studio:
- tools installeren indien nodig: dotnet tool install --global dotnet-ef
- Rmb op solution => Restore NuGet Packages
- Database aanmaken: dotnet ef database update -s .\Server.api -p.\Server.core
- Poortnummer aanpassen van https indien nodig in launchSettings.json
- Cors policy: in Program.cs policy.WithOrigins("http://localhost:") poortnummer van client
- run https
- Client: poortnummers in de url's van de hooks aanpassen naar die van van de server.

# Database
- Als je de datatbase zelf wil updaten moet je in de connection string SQLEXPRESS05 de 05 verwwijderen.
- Elke shoe heeft maar 1 size en categorie.

# Api
- Heb met mijn filter endpoint te kort door de bocht willen gaan. Moest raw search en andere filters eigenlijk gescheiden houden. Dus om te testen eerst raw search uitproberen zonder aan de andere filters te komen.
- Endpoints zijn niet beveiligd door een token mits er enkel httpgets gebeuren.

# Frontend
- Je kan radio buttons niet onselecteren. Dus pagina herladen om te resetten.
- Sliders voor prijs doen call naar api bij elke movement.
