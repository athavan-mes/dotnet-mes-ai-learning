
using Day10_ExceptionHandling;

var service =  new ProductionService();
/// 

try
{
    int efficiency = service.CalculateEfficiency(450, 500);
    Console.WriteLine($"Production Efficiency: {efficiency}%");
    service.StartMachine("M-100");
    service.StartMachine("M-FAIL");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Input Error: {ex.Message}");
}
catch (MachineException ex)
{
    Console.WriteLine($"Machine Error (ID: {ex.MachineId}): {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected Error: {ex.Message}");
}
finally 
{
    Console.WriteLine("Logging production data and closing resources");

}