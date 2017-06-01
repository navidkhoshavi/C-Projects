using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankSimulation
{
    
    public partial class Form1 : Form
    {
           int SimClock = 0, ServiceTime1, SumCustomerCAinA1 = 0,
           SumCustomerCBinA1 = 0, SumCustomerCCinA1 = 0, TotalServiced1 = 0
           , TotalServiced2 = 0, TotalServiced3 = 0,
           EnterTime1, EnterTime2, EnterTime3,
           SumDalayCAinA1 = 0,
           SumCustomerCAinA2 = 0, SumDalayCAinA2 = 0, SumCustomerCBinA2 = 0,
           SumDalayCBinA2 = 0, SumCustomerCCinA2 = 0, SumDalayCCinA2 = 0, SumDalayCBinA1 = 0,
           SumCustomerCBinA3 = 0, SumDalayCAinA3 = 0,
           SumCustomerCAinA3 = 0, SumDalayCBinA3 = 0, SumCustomerCCinA3 = 0, SumDalayCCinA1 = 0,
           SumDalayCCinA3 = 0, ServiceTime2, ServiceTime3;
        String Ctype = "0";
        Boolean ForbidenA1 = false, ForbidenA2 = false;

        public void initprj()
        {
          SimClock = 0; ServiceTime1=0; SumCustomerCAinA1 = 0;
          SumCustomerCBinA1 = 0; SumCustomerCCinA1 = 0; TotalServiced1 = 0
          ; TotalServiced2 = 0; TotalServiced3 = 0;
          EnterTime1=0; EnterTime2=0; EnterTime3=0;
          SumDalayCAinA1 = 0;
          SumCustomerCAinA2 = 0; SumDalayCAinA2 = 0; SumCustomerCBinA2 = 0;
          SumDalayCBinA2 = 0; SumCustomerCCinA2 = 0; SumDalayCCinA2 = 0; SumDalayCBinA1 = 0;
          SumCustomerCBinA3 = 0; SumDalayCAinA3 = 0;
          SumCustomerCAinA3 = 0; SumDalayCBinA3 = 0; SumCustomerCCinA3 = 0; SumDalayCCinA1 = 0;
          SumDalayCCinA3 = 0; ServiceTime2=0; ServiceTime3=0;
          Ctype = "0";
          ForbidenA1 = false; ForbidenA2 = false;
          listBox1.Items.Clear(); listBox2.Items.Clear(); listBox3.Items.Clear();
          listBox4.Items.Clear(); listBox5.Items.Clear(); listBox6.Items.Clear();
          listBox7.Items.Clear(); listBox8.Items.Clear(); listBox9.Items.Clear();
          textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = "";
          textBox5.Text = ""; textBox6.Text = ""; textBox7.Text = ""; textBox8.Text = "";
          panel5.Visible = false; button3.Enabled = false;
           
        }
            
        
           
        public Form1()
        {
            
            InitializeComponent();
            panel5.Visible = false;
            button3.Enabled = false;
            
        }

        
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }


        public void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int TCA3, TCA2, TCA1, x,
            MinQueue, MinQueueCount, BulletinState, sertime = 0;
            TCA1 = 0; TCA2 = 0; TCA3 = 0;

            if (SimClock < 1200)
            {
                //System.Threading.Thread.Sleep(1000);
                SimClock = SimClock + 10;
                textBox1.Text = Convert.ToString(SimClock);

                //------------------------Delet from Queue----------------------

                //======================Delet From listBox1====================
                if (listBox1.Items.Count > 0)
                {
                    EnterTime1 = Convert.ToInt32(listBox3.Items[0]);
                    ServiceTime1 = Convert.ToInt32(listBox2.Items[0]);
                    ServiceTime1 = ServiceTime1 - 10;
                    String temp = Convert.ToString(ServiceTime1);
                    listBox2.Items[0] = temp;
                    if (ServiceTime1 == 0)
                    {
                        
                        Ctype = Convert.ToString(listBox1.Items[0]);
                        if (Ctype == "ca")
                        {
                            SumCustomerCAinA1 = SumCustomerCAinA1 + 1;
                            SumDalayCAinA1=SumDalayCAinA1+SimClock-EnterTime1;
                        }
                        else if (Ctype == "cb")
                        {
                            SumCustomerCBinA1 = SumCustomerCBinA1 + 1;
                            SumDalayCBinA1=SumDalayCBinA1+SimClock-EnterTime1;
                        }
                        else
                        {
                            Ctype = "cc";
                            SumCustomerCCinA1 = SumCustomerCCinA1 + 1;
                            SumDalayCCinA1=SumDalayCCinA1+SimClock-EnterTime1;
                        }
                          
                        TotalServiced1 = TotalServiced1 + 1;
                        textBox3.Text = Convert.ToString(TotalServiced1);
                        listBox1.Items.Remove(listBox1.Items[0]);
                        listBox2.Items.Remove(listBox2.Items[0]);
                        listBox3.Items.Remove(listBox3.Items[0]);

                    }//end if (ServiceTime1 == 0)

                }//end if (listBox1.Items.Count > 0)


                //======================Delet From listBox2====================
                if (listBox4.Items.Count > 0)
                {
                    EnterTime2 = Convert.ToInt32(listBox6.Items[0]);
                    ServiceTime2 = Convert.ToInt32(listBox5.Items[0]);
                    ServiceTime2 = ServiceTime2 - 10;
                    String temp = Convert.ToString(ServiceTime2);
                    listBox5.Items[0] = temp;
                    if (ServiceTime2 == 0)
                    {
                        Ctype = Convert.ToString(listBox4.Items[0]);
                        if (Ctype == "ca")
                        {
                            SumCustomerCAinA2 = SumCustomerCAinA2 + 1;
                            SumDalayCAinA2=SumDalayCAinA2+SimClock-EnterTime2;
                        }
                        else if (Ctype == "cb")
                        {
                            SumCustomerCBinA2 = SumCustomerCBinA2 + 1;
                            SumDalayCBinA2=SumDalayCBinA2+SimClock-EnterTime2;
                        }
                        else
                        {
                            Ctype = "cc";
                            SumCustomerCCinA2 = SumCustomerCCinA2 + 1;
                            SumDalayCCinA2=SumDalayCCinA2+SimClock-EnterTime2;
                        }
                        TotalServiced2 = TotalServiced2 + 1;
                        textBox4.Text = Convert.ToString(TotalServiced2);
                        listBox4.Items.Remove(listBox4.Items[0]);
                        listBox5.Items.Remove(listBox5.Items[0]);
                        listBox6.Items.Remove(listBox6.Items[0]);

                    }//end if (ServiceTime2 == 0)

                }//end if (listBox2.Items.Count > 0)

                //======================Delet From listBox3====================
                if (listBox7.Items.Count > 0)
                {
                    EnterTime3 = Convert.ToInt32(listBox9.Items[0]);
                    ServiceTime3 = Convert.ToInt32(listBox8.Items[0]);
                    ServiceTime3 = ServiceTime3 - 10;
                    String temp = Convert.ToString(ServiceTime3);
                    listBox8.Items[0] = temp;
                    if (ServiceTime3 == 0)
                    {
                        Ctype = Convert.ToString(listBox7.Items[0]);
                        if (Ctype == "ca")
                        {
                            SumCustomerCAinA3 = SumCustomerCAinA3 + 1;
                            SumDalayCAinA3=SumDalayCAinA3+SimClock-EnterTime3;
                        }
                        else if (Ctype == "cb")
                        {
                            SumCustomerCBinA3 = SumCustomerCBinA3 + 1;
                            SumDalayCBinA3=SumDalayCBinA3+SimClock-EnterTime3;
                        }
                        else
                        {
                            Ctype = "cc";
                            SumCustomerCCinA3 = SumCustomerCCinA3 + 1;
                            SumDalayCCinA3=SumDalayCCinA3+SimClock-EnterTime3;
                        }
                        TotalServiced3 = TotalServiced3 + 1;
                        textBox6.Text = Convert.ToString(TotalServiced3);
                        listBox7.Items.Remove(listBox7.Items[0]);
                        listBox8.Items.Remove(listBox8.Items[0]);
                        listBox9.Items.Remove(listBox9.Items[0]);

                    }//end if (ServiceTime3 == 0)

                }//end if (listBox3.Items.Count > 0)
                //=====================Insert In Queues =====================
                if (RandomNumber(0, 100) <= 40)
                {
                    Ctype = "ca";
                    sertime = 60;
                }
                else if ((RandomNumber(0, 100) <= 70) && (RandomNumber(0, 100) > 40))
                {
                    Ctype = "cc";
                    sertime = 40;
                }
                else
                {
                    Ctype = "cb";
                    sertime = 70;
                }
                //-----Find MinQueue-------
                MinQueue = 1;

                if (listBox4.Items.Count < listBox1.Items.Count)
                    MinQueue = 2;
                //####### Customer Type B Limitation ######
                if (Ctype == "cb")
                {
                    if ((listBox7.Items.Count < listBox1.Items.Count) && (listBox7.Items.Count < listBox4.Items.Count))
                        MinQueue = 3;
                    else if ((ForbidenA1 == true) && (ForbidenA2 == true))
                        MinQueue = 3;
                    else if (ForbidenA1 == true)
                    {
                        MinQueue = 2;
                        if (listBox7.Items.Count < listBox4.Items.Count)
                            MinQueue = 3;
                    }
                    else if (ForbidenA2 == true)
                    {
                        MinQueue = 1;
                        if (listBox7.Items.Count < listBox1.Items.Count)
                            MinQueue = 3;
                    }
                }//Find MinQueue

                //#########################################
                //------Inseting in Queue-------------------
                if (MinQueue == 1)
                {
                    listBox1.Items.Add(Ctype);
                    listBox2.Items.Add(sertime);
                    listBox3.Items.Add(SimClock);
                   
                }//if (MinQueue == 1)
                else if (MinQueue == 2)
                {
                    listBox4.Items.Add(Ctype);
                    listBox5.Items.Add(sertime);
                    listBox6.Items.Add(SimClock);
                    
                }//else if (MinQueue == 2)
                else if (MinQueue == 3)
                {
                    listBox7.Items.Add(Ctype);
                    listBox8.Items.Add(sertime);
                    listBox9.Items.Add(SimClock);
                    
                }//else if (MinQueue == 3)
                //============= Board Messeges ==========
                if ((listBox1.Items.Count < 4) && (listBox4.Items.Count < 4))
                    BulletinState = 1;
                textBox8.Text = "WelCome.The Bank is working";
                if (listBox1.Items.Count > 4)
                {
                    ForbidenA1 = true;
                    BulletinState = 2;
                    textBox8.Text = "Customer Type CB Dont Have Access to standing in queue A1";
                }
                else
                    ForbidenA1 = false;
                if (listBox4.Items.Count > 4)
                {
                    ForbidenA2 = true;
                    BulletinState = 3;
                    textBox8.Text = "Customer Type CB Dont Have Accessto standing in queue A2";
                }
                else
                    ForbidenA2 = false;
                if ((ForbidenA1 == true) && (ForbidenA2 == true))
                {
                    BulletinState = 4;
                    textBox8.Text = "Customer Type CB Dont Have Access to standing in queues A1 & A2";
                }
                // ------------------------------------------------------------------------------------
                TCA1 = listBox1.Items.Count;
                textBox2.Text = Convert.ToString(TCA1);
                TCA2 = listBox4.Items.Count;
                textBox5.Text = Convert.ToString(TCA2);
                TCA3 = listBox7.Items.Count;
                textBox7.Text = Convert.ToString(TCA3);

                textBox9.Text = Convert.ToString(SumCustomerCAinA1);
                textBox10.Text = Convert.ToString(SumCustomerCAinA2);
                textBox11.Text = Convert.ToString(SumCustomerCAinA3);
                textBox14.Text = Convert.ToString(SumCustomerCBinA1);
                textBox13.Text = Convert.ToString(SumCustomerCBinA2);
                textBox12.Text = Convert.ToString(SumCustomerCBinA3);
                textBox17.Text = Convert.ToString(SumCustomerCCinA1);
                textBox16.Text = Convert.ToString(SumCustomerCCinA2);
                textBox15.Text = Convert.ToString(SumCustomerCCinA3);

                if (SumCustomerCAinA1 > 0)
                {
                    float DelayCAinA1 = SumDalayCAinA1 / SumCustomerCAinA1;
                    textBox26.Text = Convert.ToString(DelayCAinA1);
                }

                if (SumCustomerCAinA2 > 0)
                {
                    float DelayCAinA2 = SumDalayCAinA2 / SumCustomerCAinA2;
                    textBox25.Text = Convert.ToString(DelayCAinA2);
                }
                               
                    textBox24.Text = Convert.ToString(0);


                if (SumCustomerCBinA1 > 0)
                {
                        float DelayCBinA1 = SumDalayCBinA1 / SumCustomerCBinA1;
                        textBox23.Text = Convert.ToString(DelayCBinA1);
                }

                if (SumCustomerCBinA2 > 0)
                {
                        float DelayCBinA2 = SumDalayCBinA2 / SumCustomerCBinA2;
                        textBox22.Text = Convert.ToString(DelayCBinA2);
                }

                if (SumCustomerCBinA3 > 0)
                {
                    float DelayCBinA3 = SumDalayCBinA3 / SumCustomerCBinA3;
                    textBox21.Text = Convert.ToString(DelayCBinA3);
                }


                if (SumCustomerCCinA1 > 0)
                {
                    float DelayCCinA1 = SumDalayCCinA1 / SumCustomerCCinA1;
                    textBox20.Text = Convert.ToString(DelayCCinA1);
                }

                if (SumCustomerCCinA2 > 0)
                {
                    float DelayCCinA2 = SumDalayCCinA2 / SumCustomerCCinA2;
                    textBox19.Text = Convert.ToString(DelayCCinA2);
                }

                textBox18.Text = Convert.ToString(0);
                

            }//end if (SimClock < 1200)
            else
            {
                textBox8.Text = "The time is over . Please leave the Bank !!";
                timer1.Enabled = false;
                button3.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            initprj();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

     
      }
}