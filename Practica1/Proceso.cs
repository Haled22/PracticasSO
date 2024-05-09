using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    class Proceso
    {
        private string _Name;
        private int _TimeMax;
        private string _opName;
        private string _id;
        private GroupBox _gBox;
        private int _intTime;
        private Label _intLabel;
        private int _indexLabel;
        private int _quantTime;
        private int _size;
        private DateTime _arrivalTime;//Hora de llegada
        private DateTime _finishTime;//Hora en la que se finalizo
        private TimeSpan _returnTime;//Timepo total desde que llega hasta que termina
        private TimeSpan _responseTime;//Tiempo total desde que llega hasta que es atendido por primera vez
        private TimeSpan _waitTime;//Tiempo que el proceso espero para usar el procesador
        private TimeSpan _serviceTime;//Tiempo dentro del procesador
        private TimeSpan _RemainingTime;
        private string _status= "Nuevo";

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public DateTime ArrivalTime
        {
            get { return _arrivalTime; }
            set { _arrivalTime = value; }
        }
        public DateTime FinishTime
        {
            get { return _finishTime; }
            set { _finishTime = value; }
        }
        public TimeSpan RemainingTime
        {
            get { return _RemainingTime; }
            set { _RemainingTime = value; }
        }
        public TimeSpan ReturnTime
        {
            get { return _returnTime; }
            set { _returnTime = value; }
        }
        public TimeSpan ResponseTime
        {
            get { return _responseTime; }
            set { _responseTime = value; }
        }
        public TimeSpan WaitTime
        {
            get { return _waitTime; }
            set { _waitTime = value; }
        }
        public TimeSpan ServiceTime
        {
            get { return _serviceTime; }
            set { _serviceTime = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int IndexLabel
        {
            get { return _indexLabel; }
            set { _indexLabel = value; }
        }
        public int QuantTime
        {
            get { return _quantTime; }
            set { _quantTime = value; }
        }
        public Label IntLabel
        {
            get { return _intLabel; }
            set { _intLabel = value; }
        }
        public int IntTime
        {
            get { return _intTime; }
            set { _intTime = value; }
        }
        public GroupBox GBox
        {
            get { return _gBox; }
            set { _gBox = value; }
        }

        public int TimeMax
        {
            get { return _TimeMax; }
            set { _TimeMax = value; }
        }

        public string OpName
        {
            get { return _opName; }
            set { _opName = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
