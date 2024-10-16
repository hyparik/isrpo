using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string login, password;
        RoundButton roundButton = new RoundButton();
        RoundButton roundButton2 = new RoundButton();
        RoundButton roundButton3 = new RoundButton();
        RoundButton roundButton4 = new RoundButton();
        RoundButton roundButton5 = new RoundButton();
        List<Contact> contacts = new List<Contact>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Font fonts = new Font("Microsoft Sans Serif", 9);
            
            roundButton.Text = "Профиль";
            roundButton.Font = fonts;
            roundButton.Size = new Size(130, 50);
            roundButton.Location = new Point(60, 40);
            roundButton.BackColor = Color.Moccasin;
            roundButton.Cursor = Cursors.Hand;
            roundButton.MouseClick += onClick1;
            this.Controls.Add(roundButton);

            roundButton2.Text = "Задачи";
            roundButton2.Font = fonts;
            roundButton2.Size = new Size(130, 50);
            roundButton2.Location = new Point(60, 100);
            roundButton2.BackColor = Color.Moccasin;
            roundButton2.Cursor = Cursors.Hand;
            roundButton2.MouseClick += onClick2;
            this.Controls.Add(roundButton2);

            roundButton3.Text = "Контакты/компании";
            roundButton3.Font = fonts;
            roundButton3.Size = new Size(130, 50);
            roundButton3.Location = new Point(60, 160);
            roundButton3.BackColor = Color.Moccasin;
            roundButton3.Cursor = Cursors.Hand;
            roundButton3.MouseClick += onClick3;
            this.Controls.Add(roundButton3);

            roundButton4.Text = "Настройка/цвет";
            roundButton4.Font = fonts;
            roundButton4.Size = new Size(130, 50);
            roundButton4.Location = new Point(60, 220);
            roundButton4.BackColor = Color.Moccasin;
            roundButton4.Cursor = Cursors.Hand;
            roundButton4.MouseClick += onClick4;
            this.Controls.Add(roundButton4);

            roundButton5.Text = "...";
            roundButton5.Font = fonts;
            roundButton5.Size = new Size(130, 50);
            roundButton5.Location = new Point(60, 280);
            roundButton5.BackColor = Color.Moccasin;
            roundButton5.Cursor = Cursors.Hand;
            roundButton5.MouseClick += onClick5;
            this.Controls.Add(roundButton5);

        }

        private void onClick5(object sender, MouseEventArgs e)
        {
            panel5.Visible = !panel5.Visible;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void onClick4(object sender, MouseEventArgs e)
        {
            panel4.Visible = !panel4.Visible;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void onClick3(object sender, MouseEventArgs e)
        {
            panel6.Visible = !panel6.Visible;
            if(textBox10.Text != "")
                panel7.Visible = !panel7.Visible;
            if (textBox15.Text != "")
                panel8.Visible = !panel8.Visible;
            if (textBox20.Text != "")
                panel9.Visible = !panel9.Visible;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void onClick2(object sender, MouseEventArgs e)
        {
            panel2.Visible = !panel2.Visible;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void onClick1(object sender, MouseEventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.GreenYellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Plum;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.SlateBlue;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1 != null && textBox2 != null && textBox3 != null && textBox4 != null && textBox5 != null)
            {
                Contact contact = new Contact(textBox2.Text, textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                contacts.Add(contact);
                if (textBox10.Text == "")
                {
                    textBox10.Text = contact.name;
                    textBox9.Text = contact.surname;
                    textBox8.Text = contact.login;
                    textBox7.Text = contact.password;
                    textBox6.Text = contact.email;
                    panel7.Visible = true;
                }
                else if (textBox15.Text == "")
                {
                    textBox15.Text = contact.name;
                    textBox14.Text = contact.surname;
                    textBox13.Text = contact.login;
                    textBox12.Text = contact.password;
                    textBox11.Text = contact.email;
                    panel8.Visible = true;
                }
                else
                {
                    textBox20.Text = contact.name;
                    textBox19.Text = contact.surname;
                    textBox18.Text = contact.login;
                    textBox17.Text = contact.password;
                    textBox16.Text = contact.email;
                    panel9.Visible = true;
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
        }
    }
}
