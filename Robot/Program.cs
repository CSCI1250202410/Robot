namespace Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var robot = new Robot("X001");
            robot.MoveForward();
            var robot2 = new Robot("X002");
            var robot3 = new Robot("X003");

            //Console.WriteLine(robot.DisplayInformation());
            robot.Charge(5);
            //Console.WriteLine(robot.DisplayInformation());

            //Console.WriteLine(robot2.DisplayInformation());
            //Console.WriteLine(robot3.DisplayInformation());

            Console.WriteLine(robot);

            Console.WriteLine(1.ToString().GetType());


            //robot.Model = "X001";

            //var robot2 = new Robot();


            //var robot3 = new Robot() { Model = "X002" };
        }
    }
}