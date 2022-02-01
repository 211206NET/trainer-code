# Security

## Authentication and Authorization
Both Authentication and authorization are concerned with permission to do certain things, or access sensitive data.

However, authentication is more concerned about "Who are you" or identifying the user, making sure that the user have access to the application.

Authentication is implemented with LogIn/Sign up features. 

Authorization is concerned about checking privileges to take certain actions or have access to certain data.

For example, you wouldn't want an any old user to be able to delete or modify your store! We can hide these features away from the users, unless they are manager and/or admins.

With authorization, we can create a certain roles that is attached to certain rights and privileges, so it's easier to control access to certain features of the app.

## IDaaS
#### IDentity as a Service.
OAuth, Auth0, Okta, etc. are services that provide logging in/sign up features without you having to worry about implementation details. Basically, we're outsourcing our auths! Because it is expensive to implement it on our own, and it is a complex topic and typical businesses don't want to spent time worrying about developing their own auth solutions, when they could be spending time developing solutions that address their BL and their products.

ASP.NET also offers their own auth solution- called ASP.NET Core Identity.
This provides log in/ sign up functionality, roles and social account log in such as FB, Twitter, MSaccount, Google.

## OWASP 10

[OWASP 10](https://owasp.org/)

OWASP is referential document outlining the top 10 most critical security concerns for web application security.
It is updated periodically to represent the most current security vulnerabilities for web applications.