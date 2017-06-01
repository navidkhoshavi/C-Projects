using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace find_path
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            treeNods = new Node[68];
            InitializeComponent();
            goal = b10_10;
        }
        //tree serch****************************************************************        
        private Node[] treeNods;
        private void setchild(int []array,int ch1,int ch2,int ch3)
        {
            array[0] = ch1;
            array[1] = ch2;
            array[2] = ch3;
        }
        //initialize tree***********************************************************
        private void treeInitialize()
        {
            //**************************sotoon 1&2**********************************
            int[] childs = new int[3];
            setchild(childs, (int)Elements.b2_1, -1, -1);
            treeNodes[(int)Elements.b1_1]=new Node(Elements.b1_1,0,0,childs,false);

            setchild(childs, Elements.b3_1, -1, -1);
            treeNodes[Elements.b2_1] = new Node(Elements.b2_1, 1, Elements.b1_1, childs, false);
            
            setchild(childs, Elements.b3_2, Elements.b4_1, -1);
            treeNodes[Elements.b3_1] = new Node(Elements.b3_1, 2, Elements.b2_1, childs, false);
            
            setchild(childs, -1, -1, -1);
            treeNodes[Elements.b3_2] = new Node(Elements.b3_2, 3, Elements.b3_1, childs, false);
            
            setchild(childs, Elements.b4_2, -1, -1);
            treeNodes[Elements.b4_1] = new Node(Elements.b4_1, 3, Elements.b3_1, childs, false);
            
            setchild(childs, Elements.b5_2, -1, -1);
            treeNodes[Elements.b4_2] = new Node(Elements.b4_2, 4, Elements.b4_1, childs, false);
            
            setchild(childs, Elements.b6_2, Elements.b5_3, -1);
            treeNodes[Elements.b5_2] = new Node(Elements.b5_2, 5, Elements.b4_2, childs, false);
            
            setchild(childs, Elements.b6_1, -1, -1);
            treeNodes[Elements.b6_2] = new Node(Elements.b6_2, 6, Elements.b5_2, childs, false);
            
            setchild(childs, Elements.b7_1, -1, -1);
            treeNods[Elements.b6_1] = new Node(Elements.b6_1, 7, Elements.b6_2, childs, false);
            
            setchild(childs, -1, -1, -1);
            treeNods[Elements.b7_1] = new Node(Elements.b7_1, 8, Elements.b6_1, childs, false);
            
            setchild(childs, Elements.b9_2, -1, -1);
            treeNods[Elements.b8_2] = new Node(Elements.b8_2, 12, Elements.b8_3, childs, false);
            
            setchild(childs, -1, -1, -1);
            treeNods[Elements.b9_1] = new Node(Elements.b9_1, 14, Elements.b9_2, childs, false);
            
            setchild(childs, Elements.b9_1, Elements.b10_2, -1);
            treeNods[Elements.b9_2] = new Node(Elements.b9_2, 13, Elements.b8_2, childs, false);
            
            setchild(childs, -1, -1, -1);
            treeNods[Elements.b10_2] = new Node(Elements.b10_2, 14, Elements.b9_2, childs, false);
            //***************************sotoon 3***********************************
            setchild(childs, -1, -1, -1);
            treeNods[Elements.b1_3] = new Node(Elements.b1_3, 12, Elements.b1_4, childs, false);
            
            setchild(childs, -1, -1, -1);
            treeNods[Elements.b2_3] = new Node(Elements.b2_3, 11, Elements.b2_4, childs, false);
            
            setchild(childs, Elements.b5_4, -1, -1);
            treeNods[Elements.b5_3] = new Node(Elements.b5_3, 6, Elements.b5_2, childs, false);
            
            setchild(childs, Elements.b8_3, -1, -1);
            treeNods[Elements.b7_3] = new Node(Elements.b7_3, 10, Elements.b7_4, childs, false);
            
            setchild(childs, Elements.b8_2, -1, -1);
            treeNods[Elements.b8_3] = new Node(Elements.b8_3, 11, Elements.b7_3, childs, false);
            
            setchild(childs, -1, -1, -1);
            treeNods[Elements.b10_3] = new Node(Elements.b10_3, 13, Elements.b10_4, childs, false);
            //*************************sotoon 4*************************************
            setchild(childs, Elements.b1_3, -1, -1);
            treeNods[Elements.b1_4] = new Node(Elements.b1_4, 11, Elements.b2_4, childs, false);
            
            setchild(childs, Elements.b2_3, Elements.b1_4, Elements.b2_5);
            treeNods[Elements.b2_4] = new Node(Elements.b2_4, 10, Elements.b3_4, childs, false);
            
            setchild(childs, Elements.b2_4, -1, -1);
            treeNods[Elements.b3_4] = new Node(Elements.b3_4, 9, Elements.b4_4, childs, false);
            
            setchild(childs, Elements.b3_4, -1, -1);
            treeNods[Elements.b4_4] = new Node(Elements.b4_4, 8, Elements.b5_4, childs, false);
            
            setchild(childs, Elements.b4_4, Elements.b6_4, Elements.b5_5);
            treeNods[Elements.b5_4] = new Node(Elements.b5_4, 7, Elements.b5_3, childs, false);
            
            setchild(childs, Elements.b7_4, -1, -1);
            treeNods[Elements.b6_4] = new Node(Elements.b6_4, 8, Elements.b5_4, childs, false);
            
            setchild(childs, Elements.b7_3, Elements.b8_4, -1);
            treeNods[Elements.b7_4] = new Node(Elements.b7_4, 9, Elements.b6_4, childs, false);
            
            setchild(childs, Elements.b9_4, -1, -1);
            treeNods[Elements.b8_4] = new Node(Elements.b8_4, 10, Elements.b7_4, childs, false);
            
            setchild(childs, Elements.b10_4, Elements.b9_5, -1);
            treeNods[Elements.b9_4] = new Node(Elements.b9_4, 11, Elements.b8_4, childs, false);
            
            setchild(childs, Elements.b10_3, -1, -1);
            treeNods[Elements.b10_4] = new Node(Elements.b10_4, 12, Elements.b9_4, childs, false);
            //***************************sotoon 5***********************************
            setchild(childs,-1, -1, -1);
            treeNods[Elements.b2_5] = new Node(Elements.b2_5, 11, Elements.b2_4, childs, false);

            setchild(childs, Elements.b4_6, -1, -1);
            treeNods[Elements.b4_5] = new Node(Elements.b4_5, 9, Elements.b5_5, childs, false);

            setchild(childs, Elements.b6_5, Elements.b4_5, -1);
            treeNods[Elements.b5_5] = new Node(Elements.b5_5, 8, Elements.b5_4, childs, false);

            setchild(childs, Elements.b7_5, -1, -1);
            treeNods[Elements.b6_5] = new Node(Elements.b6_5, 9, Elements.b5_5, childs, false);

            setchild(childs, -1, -1, -1);
            treeNods[Elements.b7_5] = new Node(Elements.b7_5, 10, Elements.b6_5, childs, false);

            setchild(childs, Elements.b10_5, Elements.b9_6, -1);
            treeNods[Elements.b9_5] = new Node(Elements.b9_5, 12, Elements.b9_4, childs, false);

            setchild(childs, -1, -1, -1);
            treeNods[Elements.b10_5] = new Node(Elements.b10_5, 13, Elements.b9_5, childs, false);
            //********************sotoon 6*****************************************
            setchild(childs, -1, -1, -1);
            treeNods[Elements.b1_6] = new Node(Elements.b1_6, 13, Elements.b2_6, childs, false);

            setchild(childs, Elements.b1_6, Elements.b2_7, -1);
            treeNods[Elements.b2_6] = new Node(Elements.b2_6, 12, Elements.b3_6, childs, false);

            setchild(childs, Elements.b2_6, -1, -1);
            treeNods[Elements.b3_6] = new Node(Elements.b3_6, 11, Elements.b4_6, childs, false);

            setchild(childs, Elements.b3_6, -1, -1);
            treeNods[Elements.b4_6] = new Node(Elements.b4_6, 10, Elements.b4_5, childs, false);

            setchild(childs, Elements.b9_7, -1, -1);
            treeNods[Elements.b9_6] = new Node(Elements.b9_9, 13, Elements.b9_5, childs, false);
            //**********************sotoon 7****************************************
            setchild(childs, Elements.b2_8, -1, -1);
            treeNods[Elements.b2_7] = new Node(Elements.b2_7, 13, Elements.b2_6, childs, false);

            setchild(childs, Elements.b7_8, -1, -1);
            treeNods[Elements.b7_7] = new Node(Elements.b7_7, 16, Elements.b8_7, childs, false);

            setchild(childs, Elements.b7_7, -1, -1);
            treeNods[Elements.b8_7] = new Node(Elements.b8_7, 15, Elements.b9_7, childs, false);

            setchild(childs, Elements.b10_7, Elements.b8_7, -1);
            treeNods[Elements.b9_7] = new Node(Elements.b9_7, 14, Elements.b9_6, childs, false);

            setchild(childs, -1, -1, -1);
            treeNods[Elements.b10_7] = new Node(Elements.b10_7, 15, Elements.b9_7, childs, false);
            //***********************sotoon 8****************************************
            setchild(childs, Elements.b1_9, -1, -1);
            treeNods[Elements.b1_8] = new Node(Elements.b1_8, 15, Elements.b2_8, childs, false);

            setchild(childs, Elements.b3_8, Elements.b1_8, -1);
            treeNods[Elements.b2_8] = new Node(Elements.b2_8, 14, Elements.b2_7, childs, false);

            setchild(childs, Elements.b4_8, -1, -1);
            treeNods[Elements.b3_8] = new Node(Elements.b3_8, 15, Elements.b2_8, childs, false);

            setchild(childs, Elements.b5_8, -1, -1);
            treeNods[Elements.b4_8] = new Node(Elements.b4_8, 16, Elements.b3_8, childs, false);

            setchild(childs, Elements.b6_8, -1, -1);
            treeNods[Elements.b5_8] = new Node(Elements.b5_8, 17, Elements.b4_8, childs, false);

            setchild(childs, -1, -1, -1);
            treeNods[Elements.b6_8] = new Node(Elements.b6_8, 18, Elements.b5_8, childs, false);

            setchild(childs, -1, -1, -1);
            treeNods[Elements.b7_8] = new Node(Elements.b7_8, 17, Elements.b7_7, childs, false);

            //************************sotoon 9***************************************
            setchild(childs, Elements.b1_10, -1, -1);
            treeNods[Elements.b1_9] = new Node(Elements.b1_9, 16, Elements.b1_8, childs, false);

            setchild(childs, Elements.b9_9, -1, -1);
            treeNods[Elements.b8_9] = new Node(Elements.b8_9, 25, Elements.b8_10, childs, false);

            setchild(childs, Elements.b10_9, -1, -1);
            treeNods[Elements.b9_9] = new Node(Elements.b9_9, 26, Elements.b8_9, childs, false);

            setchild(childs, -1, -1, -1);
            treeNods[Elements.b10_9] = new Node(Elements.b10_9, 27, Elements.b9_9, childs, false);
            //***********************sotoon 10*****************************************
            setchild(childs, Elements.b2_10, -1, -1);
            treeNods[Elements.b1_10] = new Node(Elements.b1_10, 17, Elements.b1_9, childs, false);

            setchild(childs, Elements.b3_10, -1, -1);
            treeNods[Elements.b2_10] = new Node(Elements.b2_10, 18, Elements.b1_10, childs, false);

            setchild(childs, Elements.b4_10, -1, -1);
            treeNods[Elements.b3_10] = new Node(Elements.b3_10, 19, Elements.b2_10, childs, false);

            setchild(childs, Elements.b5_10, -1, -1);
            treeNods[Elements.b4_10] = new Node(Elements.b4_10, 20, Elements.b3_10, childs, false);

            setchild(childs, Elements.b6_10, -1, -1);
            treeNods[Elements.b5_10] = new Node(Elements.b5_10, 21, Elements.b4_10, childs, false);

            setchild(childs, Elements.b7_10, -1, -1);
            treeNods[Elements.b6_10] = new Node(Elements.b6_10, 22, Elements.b5_10, childs, false);

            setchild(childs, Elements.b8_10, -1, -1);
            treeNods[Elements.b7_10] = new Node(Elements.b7_10, 23, Elements.b6_10, childs, false);

            setchild(childs, Elements.b9_10, Elements.b8_9, -1);
            treeNods[Elements.b8_10] = new Node(Elements.b8_10, 24, Elements.b7_10, childs, false);

            setchild(childs, Elements.b10_10, -1, -1);
            treeNods[Elements.b9_10] = new Node(Elements.b9_10, 25, Elements.b8_10, childs, false);

            setchild(childs, -1, -1, -1);
            treeNods[Elements.b10_10] = new Node(Elements.b10_10, 26, Elements.b9_10, childs, false);
        }
        //enumaration***************************************************************
        enum Elements 
        { 
            b1_1 = 0, b1_3, b1_4, b1_6, b1_8, b1_9, b1_10,/***/
            b2_1, b2_3, b2_4, b2_5, b2_6, b2_7, b2_8, b2_10,/***/ b3_1, b3_2, b3_4, b3_6, b3_8, b3_10,/***/
            b4_1, b4_2, b4_4, b4_5, b4_6, b4_8, b4_10,/***/ b5_2, b5_3, b5_4, b5_5, b5_8, b5_10,/***/
            b6_1, b6_2, b6_4, b6_5, b6_8, b6_10,/***/b7_1, b7_3, b7_4, b7_5, b7_7, b7_8, b7_10,/***/
            b8_2, b8_3, b8_4, b8_7, b8_9, b8_10,/***/b9_1, b9_2, b9_4, b9_5, b9_6, b9_7, b9_9, b9_10,/***/
            b10_2, b10_3, b10_4, b10_5, b10_7, b10_9, b10_10/***/
        };
        //my variables & functions**************************************************
        private Button goal;
        private void setGoal(Button b)
        {
            goal.BackColor = b.BackColor;
            goal.Text = "";
            b.BackColor = Color.DodgerBlue;
            b.Text = "G";
            goal = b;
        }
        //**************************************************************************
        private void changeEnable(bool p)
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (tableLayoutPanel1.Controls[i * 10 + j].BackColor != Color.Black)
                    {
                        tableLayoutPanel1.Controls[i * 10 + j].Enabled = p;
                    }
                }
        }
        //events********************************************************************
        private void Form1_Load(object sender, EventArgs e)
        {
            changeEnable(false);
        }
        //choose goal click**********************************************************
        private void button100_Click(object sender, EventArgs e)
        {
            changeEnable(true);
        }
        //***************************************************************************
        private void b2_1_Click(object sender, EventArgs e)
        {
            setGoal(b2_1);
        }

        private void b3_1_Click(object sender, EventArgs e)
        {
            setGoal(b3_1);
        }

        private void b4_1_Click(object sender, EventArgs e)
        {
            setGoal(b4_1);
        }

        private void b6_1_Click(object sender, EventArgs e)
        {
            setGoal(b6_1);
        }

        private void b7_1_Click(object sender, EventArgs e)
        {
            setGoal(b7_1);
        }

        private void b9_1_Click(object sender, EventArgs e)
        {
            setGoal(b9_1);
        }

        private void b3_2_Click(object sender, EventArgs e)
        {
            setGoal(b3_2);
        }

        private void b4_2_Click(object sender, EventArgs e)
        {
            setGoal(b4_2);
        }

        private void b5_2_Click(object sender, EventArgs e)
        {
            setGoal(b5_2);
        }

        private void b6_2_Click(object sender, EventArgs e)
        {
            setGoal(b6_2);
        }

        private void b8_2_Click(object sender, EventArgs e)
        {
            setGoal(b8_2);
        }

        private void b9_2_Click(object sender, EventArgs e)
        {
            setGoal(b9_2);
        }

        private void b10_2_Click(object sender, EventArgs e)
        {
            setGoal(b10_2);
        }

        private void b1_3_Click(object sender, EventArgs e)
        {
            setGoal(b1_3);
        }

        private void b2_3_Click(object sender, EventArgs e)
        {
            setGoal(b2_3);
        }

        private void b5_3_Click(object sender, EventArgs e)
        {
            setGoal(b5_3);
        }

        private void b7_3_Click(object sender, EventArgs e)
        {
            setGoal(b7_3);
        }

        private void b8_3_Click(object sender, EventArgs e)
        {
            setGoal(b8_3);
        }

        private void b10_3_Click(object sender, EventArgs e)
        {
            setGoal(b10_3);
        }

        private void b1_4_Click(object sender, EventArgs e)
        {
            setGoal(b1_4);
        }

        private void b2_4_Click(object sender, EventArgs e)
        {
            setGoal(b2_4);
        }

        private void b3_4_Click(object sender, EventArgs e)
        {
            setGoal(b3_4);
        }

        private void b4_4_Click(object sender, EventArgs e)
        {
            setGoal(b4_4);
        }

        private void b5_4_Click(object sender, EventArgs e)
        {
            setGoal(b5_4);
        }

        private void b6_4_Click(object sender, EventArgs e)
        {
            setGoal(b6_4);
        }

        private void b7_4_Click(object sender, EventArgs e)
        {
            setGoal(b7_4);
        }

        private void b8_4_Click(object sender, EventArgs e)
        {
            setGoal(b8_4);
        }

        private void b9_4_Click(object sender, EventArgs e)
        {
            setGoal(b9_4);
        }

        private void b10_4_Click(object sender, EventArgs e)
        {
            setGoal(b10_4);
        }

        private void b2_5_Click(object sender, EventArgs e)
        {
            setGoal(b2_5);
        }

        private void b4_5_Click(object sender, EventArgs e)
        {
            setGoal(b4_5);
        }

        private void b5_5_Click(object sender, EventArgs e)
        {
            setGoal(b5_5);
        }

        private void b6_5_Click(object sender, EventArgs e)
        {
            setGoal(b6_5);
        }

        private void b7_5_Click(object sender, EventArgs e)
        {
            setGoal(b7_5);
        }

        private void b9_5_Click(object sender, EventArgs e)
        {
            setGoal(b9_5);
        }

        private void b10_5_Click(object sender, EventArgs e)
        {
            setGoal(b10_5);
        }

        private void b1_6_Click(object sender, EventArgs e)
        {
            setGoal(b1_6);
        }

        private void b2_6_Click(object sender, EventArgs e)
        {
            setGoal(b2_6);
        }

        private void b3_6_Click(object sender, EventArgs e)
        {
            setGoal(b3_6);
        }

        private void b4_6_Click(object sender, EventArgs e)
        {
            setGoal(b4_6);
        }

        private void b9_6_Click(object sender, EventArgs e)
        {
            setGoal(b9_6);
        }

        private void b2_7_Click(object sender, EventArgs e)
        {
            setGoal(b2_7);
        }

        private void b7_7_Click(object sender, EventArgs e)
        {
            setGoal(b7_7);
        }

        private void b8_7_Click(object sender, EventArgs e)
        {
            setGoal(b8_7);
        }

        private void b9_7_Click(object sender, EventArgs e)
        {
            setGoal(b9_7);
        }

        private void b10_7_Click(object sender, EventArgs e)
        {
            setGoal(b10_7);
        }

        private void b1_8_Click(object sender, EventArgs e)
        {
            setGoal(b1_8);
        }

        private void b2_8_Click(object sender, EventArgs e)
        {
            setGoal(b2_8);
        }

        private void b3_8_Click(object sender, EventArgs e)
        {
            setGoal(b3_8);
        }

        private void b4_8_Click(object sender, EventArgs e)
        {
            setGoal(b4_8);
        }

        private void b5_8_Click(object sender, EventArgs e)
        {
            setGoal(b5_8);
        }

        private void b6_8_Click(object sender, EventArgs e)
        {
            setGoal(b6_8);
        }

        private void b7_8_Click(object sender, EventArgs e)
        {
            setGoal(b7_8);
        }

        private void b1_9_Click(object sender, EventArgs e)
        {
            setGoal(b1_9);
        }

        private void b8_9_Click(object sender, EventArgs e)
        {
            setGoal(b8_9);
        }

        private void b9_9_Click(object sender, EventArgs e)
        {
            setGoal(b9_9);
        }

        private void b10_9_Click(object sender, EventArgs e)
        {
            setGoal(b10_9);
        }

        private void b9_10_Click(object sender, EventArgs e)
        {
            setGoal(b9_10);
        }

        private void b8_10_Click(object sender, EventArgs e)
        {
            setGoal(b8_10);
        }

        private void b7_10_Click(object sender, EventArgs e)
        {
            setGoal(b7_10);
        }

        private void b6_10_Click(object sender, EventArgs e)
        {
            setGoal(b6_10);
        }

        private void b5_10_Click(object sender, EventArgs e)
        {
            setGoal(b5_10);
        }

        private void b4_10_Click(object sender, EventArgs e)
        {
            setGoal(b4_10);
        }

        private void b3_10_Click(object sender, EventArgs e)
        {
            setGoal(b3_10);
        }

        private void b2_10_Click(object sender, EventArgs e)
        {
            setGoal(b2_10);
        }

        private void b1_10_Click(object sender, EventArgs e)
        {
            setGoal(b1_10);
        }
//set goal***************************************************************
        private void button102_Click(object sender, EventArgs e)
        {
            changeEnable(false);
        }
//close******************************************************************
        private void button103_Click(object sender, EventArgs e)
        {
            Close();
        }
//************************************************************************
    }
}