echo publishing %1

nuget push *.nupkg -Source https://www.nuget.org

pause