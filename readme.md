### Mongo container
docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db mongo

### Add an alternative package provider location
dotnet nuget add source ~/learn/csharp/core/juliocasal/projects/packages -n PlayEconomy