namespace Programming.Programming.Домашние__2_семестр.company
{
    public class Worker
    {
        protected WorkerStatus workerStatus;
        public int ID;

        public WorkerStatus SetWorkerStatus(WorkerStatus status) => workerStatus = status;
        public WorkerStatus GetWorkerStatus() => workerStatus;
        
        public Worker(WorkerStatus status)
        {
            ID = -1;
            workerStatus = status;
        }
    }
    
    public class Manager : Worker
    {
        public Manager(WorkerStatus status) : base(status)
        {
            ID = -1;
        }
    }
    
    public class Company
    {
        private List<Worker> workers = new();
        private List<Worker> managers = new();

        public Worker? GetWorker(int id) => workers.Find(x => x.ID == id);

        public void AddNewWorker(Worker worker)
        {
            worker.ID = GenerateUID();
            workers.Add(worker);
            if(worker.GetWorkerStatus() == WorkerStatus.Manager) managers.Add(worker);
        }

        private int GenerateUID()
        {
            if (workers.Count == 0) return 0;
            
            foreach(var id in Enumerable.Range(0, workers.Count+1))
                if (workers.All(x => x.ID != id))
                    return id;

            throw new Exception("Unable to generate UID");
        }
        
        public void RemoveWorker(int id) => workers.RemoveAt(workers.FindIndex(x => x.ID == id));
        public void Print() => string.Join(" ", workers.Select(x => x.ID)).Print();
        
        public int WorkersCount() => workers.Count;
        public int ManagersCount() => managers.Count;
    }
    
    public enum WorkerStatus
    {
        Worker,
        Manager
    }
    
    public static class Extension
    {
        public static void Print(this object obj, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(obj.ToString());
            Console.ResetColor();
        }
    }
}
