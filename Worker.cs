﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationBuilding
{
    /// <summary>
    /// Состояния мастера
    /// </summary>
    public enum WorkerState
    {
        Free, //Мастер свободен
        ExcavatorRepair, //Мастер чинит Эксаватор
        BulldozerRepair //Мастер чинит Бульдозер
    }

    internal class Worker
    {
        // Зарплата рабочего (руб в минуту)
        public decimal salaryPerMinute = 0;

        // Математическое ожидание времени ремонта экскаватора
        public int expectationDurationRepairExcavator = 0;

        // Математическое ожидание времени ремонта бульдозера
        public int expectationDurationRepairBulldozer = 0;


        // Текущее состояние мастера (обновляется в процессе моделирования)
        public WorkerState stateWorker = WorkerState.Free;

        // Продолжительности времени нахождения в разных состояниях за последний день моделирования (в минутах)
        public int modelTimeRepairExcavatorPerDay = 0;
        public int modelTimeRepairBulldozerPerDay = 0;
        public int modelTimeFreePerDay = 0;

        // Продолжительности времени нахождения в разных состояниях за весь период моделирования (в минутах)
        public int modelTimeRepairExcavatorPerAllPeriod = 0;
        public int modelTimeRepairBulldozerPerAllPeriod = 0;
        public int modelTimeFreePerAllPeriod = 0;

        public Worker()
        {

        }
    }
}
