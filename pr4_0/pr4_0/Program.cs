using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_0
{
    struct DataContainer
    {
        public DataContainer(string data) {
            Data = data;
        }
        public string Data { get; set; }
    }
    class DataManager { 
        public void PrintData( DataContainer dataContainer)
        {
            Console.WriteLine( dataContainer.Data );
        }

        public void ChangeData( DataContainer dataContainer, string newData)
        {
            dataContainer.Data = newData;
        }
        static void Main()
        {
            DataContainer dataContainer = new DataContainer("совы не то, чем кажутся!");
            DataManager dataManager = new DataManager();

            dataManager.ChangeData(dataContainer, "некоторые совы очень большие!");
            Console.WriteLine( dataContainer.Data );

            Console.ReadKey(true);

        }
    }
}
