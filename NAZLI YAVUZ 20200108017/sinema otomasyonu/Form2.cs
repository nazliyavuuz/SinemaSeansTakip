﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_otomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Context dbbagla = new Context();
        bilet yenibilet = new bilet();
        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = button7.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text = button9.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = button1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
                var za = from i in dbbagla.satilankoltuklar
                         select i;
                dataGridView1.DataSource = za.ToList();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int idal = Convert.ToInt32(textBox4.Text);
            var idsorgula = dbbagla.satilankoltuklar.Find(idal);
            textBox1.Text = idsorgula.film;
            textBox3.Text = idsorgula.koltuk;
            textBox2.Text = idsorgula.saat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = button6.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = button8.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int idal = Convert.ToInt32(textBox4.Text);
            var idsorgula = dbbagla.satilankoltuklar.Find(idal);
            idsorgula.film = textBox1.Text;
            idsorgula.saat = textBox2.Text;
            idsorgula.koltuk = textBox3.Text;
            dbbagla.SaveChanges();
            var za = from i in dbbagla.satilankoltuklar
                     select i;
            dataGridView1.DataSource = za.ToList();
            if (textBox3.Text==button1.Text)
            {
                button1.BackColor = Color.Red;
                button1.ForeColor = Color.White;
            }
            if (textBox3.Text == button2.Text)
            {
                button2.BackColor = Color.Red;
                button2.ForeColor = Color.White;
            }
            if (textBox3.Text == button3.Text)
            {
                button3.BackColor = Color.Red;
                button3.ForeColor = Color.White;
            }
            if (textBox3.Text == button4.Text)
            {
                button4.BackColor = Color.Red;
                button4.ForeColor = Color.White;
            }
            if (textBox3.Text == button5.Text)
            {
                button5.BackColor = Color.Red;
                button5.ForeColor = Color.White;
            }
            if (textBox3.Text == button6.Text)
            {
                button6.BackColor = Color.Red;
                button6.ForeColor = Color.White;
            }
            if (textBox3.Text == button7.Text)
            {
                button7.BackColor = Color.Red;
                button7.ForeColor = Color.White;
            }
            if (textBox3.Text == button8.Text)
            {
                button8.BackColor = Color.Red;
                button8.ForeColor = Color.White;
            }
            if (textBox3.Text == button9.Text)
            {
                button9.BackColor = Color.Red;
                button9.ForeColor = Color.White;
            }
			if (textBox3.Text == button10.Text)
			{
				button10.BackColor = Color.Red;
				button10.ForeColor = Color.White;
			}
			if (textBox3.Text == button11.Text)
			{
				button11.BackColor = Color.Red;
				button11.ForeColor = Color.White;
			}
			if (textBox3.Text == button12.Text)
			{
				button12.BackColor = Color.Red;
				button12.ForeColor = Color.White;
			}
			if (textBox3.Text == button13.Text)
			{
				button13.BackColor = Color.Red;
				button13.ForeColor = Color.White;
			}
			if (textBox3.Text == button14.Text)
			{
				button14.BackColor = Color.Red;
				button14.ForeColor = Color.White;
			}
			if (textBox3.Text == button15.Text)
			{
				button15.BackColor = Color.Red;
				button15.ForeColor = Color.White;
			}
			if (textBox3.Text == button16.Text)
			{
				button16.BackColor = Color.Red;
				button16.ForeColor = Color.White;
			}
			if (textBox3.Text == button17.Text)
			{
				button17.BackColor = Color.Red;
				button17.ForeColor = Color.White;
			}
			if (textBox3.Text == button18.Text)
			{
				button18.BackColor = Color.Red;
				button18.ForeColor = Color.White;
			}
		}
    }
}

