// SOLID Principles
/* SOLID Principles - that keep large systems stable,testable and scable
 * S - Single Responsibility Principle(SRP)
 *      Rule: 
 *          A Class Should have only one reason to change
 *      Bad Example:
 *      
 *      classMachine
 *      { 
 *          void Start() {}
 *          void LogToDatabase() {}
 *          void SendAlarm() {}
 *          void UpdateDashboard() {}
 *          
 *         }
 *         
 *         why bad: 
 *         > Machine logic changes
 *         > Logging changes
 *         > UI changes
 *         
 *       Good Example:
 *       
 *       class Machine
 *       {
 *          viod Start() {}
 *         }
 *         
 *       class ProductionLogger {}
 *       class AlarmService {}
 *       class DashboardService {}
 *       
 *       > Machine = equipment behavoiour
 *       > Service = reactions
 *       
 *       
 *     O - Open/Closed Principle (OCP)
 *      Rule:
 *          Open for extension ,closed for modification
 *          
 *      interface IProductionListener
 *      {
 *          void OnProductionCompleted(string machineId, int parts)
 *        }
 *      
 *     L - Liskov Substitution Principle (LSP)
 *     
 *     Rule: 
 *          Derived class must be usable wherever base class is expected
 *          
 *      I - Interface Segregation Principle (ISP)
 *      
 *      Rule:
 *      
 *          Don't force classes to implement what they don't need
 *      
 *      
 *      D - Dependency Inversion Principle (DIP)
 *      
 *      Rule:
 *          Depend on abstractions , not concrete classes
 *          
 *          
 *          
 *      
 */      

Console.WriteLine("Learning SOLID Principle");