var builder = WebApplication.CreateBuilder(args); 

builder.Services.AddControllers(); 

builder.Services.AddServerSideBlazor(); 

builder.Services.AddEndpointsApiExplorer(); 

builder.Services.AddSwaggerGen(); 

builder.Services.AddScoped<ListService>(); 

builder.Services.AddSqlite<ListContext>("Data Source=ToDoList.db"); 

var app = builder.Build();

app.MapHub<HubConnection>("/HubConnection"); 

app.UseSwagger(); 

app.UseSwaggerUI(); 

app.MapControllers(); 

app.Run(); 