namespace StyledDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        public void InitializeDataGrid()
        {
            /* To add DataGridView columns manually:
             * 
            dataGridView1.Columns.Add("Column1", "ID");
            dataGridView1.Columns.Add("Column2", "Make");
            dataGridView1.Columns.Add("Column3", "Model");
            dataGridView1.Columns.Add("Column4", "Year");
            dataGridView1.Columns.Add("Column5", "Engine Capacity");
            */

            Car car1 = new Car { Id = 101, Make = "Suzuki", Model = "Swift", Year = 2022, EngineCapacity = 1.2 };
            Car car2 = new Car { Id = 102, Make = "Toyota", Model = "Hilux", Year = 1989, EngineCapacity = 1.8 };
            Car car3 = new Car { Id = 103, Make = "Mazda", Model = "RX-7", Year = 1981, EngineCapacity = 1.1 };
            Car car4 = new Car { Id = 104, Make = "Mitsubishi", Model = "Lancer", Year = 2005, EngineCapacity = 2.0 };
            Car car5 = new Car { Id = 105, Make = "Nissan", Model = "Patrol", Year = 1995, EngineCapacity = 2.4 };

            dataGridView1.Rows.Add(car1.Id, car1.Make, car1.Model, car1.Year, car1.EngineCapacity);
            dataGridView1.Rows.Add(car2.Id, car2.Make, car2.Model, car2.Year, car2.EngineCapacity);
            dataGridView1.Rows.Add(car3.Id, car3.Make, car3.Model, car3.Year, car3.EngineCapacity);
            dataGridView1.Rows.Add(car4.Id, car4.Make, car4.Model, car4.Year, car4.EngineCapacity);
            dataGridView1.Rows.Add(car5.Id, car5.Make, car5.Model, car5.Year, car5.EngineCapacity);
        }
    }
}
