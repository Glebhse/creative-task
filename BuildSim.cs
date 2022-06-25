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
            excavator.type = MachineType.Excavator;
            bulldozer.type = MachineType.Bulldozer;

            btnStartModeling.Enabled = true;
            btnStopModeling.Enabled = false;
            btnNextDay.Enabled = false;
            btnLastDay.Enabled = false;
        }

        private void btnStartModeling_Click(object sender, EventArgs e)
        {
            // Элементы настроки параметров моделирования сделать недоступными
            groupBoxMachinesParams.Enabled = false;
            groupBoxWorkersParams.Enabled = false;
            groupBoxModelingParams.Enabled = false;

            // Заполнение переменных моделирования на основе значений, заданных пользователем на форме:

            // Если выбрано, что работают оба мастера, то устанавливаем переменную bothMasterWorking как true
            bothMasterWorking = radioButtonBothWorkers.Checked;

            // Математические ожидания работы экскаватора и бульдозера (в минутах)
            excavator.expectationDurationWork = (int)(numericUpDownExpWorkExcavator.Value * 60);
            bulldozer.expectationDurationWork = (int)(numericUpDownExpWorkBulldozer.Value * 60);

            // Математические ожидания ремонта экскаватора и бульдозера бригадой мастеров (в минутах)
            expValueRepairExcavatorWorkers = (int)(numericUpDownExpRepairExcavatorWorkers.Value * 60);
            expValueRepairBulldozerWorkers = (int)(numericUpDownExpRepairBulldozerWorkers.Value * 60);

            // Математические ожидания ремонта экскаватора и бульдозера по одному мастеру (в минутах)
            worker3.expectationDurationRepairExcavator = (int)(numericUpDownExpRepairExcavatorWorker3.Value * 60);
            worker6.expectationDurationRepairExcavator = (int)(numericUpDownExpRepairExcavatorWorker6.Value * 60);
            worker6.expectationDurationRepairBulldozer = (int)(numericUpDownExpRepairBulldozerWorker6.Value * 60);

            // Финансовые параметры (в мин)
            costOverheadsWorkersPerMinute = numericUpDownOverheadsWorkers.Value / 60;
            worker3.salaryPerMinute = numericUpDownSalaryWorker3.Value / 60;
            worker6.salaryPerMinute = numericUpDownSalaryWorker6.Value / 60;

            // Доходы от работы машин (в мин)
            excavator.profitPerMinute = numericUpDownExcProfit.Value / 60;
            bulldozer.profitPerMinute = numericUpDownBullProfit.Value / 60;

            // Убыток от простоя машин (в мин)
            excavator.lossPerMinute = numericUpDownExcLoss.Value / 60;
            bulldozer.lossPerMinute = numericUpDownBullLoss.Value / 60;

            // Время работы машин в сутки (по умолчанию 16 часов)
            durationWorkChange = (int)numericUpDownWorkingHours.Value;

            // Длительность моделирования
            durationModelingDay = (int)numericUpDownModelPeriod.Value;

            // Текущий день моделирования
            modelDay = 0;

            // Прибыль за весь период моделирования
            profitPerAllPeriod = 0;

            // Старт моделирования первого дня
            ModelingOneDay();

            //После начала моделирования меняем доступные кнопки
            btnStartModeling.Enabled = false;
            btnStopModeling.Enabled = true;
            btnNextDay.Enabled = true;
            btnLastDay.Enabled = true;
        }

        private void btnStopModeling_Click(object sender, EventArgs e)
        {
            groupBoxMachinesParams.Enabled = true;
            groupBoxWorkersParams.Enabled = true;
            groupBoxModelingParams.Enabled = true;

            //Функция для обнуления всей выведенной информации на экран после нажатия кнопки!!

            btnStartModeling.Enabled = true;
            btnStopModeling.Enabled = false;
            btnNextDay.Enabled = false;
            btnLastDay.Enabled = false;
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            ModelingOneDay();
        }

        private void btnFinishModeling_Click(object sender, EventArgs e)
        {
            for (int i = modelDay; i < durationModelingDay; i++)
            {
                ModelingOneDay();
            }
        }

        #region Основные функции для моделирования


        /// <summary>
        /// Моделирование одного дня работы системы
        /// </summary>
        private void ModelingOneDay()
        {
            //Тут делаем метод для ресета данных моделирования за день

            modelDay++; //Прошел один день
            modelMinute = 0;
           

            // Заполнение данных о текущем дне моделирования
            textBoxModelDay.Text = modelDay.ToString();

            // Моделирование всех минут одной смены (например, 16 часов * 60 = 960 мин)
            for (int i = 0; i < (durationWorkChange * 60); i++)
            {
                modelMinute = i;
                ModelingOneMinute(); // Метод для Моделирования следующей минуты работы системы
               
            }
             
            // Тут будт методы для обновления данных о моделировании (стата)
            
        }

        private void ModelingOneMinute()
        {
                 
        }

        #endregion

    }
}
