using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationBuilding
{
    public partial class BuildSim : Form
    {
        // Параметры моделирования: длительность смены, длительность моделирования
        public int durationWorkChange = 16;
        public int durationModelingDay = 100;

        // Объекты с описанием параметров мастеров
        Worker worker3 = new Worker();
        Worker worker6 = new Worker();

        // Объекты с описанием параметров машин
        Machine excavator = new Machine();
        Machine bulldozer = new Machine();

        // Текущий день и минута моделирования
        public int modelDay = 0;
        public int modelMinute = 0;

        // Параметры для моделирования работы бригады мастеров (мастер 3 р + мастер 6 р)
        public bool bothMasterWorking = true;
        public int timeBothMasterWorkingPerDay = 0;
        public int timeBothMasterWorkingPerAllPeriod = 0;
        // Накладные расходы работы бригады
        public decimal costOverheadsWorkersPerMinute = 0;
        // Математические ожидания времени ремонта машин бригадой мастеров (мастер 3 р + мастер 6 р)
        int expValueRepairExcavatorWorkers, expValueRepairBulldozerWorkers;

        // Прибыль за весь период моделирования
        public decimal profitPerAllPeriod = 0;

        public BuildSim()
        {
            InitializeComponent();
            
        }

        private void BuildSim_Load(object sender, EventArgs e)
        {
           
        }

    }
}
