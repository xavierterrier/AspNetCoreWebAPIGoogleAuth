# Asp.Net WebAPI Core oAuth2 Google Authentication example

This is how to use Google Identity in Asp.Net WebAPI Core using cookie based authentication.
You can use this with any JS framework you like (AngularJS, React, VueJS, ...).

Follow [Microsoft documentation](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/google-logins?tabs=aspnetcore2x) to configure Google API credentials then fill ClientId and ClientSecret in Startup.cs. Note this should be a good idea to [Secret Manager](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?tabs=visual-studio) to store ClientId and ClientSecret.