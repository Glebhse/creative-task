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
            ModelingOneMinuteExcavator();
            ModelingOneMinuteBulldozer();


            //Тут ведем учет состояния мастера 6 и 4 разряда
            //рассмотреть случай если оба заняты
            //случай если они оба работают
        }

        private void ModelingOneMinuteExcavator()
        {
            // Если состояние экскаватора "готов к работе", то рассчитывается время, когда машина выйдет из строя и устанавливается статус "в работе"
            if (excavator.state == MachineState.ReadyToWork)
            {
                excavator.workTime = modelMinute + GetRandomValueByExponential(excavator.expectationDurationWork);
                excavator.state = MachineState.Working;
                //Вывод
            }
            // Если наступило время ремонта, меняется состояние на ожидание ремонта (простой)
            else if (excavator.state == MachineState.Working && modelMinute == excavator.workTime)
            {
                excavator.state = MachineState.WaitingRepair;
                PrintStateMachine(excavator);
               
            }
            // Если экскаватор находится в ожидании ремонта
            if (excavator.state == MachineState.WaitingRepair)
            {
                // Условия для отправки экскаватора в ремонт:
                // 1. Работают оба мастера и свободны оба
                // 2. Работают оба мастера, но свободен только 3 разряда
                // 3. Работает один мастер 6 разряда и он свободен

                // Если работают оба мастера (бригада)
                if (bothMasterWorking)
                {
                    // Если свободны оба мастера
                    if (worker3.stateWorker == WorkerState.Free && worker6.stateWorker == WorkerState.Free)
                    {
                        // Устанавливаем состояние экскаватора "В ремонте"
                        excavator.state = MachineState.Repair;
                        // Состояние мастеров - "Ремонт экскаватора"
                        worker3.stateWorker = WorkerState.ExcavatorRepair;
                        worker6.stateWorker = WorkerState.ExcavatorRepair;

                        // Расчет времени завершение ремонта экскаватора
                        excavator.repairTime = modelMinute + GetRandomValueByExponential(expValueRepairExcavatorWorkers);
                        PrintStateMachine(excavator);
                    }
                    // Если свободен только мастер 3 разряда
                    else if (worker3.stateWorker == WorkerState.Free && worker6.stateWorker != WorkerState.Free)
                    {
                        // Устанавливаем состояние экскаватора "В ремонте"
                        excavator.state = MachineState.Repair;
                        // Состояние мастера 3 разр. - "Ремонт экскаватора"
                        worker3.stateWorker = WorkerState.ExcavatorRepair;
                        // Расчет времени завершение ремонта экскаватора
                        excavator.repairTime = modelMinute + GetRandomValueByExponential(worker3.expectationDurationRepairExcavator);
                        PrintStateMachine(excavator);
                    }
                }
                // Работает только мастер 6 разряда
                else
                {
                    if (worker6.stateWorker == WorkerState.Free)
                    {
                        // Устанавливаем состояние экскаватора "В ремонте"
                        excavator.state = MachineState.Repair;
                        // Состояние мастера 6 разр. - "Ремонт экскаватора"
                        worker6.stateWorker = WorkerState.ExcavatorRepair;
                        // Расчет времени завершение ремонта экскаватора
                        excavator.repairTime = modelMinute + GetRandomValueByExponential(worker6.expectationDurationRepairExcavator);
                        PrintStateMachine(excavator);
                    }
                }
            }

            // Если подошло время завершения ремонта экскаватора
            if (excavator.state == MachineState.Repair && excavator.repairTime == modelMinute)
            {
                // Переводим экскаватор в рабочее состояние
                excavator.state = MachineState.Working;
                // Рассчитываем время до следующей поломки
                excavator.workTime = modelMinute + GetRandomValueByExponential(excavator.expectationDurationWork);
                PrintStateMachine(excavator);

                // Освобождаем мастера 3 разряда, если он занимался ремонтом экскаватора
                if (worker3.stateWorker == WorkerState.ExcavatorRepair)
                    worker3.stateWorker = WorkerState.Free;

                // Освобождаем мастера 6 разряда, если он занимался ремонтом экскаватора
                if (worker6.stateWorker == WorkerState.ExcavatorRepair)
                    worker6.stateWorker = WorkerState.Free;
            }

            // Накопительный учет состояния работы экскаватора
            switch (excavator.state)
            {
                case MachineState.Working:
                    excavator.modelDurationWorkPerDay++;
                    excavator.modelDurationWorkPerAllPeriod++;
                    break;
                case MachineState.Repair:
                    excavator.modelDurationRepairPerDay++;
                    excavator.modelDurationRepairPerAllPeriod++;
                    break;
                case MachineState.WaitingRepair:
                    excavator.modelDurationWaitingPerDay++;
                    excavator.modelDurationWaitingPerAllPeriod++;
                    break;
            }
        }

        private void ModelingOneMinuteBulldozer()
        {
            // Если состояние экскаватора "готов к работе", то рассчитывается время, когда машина выйдет из строя и устанавливается статус "в работе"
            if (bulldozer.state == MachineState.ReadyToWork)
            {
                bulldozer.workTime = modelMinute + GetRandomValueByExponential(bulldozer.expectationDurationWork);
                bulldozer.state = MachineState.Working;
                PrintStateMachine(bulldozer);
            }
            // Если наступило время ремонта, меняется состояние на ожидание ремонта (простой)
            if (bulldozer.state == MachineState.Working && modelMinute == bulldozer.workTime)
            {
                bulldozer.state = MachineState.WaitingRepair;
                PrintStateMachine(bulldozer);
            }
            // Если бульдозер находится в ожидании ремонта
            if (bulldozer.state == MachineState.WaitingRepair)
            {
                // Условия для отправки бульдозера в ремонт:
                // 1. Работают оба мастера и свободны оба
                // 2. Работает один мастер 6 разряда и он свободен

                // Если работают оба мастера (бригада)
                if (bothMasterWorking)
                {
                    // Если свободны оба мастера
                    if (worker3.stateWorker == WorkerState.Free && worker6.stateWorker == WorkerState.Free)
                    {
                        bulldozer.state = MachineState.Repair;
                        worker3.stateWorker = WorkerState.BulldozerRepair;
                        worker6.stateWorker = WorkerState.BulldozerRepair;

                        // Расчет времени завершения ремонта бульдозера
                        bulldozer.repairTime = modelMinute + GetRandomValueByExponential(expValueRepairBulldozerWorkers);
                        PrintStateMachine(bulldozer);
                    }
                }
                // Если работает только мастер 6 разряда
                else
                {
                    if (worker6.stateWorker == WorkerState.Free)
                    {
                        bulldozer.state = MachineState.Repair;
                        worker6.stateWorker = WorkerState.BulldozerRepair;
                        // Расчет времени завершения ремонта бульдозера
                        bulldozer.repairTime = modelMinute + GetRandomValueByExponential(worker6.expectationDurationRepairBulldozer);
                        PrintStateMachine(bulldozer);
                    }
                }
            }

            // Если подошло время завершения ремонта экскаватора
            if (bulldozer.state == MachineState.Repair && bulldozer.repairTime == modelMinute)
            {
                // Переводим экскаватор в рабочее состояние
                bulldozer.state = MachineState.Working;
                // Рассчитываем время до следующей поломки
                bulldozer.workTime = modelMinute + GetRandomValueByExponential(bulldozer.expectationDurationWork);

                PrintStateMachine(bulldozer);

                // Освобождаем мастера 3 разряда, если он занимался ремонтом бульдозера
                if (worker3.stateWorker == WorkerState.BulldozerRepair)
                    worker3.stateWorker = WorkerState.Free;

                // Освобождаем мастера 6 разряда, если он занимался ремонтом бульдозера
                if (worker6.stateWorker == WorkerState.BulldozerRepair)
                    worker6.stateWorker = WorkerState.Free;
            }

            // Накопительный учет состояния работы бульдозера
            switch (bulldozer.state)
            {
                case MachineState.Working:
                    bulldozer.modelDurationWorkPerDay++;
                    bulldozer.modelDurationWorkPerAllPeriod++;
                    break;
                case MachineState.Repair:
                    bulldozer.modelDurationRepairPerDay++;
                    bulldozer.modelDurationRepairPerAllPeriod++;
                    break;
                case MachineState.WaitingRepair:
                    bulldozer.modelDurationWaitingPerDay++;
                    bulldozer.modelDurationWaitingPerAllPeriod++;
                    break;
            }
        }

        #endregion

        private void PrintStateMachine(Machine machine)
        {
            richTextBoxModelingLog.AppendText("Модельное время: " + TimeSpan.FromMinutes(modelMinute).ToString() + ".  ");

            richTextBoxModelingLog.AppendText("Состояние ");

            if (machine.type == MachineType.Bulldozer)
            {
                richTextBoxModelingLog.AppendText("бульдозера: ");
            }
            else if (machine.type == MachineType.Excavator)
            {
                richTextBoxModelingLog.AppendText("экскаватора: ");
            }

            switch (machine.state)
            {
                case MachineState.Working:
                    richTextBoxModelingLog.AppendText("работа. Ожидаемое время поломки: ");
                    richTextBoxModelingLog.AppendText(TimeSpan.FromMinutes(machine.workTime).ToString() + "\r\n");
                    break;
                case MachineState.Repair:
                    richTextBoxModelingLog.AppendText("поломка, начало ремонта. Время выхода с ремонта: ");
                    richTextBoxModelingLog.AppendText(TimeSpan.FromMinutes(machine.repairTime).ToString() + "\r\n");
                    break;
                case MachineState.WaitingRepair:
                    richTextBoxModelingLog.AppendText("поломка, ожидание ремонта." + "\r\n");
                    break;
            }
        }


        #region Вспомогательные функции

        /// <summary>
        /// Кнопка "TestExponential"
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            int value, sum = 0;
            richTextBoxTest.Clear();
            for (int i = 0; i < 100; i++)
            {
                value = this.GetRandomValueByExponential(5000);
                richTextBoxTest.AppendText(value.ToString() + "\r\n");
                sum += value;
            }
            richTextBoxTest.AppendText("---------------\r\n");
            richTextBoxTest.AppendText((sum / 100).ToString());
        }

        Random r = new Random();

        /// <summary>
        /// Сгенерировать случайную величину по экспоненциальному закону
        /// </summary>
        /// <param name="expectedValue">математическое ожидание</param>
        /// <returns></returns>
        private int GetRandomValueByExponential(int expectedValue)
        {
            double val = expectedValue * Math.Log(r.NextDouble());
            return (int)val;
        }

        #endregion
    }
}
