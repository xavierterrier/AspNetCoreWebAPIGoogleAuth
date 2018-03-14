# Asp.Net WebAPI Core oAuth2 Google Authentication example

This is how to use Google Identity in Asp.Net WebAPI Core using cookie based authentication.
This can be used very easily with any JS framework (AngularJS, React, VueJS, ...).

Follow [Microsoft documentation](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/google-logins?tabs=aspnetcore2x) to configure Google API credentials then fill ClientId and ClientSecret in Startup.cs.

Do not forget to add Authorized redirect URIs specified in Startup.cs (for instance http://localhost:5000/api/signin-google).

Note this should be a good idea to use [Secret Manager](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?tabs=visual-studio) to store ClientId and ClientSecret.