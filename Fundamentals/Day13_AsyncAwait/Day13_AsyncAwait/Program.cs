


// Project Type : Console App

// Simulate PLC 
// Simulate Sensor 
// Load data to MES 
// Run Multiple Machines in Parallel

///  Simulate PLC
static async Task<int> ReadPlcAsync(string machine)
{
    Console.WriteLine($"Reading PLC for {machine}...");
    await Task.Delay(2000); // simulate PLC wait
    return new Random().Next(100,200);

}

static async Task<double> ReadTempratureAsync(string machine)
{
    Console.WriteLine($"Reading temperature for {machine}");
    await Task.Delay(1500 );
    return new Random().NextDouble()*20;
}


static async Task LoadMachineDataAsync(string machine)
{
    var partsTask = ReadPlcAsync(machine);
    var tempTask = ReadTempratureAsync(machine);

    int parts = await partsTask;
    double temp = await tempTask;

    Console.WriteLine($"{machine} -> Parts : {parts}, Temp : {temp:F1}");

}

var machine = new[] { "CNC-01", "CNC-02", "Robot-01" };

var task = machine.Select(m => LoadMachineDataAsync(m));

await Task.WhenAll(task);

Console.WriteLine("MES data refresh completed");

