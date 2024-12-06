using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _1_oef27r_tqfaiu_wtl2bi.Classes;

namespace _1_oef27r_tqfaiu_wtl2bi
{
    public partial class MainPage : Form
    {
        private Worker currentUser;
        private List<DateTime> appointments;

        public MainPage(Worker worker)
        {
            InitializeComponent();
            currentUser = worker;
            appointments = new List<DateTime>();

            // Például néhány időpontot előre beállítunk(itt nem jó a 2 sor, de még gondolkozok rajta!)
            appointments.Add(new DateTime(2024, 12, 6, 9, 0, 0));  // 2024.12.06. 09:00
            appointments.Add(new DateTime(2024, 12, 6, 14, 0, 0)); // 2024.12.06. 14:00

            DisplayAppointments();
        }

        // Időpontok megjelenítése a ListBox-ban
        private void DisplayAppointments()
        {
            AppointmentsListBox.Items.Clear();
            foreach (var appointment in appointments)
            {
            //(itt nem jó a 1 sor, de még gondolkozok rajta!)
                AppointmentsListBox.Items.Add(appointment.ToString("yyyy.MM.dd HH:mm"));
            }
        }

        // Időpont módosítása
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (AppointmentsListBox.SelectedItem != null)
            {
                // Kiválasztott régi időpont
                DateTime oldAppointment = DateTime.Parse(AppointmentsListBox.SelectedItem.ToString());

                // Új időpont a DateTimePicker-ből
                DateTime newAppointment = NewDateTimePicker.Value;

                // Ellenőrizzük, hogy a választott időpont nem a jövőben van-e
                if (newAppointment < DateTime.Now)
                {
                    MessageBox.Show("Az új időpontot legalább a mai dátumtól kezdődően választhatja ki!", 
                                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Ha érvénytelen az időpont, akkor visszatérünk és nem módosítunk semmit.
                }

                // Időpont módosítása a listában
                bool success = ModifyAppointment(oldAppointment, newAppointment);
                if (success)
                {
                    MessageBox.Show("Az időpont sikeresen módosítva!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayAppointments(); // Frissítjük a listát
                }
                else
                {
                    MessageBox.Show("Nem található a kiválasztott időpont.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Válasszon ki egy módosítandó időpontot.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Időpont módosítása a listában
        private bool ModifyAppointment(DateTime oldAppointment, DateTime newAppointment)
        {
            int index = appointments.IndexOf(oldAppointment);
            if (index != -1)
            {
                appointments[index] = newAppointment;
                return true; // sikeres módosítás
            }
            return false; // nem található az időpont
        }
    }
    }


