var roleManager = new RoleManager<IdentityRole>(new RoleStore(context.Get<ExampleStorageContext>()));