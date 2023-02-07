using Task23;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var branch = new Branch()
            {
                Branches = new List<Branch>()
                {
                    new Branch()
                    {
                        Branches = new List<Branch>()
                        {
                            new Branch() {}
                        }
                    },
                    new Branch()
                    {
                        Branches = new List<Branch>()
                        {
                            new Branch()
                            {
                                Branches= new List<Branch>()
                                {
                                    new Branch()
                                }
                            },
                            new Branch()
                            {
                                Branches = new List<Branch>()
                                {
                                    new Branch()
                                    {
                                        Branches = new List<Branch>()
                                        {
                                            new Branch()
                                        }
                                    },
                                    new Branch()
                                }
                            },
                            new Branch()
                        }
                    }
                }
            };

            Console.WriteLine($"Depth: {GetDepth(branch)}");
        }

        private static int GetDepth(Branch branch)
        {
            if (branch.Branches == null) return 1;

            var subDepths = new List<int>();
            
            foreach(var child in branch.Branches)
            {
                subDepths.Add(GetDepth(child));
            }

            return subDepths.Max() + 1;
        } 
    }
}