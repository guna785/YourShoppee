#Dot net core Shopping Site

Restore All Dependencies

and 

#If you are using mysql proceed with
Update Database Migration by setting DAL project in package Manager Console...

----> update-database -Context IdentityContext

----> update-database -Context ApplicationDbContext

#else 
in DAL Entiframework core sql dependency and

in DALExtentions.cs 

![image](https://user-images.githubusercontent.com/54167051/139810931-bfa2ab59-65d0-4ba2-88dd-ef6a0ecc2b19.png)
instead of .UseMysql({connStr}) use corresponding  .UseSqlServer({connStr})

Then 

Run Application 
