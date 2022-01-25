# P2 Requirements
- Has to be a web application with SOA
    - Separate FE/BE repos
    - hosted separately
- Some kind of social/interactive feature
    - ex. being able to follow somebody, join a club, invite someone for a game/activity/trip/etc.
- External API Integration (1 or more)
    - ie. Vision API, Map, Pet, etc.
- At the least, BE should be deployed
- CI/CD Pipeline with Sonar cloud
    - Test coverage at least 50% (both FE/BE)
- DB: At least 4 or more tables
    - hosted somewhere, either AWS RDS, or ElephantSQL, etc.
- Logging: Integrate Serilog with Microsoft.Extensions.Logging
    - We are getting the ASP.NET system logs in our files not just ours
    - Actually get useful logging instead of just getting ours

## Technologies
- ASP.NET Web API (for BE)
- Angular w/ Typescript (for FE)
- XUnit, Moq, Sonar cloud for testing and code analysis
- AWS for hosting
- Github action for CI/CD pipeline (or really any devops tool)
- AWS RDS or any kind of hosted SQL DB for our DB (for free tool, use ElephantSQL)
- EF Core for Object Relational Mapper