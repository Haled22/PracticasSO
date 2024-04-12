using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//Practica 3


namespace Practica1
{
    public partial class input_window : Form
    {
        // Variables para tiempos
      

        Queue<Proceso> _Procesos = new Queue<Proceso>();//Se crea la lista de procesos
        Queue<Proceso> _lotes = new Queue<Proceso>();
        Queue<GroupBox> _display_options = new Queue<GroupBox>();//Se crea la lista para las opciones de barras
        Queue<GroupBox> _display_options_used = new Queue<GroupBox>();//Se crea la lista para las barras en uso
        Queue<Proceso> interruptedProcesses = new Queue<Proceso>();
        Queue<Proceso> availableOptions = new Queue<Proceso>();
        Queue<Proceso> finishedProcesses = new Queue<Proceso>();
        int longProcess = 0;
        Queue<Label> labelsUsed = new Queue<Label>();
        int contLabelToBeUsed = 0;
        bool processStart = true;
        int addedProcesses = 0;
        int number_processes = 10;
        bool stop = true;
        int quantTime = 3;
        bool showTable = false;
        bool paused = false;
        bool interrupcion = false;
        bool error = false;
        int h, m, s;
        private const int _count = 3;
        public input_window()
        {
            InitializeComponent();
        }
        public enum _labelsUsedEnum : int //Enum que corresponde a los labels que utilizamos en la cola de los labels
        {
            id,
            operation,
            programmerName,
            lotesOutput,
            time,

            blocked1,
            blocked2,
            blocked3,
            timerProcc,
            contNewProc
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessesTable.TabPages.Remove(processTableTab);
            _display_options.Enqueue(groupBox1);
            _display_options.Enqueue(groupBox2);
            _display_options.Enqueue(groupBox3);
            //_display_options.Enqueue(groupBox4);
            foreach(GroupBox box in  _display_options)
            {
                reSize(box, 15 * 10 + 10);
            }
            
            //Se agregan las 4 opciones a la cola
            labelsUsed.Enqueue(labelId);
            labelsUsed.Enqueue(labelOperation);
            labelsUsed.Enqueue(labelProgrammerName);
            labelsUsed.Enqueue(_contLotesOutput);
            labelsUsed.Enqueue(timeTxt);
            
            labelsUsed.Enqueue(blockedTimer1);
            labelsUsed.Enqueue(blockedTimer2);
            labelsUsed.Enqueue(blockedTimer3);
            labelsUsed.Enqueue(processTimertxt);
            labelsUsed.Enqueue(_lblnewProcesses);
            
            //labelsUsed.Enqueue(labelProcesosInput);


        }

        //Contador global
        void globalTimer()
        {
            s += 1;
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            else if (m == 60)
            {
                m = 0;
                h += 1;
            }
        }

      
        //Funcion para hacer operaciones dentro de un string
        public static string Evaluate(string expression)
        {
            
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return (string)row["expression"];
            
            

        }

        private void input_window_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.DoEvents();
        }
        private void reSize(GroupBox b, int amount)//Funcion para cambiar el tamaño de las barras
        {
            
            b.Invoke((MethodInvoker)(() => b.Size = new Size(b.Size.Width, amount)));
            
        }
        private void setText(Label l, String s)//Funcion para facilitar los ajustes de los labels
        {
            l.Invoke((MethodInvoker)(() => l.Text = s));

        }
        private void FillList() // Se añaden procesos a una lista
        {
            //Esta parte se debera quitar en algun momento
            Random random = new Random();
            if (number_processes == 0)
            {


                System.Console.WriteLine("Hola");
                number_processes = random.Next(7, 18);//18
            }
            const String _operaciones = "+-/*";
            

            for (int i = 0; i < number_processes; i++)
            {
                _Procesos.Enqueue(new Proceso());
                _Procesos.ElementAt(i).TimeMax = random.Next(7, 18);
                _Procesos.ElementAt(i).Id = i.ToString();
                _Procesos.ElementAt(i).OpName = ""+random.Next(0, 100) + _operaciones[random.Next(0, 3)] + random.Next(0, 100);
                _Procesos.ElementAt(i).QuantTime =quantTime;
                System.Console.WriteLine(quantTime);
                
                 
                

            }


        }
        // Define un delegado para actualizar el texto del label
        delegate void SetLabelTextDelegate(Label label, string text);

        // Método para actualizar el texto del label de forma segura
        private void SetLabelText(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new SetLabelTextDelegate(SetLabelText), label, text);
            }
            else
            {
                label.Text = text;
            }
        }
        private async void FCFSSchedulling()
        {
            int initialValue = 0;
            stop = false;
            
            for (int i = 0; i < _count; i++)// Se ajustan los tamaños de las barras dependiendo de cuantas necesitemos
            {
                if (number_processes > i)
                {
                    _Procesos.ElementAt(i).IntLabel = labelsUsed.ElementAt((int)_labelsUsedEnum.blocked1 + i);
                    _Procesos.ElementAt(i).IndexLabel = (int)_labelsUsedEnum.blocked1 + i;
                    _Procesos.ElementAt(i).GBox = _display_options.ElementAt(i);    
                  
                }
                else
                {
                    Proceso newPro = new Proceso();
                    newPro.IntLabel = labelsUsed.ElementAt((int)_labelsUsedEnum.blocked1 + i);
                    newPro.IndexLabel = (int)_labelsUsedEnum.blocked1 + i;
                    newPro.GBox = _display_options.ElementAt(i);
                    availableOptions.Enqueue(newPro);
                }
                changeLabel((_Procesos.Count + _lotes.Count + interruptedProcesses.Count).ToString(), _labelsUsedEnum.lotesOutput);
                changeLabel((_Procesos.Count).ToString(), _labelsUsedEnum.contNewProc);
            }
            changeLabel((_Procesos.Count + _lotes.Count + interruptedProcesses.Count).ToString(), _labelsUsedEnum.lotesOutput);
            changeLabel((_Procesos.Count).ToString(), _labelsUsedEnum.contNewProc);
            while (_Procesos.Count + interruptedProcesses.Count > 0 || _lotes.Count > 0)
            {
                

                if (_lotes.Count + interruptedProcesses.Count < 3 && _Procesos.Count > 0)
                {
                    for (int i = 0; _lotes.Count + interruptedProcesses.Count < 3 && _Procesos.Count > 0; i++)
                    {
                        _lotes.Enqueue(_Procesos.Dequeue());
                        if (availableOptions.Count > 0)
                        {
                            _lotes.Last().IntLabel = availableOptions.First().IntLabel;
                            _lotes.Last().GBox = availableOptions.First().GBox;
                            _lotes.Last().IndexLabel = availableOptions.First().IndexLabel;
                            availableOptions.Dequeue();
                        }
                        if (_lotes.Last().TimeMax > 15)
                        {

                            reSize(_lotes.Last().GBox, 15 * 10 + 10);
                        }
                        else
                        {
                            reSize(_lotes.Last().GBox, _lotes.Last().TimeMax * 10 + 10);
                        }

                    }

                }
            
               
                if (processStart)
                {
                    if (_lotes.Count > 0)
                    {


                        if (_lotes.First().WaitTime<TimeSpan.FromMilliseconds(100))
                        {
                            _lotes.First().ResponseTime = DateTime.Now - _lotes.First().ArrivalTime;
                            _lotes.First().WaitTime = _lotes.First().ResponseTime;
                        }
                        // Se asigna el tiempo de primera atención
                       
                        _lotes.First().Status = "Listo";
                        _lotes.First().QuantTime = quantTime;
                        initialValue = setNewProcess(initialValue);
                        SetText(initialValue.ToString());
                        processStart = false;
                    }    
                }

                if (interrupcion)
                {
                    
                    _lotes.First().IntTime = 10;
                    _lotes.First().Status = "Interrumpido";
                    interruptedProcesses.Enqueue(_lotes.Dequeue());
                    interruptedProcesses.Last().TimeMax = initialValue;
                    if (_lotes.Count > 0)
                    {

                        initialValue = setNewProcess(initialValue);
                    }
                    interruptedProcesses.Last().GBox.BackColor = Color.LightCoral;
                    processStart = true;
                    interrupcion = false;
                }
                
                if (error)
                {
                    _lotes.First().GBox.BackColor = Color.DimGray;
                    _lotes.First().Id = "Terminado por error";
                    _lotes.First().Status = "Terminado por error";
                    if (_Procesos.Count() > 0)
                    {
                        _Procesos.First().IntLabel = _lotes.First().IntLabel;
                        _Procesos.First().GBox = _lotes.First().GBox;
                        _Procesos.First().IndexLabel = _lotes.First().IndexLabel;
                    }
                    finishedProcesses.Enqueue(_lotes.First());
                    SetList(_lotes.Dequeue());
                    error = false;
                    processStart = true;
                }
                while(paused)
                {

                }
                while(showTable)
                {

                }
                if (_lotes.Count!=0 && _lotes.First().GBox.Size.Height > 10)//Verificamos que la barra actual no se haya "Terminado"
                {
                    _lotes.First().GBox.BackColor = Color.Aquamarine;//El proceso actual se pone en aquamarine
                                                                        //Se ajusta el tamaño de la barra, disminuyendo la altura
                    reSize(_lotes.First().GBox, _lotes.First().GBox.Size.Height - 10);
                    //Aquí ajustamos cada cuanto queremos que se espere nuestro planificador
                    await Task.Run(() =>
                    {
                        Thread.Sleep(100);
                        globalTimer();
                        initialValue--;
                        _lotes.First().QuantTime = _lotes.First().QuantTime- 1;
                        changeLabel(string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0')), _labelsUsedEnum.time);
                        changeLabel(initialValue.ToString(), _labelsUsedEnum.timerProcc);
                        //Para motivos de pruebas lo tengo en 100 pero deberia ser 1000 <---    
                    });
                    _lotes.First().ServiceTime = DateTime.Now - _lotes.First().ArrivalTime;
                    System.Console.WriteLine(DateTime.Now - _lotes.First().ArrivalTime);
                    _lotes.First().RemainingTime= TimeSpan.FromSeconds(initialValue);
                }
                
                else
                {
                    if (initialValue > 15 && _lotes.Count!=0)
                    {
                        reSize(_lotes.First().GBox, 15 * 10 + 10);

                    }
                    else if (initialValue < 15 && initialValue != 0 && _lotes.Count != 0)
                    {
                        reSize(_lotes.First().GBox, initialValue * 10 + 10);
                    }
                    
                    else if (_lotes.Count != 0)
                    {

                        if (_Procesos.Count() > 0)
                        {
                            if (_Procesos.First().IntLabel == null && availableOptions.Count > 0)
                            {
                                _Procesos.First().IntLabel = availableOptions.First().IntLabel;
                                _Procesos.First().GBox = availableOptions.First().GBox;
                                _Procesos.First().IndexLabel = availableOptions.First().IndexLabel;
                                availableOptions.Dequeue();
                                //Revise soon

                            }


                        }
                        
                        availableOptions.Enqueue(_lotes.First());

                        _lotes.First().GBox.BackColor = Color.LimeGreen;
                        
                        _lotes.First().FinishTime = DateTime.Now;
                        _lotes.First().ReturnTime = _lotes.First().FinishTime - _lotes.First().ArrivalTime;
                        _lotes.First().ServiceTime = _lotes.First().ReturnTime;
                        _lotes.First().Status = "Terminado";
                        finishedProcesses.Enqueue(_lotes.First());
                        
                        reSize(finishedProcesses.Last().GBox, 10);
                        if(_Procesos.Count==0)
                        {
                            finishedProcesses.First().GBox.BackColor = Color.DimGray;
                        }
                        
                        
                        SetList(_lotes.Dequeue());
                       

                        changeLabel((_Procesos.Count + _lotes.Count + interruptedProcesses.Count).ToString(), _labelsUsedEnum.lotesOutput);
                        changeLabel((_Procesos.Count).ToString(), _labelsUsedEnum.contNewProc);
                        processStart = true;
                    }
                    //else if(interruptedProcesses)

                }
                
                foreach (Proceso interrupted in interruptedProcesses)
                {
                    if (_lotes.Count == 0)
                    {
                        await Task.Run(() =>
                        {
                            Thread.Sleep(100);
                            globalTimer();
                            changeLabel(string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0')), _labelsUsedEnum.time);
                        });
                    }
                    interrupted.IntTime -= 1;
                    interrupted.WaitTime += TimeSpan.FromMilliseconds(100);
                    System.Console.WriteLine(interrupted.IndexLabel);
                    changeLabel(interrupted.IntTime.ToString(), (_labelsUsedEnum)interrupted.IndexLabel);
                }
                if (interruptedProcesses.Count > 0)
                {
                    if (interruptedProcesses.First().IntTime == 0)
                    {
                        interruptedProcesses.First().Status = "Nuevo";
                        _lotes.Enqueue(interruptedProcesses.Dequeue());
                        _lotes.Last().GBox.BackColor = Color.LimeGreen;
                    }
                }
                if(_lotes.Count()>0)
                { 
                    if (_lotes.First().QuantTime == 0)
                    {
                        //Work in progress

                        if (_Procesos.Count() > 0)
                        {
                            _Procesos.First().IntLabel = _lotes.First().IntLabel;
                            _Procesos.First().GBox = _lotes.First().GBox;
                            _Procesos.First().IndexLabel = _lotes.First().IndexLabel;

                        }

                        _lotes.First().TimeMax -= quantTime;
                        _lotes.First().QuantTime = quantTime;
                        _lotes.First().GBox.BackColor = Color.LimeGreen;
                        _lotes.Enqueue(_lotes.Dequeue());

                        if (_lotes.First().TimeMax > 15)
                        {

                            reSize(_lotes.First().GBox, 15 * 10 + 10);
                        }
                        else
                        {
                            reSize(_lotes.First().GBox, _lotes.First().TimeMax * 10 + 10);
                        }

                        processStart = true;

                    }
                }

            }
            number_processes = 0;
            stop = true;
            System.Console.WriteLine(_lotes.Count());
        }
        //Funcion para cambiar los labels
        private void changeLabel(string newtext,_labelsUsedEnum toBeChanged)
        {
            contLabelToBeUsed = (int)toBeChanged;
            processInfo(newtext);
        }
        //Funcion para cambiar los labels cuando de cambia de proceso
        private int setNewProcess(int initialValue)
        {
            changeLabel(_lotes.ElementAt(0).Id, _labelsUsedEnum.id);
            changeLabel(_lotes.ElementAt(0).OpName, _labelsUsedEnum.operation);
            initialValue = _lotes.ElementAt(0).TimeMax;
            longProcess = initialValue / 15 + 1;
            changeLabel(initialValue.ToString(), _labelsUsedEnum.timerProcc);
            return initialValue;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startBtn(object sender, EventArgs e)//Boton de comienzo
        {
            // Se comienzan tanto el moviemieto de las barras como en reloj
            if(stop)
            {
                //Se resetea el reloj global
                h = 0;
                s = 0;
                m = 0;
                
                if (int.TryParse(inputNumProcesses.Text,out _))        
                {
                    number_processes = int.Parse(inputNumProcesses.Text);
                }
                if (int.TryParse(quantInput.Text,out _))
                {
                     quantTime = int.Parse(quantInput.Text);
                }
                interruptedProcesses.Clear();
                finishedProcesses.Clear();
                FillList();
                Thread _ThreadProcesses = new Thread(new ThreadStart(FCFSSchedulling));
                reSize(_display_options.ElementAt(0), 150);
                reSize(_display_options.ElementAt(1), 150);
                reSize(_display_options.ElementAt(2), 150);
                //reSize(_display_options.ElementAt(3), 150);
                ClearList();
                _ThreadProcesses.Start();
               
                //Thread setProcessTimer = new Thread(new ThreadStart(processTimerset));

            }
            
            
            
        }
        delegate void SetTextCallback(string text);
        delegate void SetListCallback(Proceso text);
        delegate void ClearListCallback();
        delegate void ProcessInfoCallback(string text);

        private void ClearList()
        {
            
            if (this.listViewPastProcesses.InvokeRequired)
            {
                ClearListCallback d = new ClearListCallback(ClearList);
                this.Invoke(d, new object[] {  });
            }
            else
            {
                if(showTable)
                {
                    this.processTable.Items.Clear();
                }
                else
                {
                    this.listViewPastProcesses.Items.Clear();
                }
                
            }
        }
        private void SetText(string text)
        {
            
            if (this.processTimertxt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.processTimertxt.Text = text;
            }
        }
        //funcion para cambiar el ViewList de los procesos anteriores
        private void SetList(Proceso proceso)
        {
            
            if (this.listViewPastProcesses.InvokeRequired)
            {
                SetListCallback d = new SetListCallback(SetList);
                this.Invoke(d, new object[] { proceso });
            }
            else
            {
                ListViewItem newItem = new ListViewItem(proceso.Id, proceso.OpName);
                if (showTable)
                {
                    newItem.SubItems.Add(proceso.Status);
                }
                if (proceso.OpName == "Terminado por error")
                {
                    newItem.SubItems.Add(proceso.OpName);
                }
                else
                {
                    if(proceso.Status=="Terminado")
                    {
                        newItem.SubItems.Add(proceso.OpName + "= " + Evaluate(proceso.OpName));
                    }
                    else
                    {
                        newItem.SubItems.Add(proceso.OpName);
                    }
                    
                }
                
                newItem.SubItems.Add(proceso.TimeMax.ToString());
                
                newItem.SubItems.Add(proceso.ArrivalTime.ToString());
                newItem.SubItems.Add(proceso.FinishTime.ToString());
                newItem.SubItems.Add(proceso.ReturnTime.ToString());
                newItem.SubItems.Add(proceso.ResponseTime.ToString());
                newItem.SubItems.Add(proceso.WaitTime.ToString());
                if (showTable)
                {
                    newItem.SubItems.Add(proceso.RemainingTime.ToString());

                }
               
                newItem.SubItems.Add(proceso.ServiceTime.ToString());
                if (showTable)
                {
                    
                    processTable.Items.Add(newItem);
                }
                else
                {
                    listViewPastProcesses.Items.Add(newItem);
                }
                
            }
        }


        private void processInfo(string text) //Función para cambiar los datos de cualquier label, sin tener qué hacer una por cada label.
        {

            

            if (this.InvokeRequired)
            {
                ProcessInfoCallback d = new ProcessInfoCallback(processInfo);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                
                labelsUsed.ElementAt(contLabelToBeUsed).Text = text;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void input_window_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.P)
            {
                System.Console.WriteLine(" "+ e.KeyChar);
                paused = true;
            }
            else if(e.KeyChar == (char)Keys.C)
            {
                System.Console.WriteLine(" " + e.KeyChar);
                paused = false;
                if(showTable==true)
                {
                    ClearList();
                    ProcessesTable.TabPages.Remove(processTableTab);
                    showTable = false;
                }

            }
            else if (e.KeyChar == (char)Keys.I)
            {
                System.Console.WriteLine(" " + e.KeyChar);
                interrupcion = true;
                
            }
            else if (e.KeyChar == (char)Keys.E)
            {
                System.Console.WriteLine(" " + e.KeyChar);
                error = true;
            }
            else if (e.KeyChar == (char)Keys.N)
            {
                
                if (stop == false)
                {
                    System.Console.WriteLine(" " + e.KeyChar);
                    const String _operaciones = "+-/*";
                    Random random = new Random();
                    Proceso newProcess = new Proceso();
                    newProcess.TimeMax = random.Next(7, 18);
                    newProcess.Id = (number_processes+addedProcesses).ToString();
                    newProcess.OpName = "" + random.Next(0, 100) + _operaciones[random.Next(0, 3)] + random.Next(0, 100);
                    if (_Procesos.Count + interruptedProcesses.Count == 0)
                    {
                        newProcess.IntLabel = availableOptions.First().IntLabel;
                        newProcess.GBox = availableOptions.First().GBox;
                        newProcess.IndexLabel = availableOptions.First().IndexLabel;
                        availableOptions.Dequeue();
                    }

                    _Procesos.Enqueue(newProcess);
                    changeLabel((_Procesos.Count + _lotes.Count + interruptedProcesses.Count).ToString(), _labelsUsedEnum.lotesOutput);
                    changeLabel((_Procesos.Count).ToString(), _labelsUsedEnum.contNewProc);
                    addedProcesses += 1;
                }
            }
            else if (e.KeyChar == (char)Keys.B)
            {
                System.Console.WriteLine(" " + e.KeyChar);
                if (showTable == false)
                {


                    showTable = true;
                    ProcessesTable.TabPages.Add(processTableTab);
                    foreach (Proceso p in finishedProcesses)
                    {
                        SetList(p);
                    }
                    foreach (Proceso p in _lotes)
                    {
                        SetList(p);
                    }
                    foreach (Proceso p in interruptedProcesses)
                    {
                        SetList(p);
                    }
                    foreach (Proceso p in _Procesos)
                    {
                        SetList(p);
                    }
                }
            }
        }

        private void tabPage2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            System.Console.WriteLine("Hola");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void addProcess_Click(object sender, EventArgs e)
        {
            


            
        }

        private void processTimerset()
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
