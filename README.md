##### Identity Server 4 Tenant Selection Application Example ####

You can follow the tutorial here :

https://lalitacode.com/how-to-implement-tenant-selection-in-identity-server-4-application/

if you want to follow the video your can visit this link below :

https://youtu.be/s3XmS6udcJs

To run this application follow the points belows :


## In Authorization Project ##

Add ConnectionString in your appsettings.json file with "DefaultConnection" connection string to your database.

Make the required changes to the database seed in IdentityDbcontext, MasterDbContext and ConfigurationDbContext. You need to give your client configuration as per your requirement.

Run the migrations for IdentityDbContext, PersistedGrantDbContext, MasterDbContext and ConfigurationDbContext and update database.

## In Angular Client ##
Make changes to the client config in app.module.ts as per your requirement.
Finally run the application.
