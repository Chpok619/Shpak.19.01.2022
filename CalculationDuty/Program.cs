var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

decimal CalculateDuty(decimal price)
{
    decimal duty = 0;
    if (price > 200)
        duty = (price * .15m);

    return duty;
}

app.MapGet("/customs_duty", (decimal price) => CalculateDuty(price));

app.Run();