using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aviate.CRUD;
using Aviate.DBContext;
using Aviate.Models;
using FMS.SubUtills;
using Microsoft.EntityFrameworkCore;
namespace FMS.AdminPanels
{
     public partial class ad_am : Form
     {

          private string aircraft_Name;
          private string aircraft_Type;
          private string business_Seats;
          private string economy_Seats;
          private string business_Price;
          private string economy_Price;
          private bool usable;
          private string Model;

          public ad_am()
          {
               InitializeComponent();
               
          }


          private async Task retriveInActiveAircraft()
          {
               // finding the aircraft that have usable value as false
               AviateContext aviateContext = new AviateContext();
               List<Aircraft>? aircraft = await (from f in aviateContext.Aircrafts where f.Usable == false select f).ToListAsync();
               if (aircraft == null)
               {
                    return;
               }

               // setting the listbox items to all aircrafts model

               AircraftList.Items.Clear();

               foreach (var item in aircraft)
               {
                    AircraftList.Items.Add(item.AircraftName);
               }
          }


          private async Task viewFleet(string? filterModel)
          {
               // reloading the data from the database into the data grid view

               // creating a new instance of the AviateContext class
               using AviateContext aviateContext = new();

               // getting the data from the database
               List<Aircraft>? data;
               if (filterModel == null)
                     data = (await (from f in aviateContext.Aircrafts select f).ToListAsync());
               else
                    data = (await (from f in aviateContext.Aircrafts where f.AircraftName == filterModel select f).ToListAsync());
               // setting the data source of the data grid view

               dataGridView1.DataSource = data;


          }

          private void button2_Click(object sender, EventArgs e)
          {
               adminPanel adminPanel = new adminPanel();
               adminPanel.Show();
               this.Hide();
          }

          

          private async void button5_Click(object sender, EventArgs e)
          {
               // add to fleet

               // creating a new instance of the AviateContext class
               using AviateContext aviateContext = new();

               AircraftCRUD aircraftCRUD = new AircraftCRUD();

               int aircraftID = aircraftCRUD.assignID() + 1;

               await aviateContext.Aircrafts.AddAsync(new Aircraft
               {
                    AircraftID = aircraftID,
                    AircraftName = aircraft_Name,
                    AircraftType = aircraft_Type,
                    BusinessSeats = business_Seats,
                    EconomySeats = economy_Seats,
                    TotalSeats = Convert.ToString(int.Parse(business_Seats) + int.Parse(economy_Seats)),
                    BusinessPrice = business_Price,
                    EconomyPrice = economy_Price,
                    Usable = usable
               });

               await aviateContext.SaveChangesAsync();

               // showing the toast message

               ToastMessage toastMessage = new ToastMessage("success", "Aircraft added successfully");
               toastMessage.Show();


               // resetting the fields
               add_am_model.Text = "";
               add_am_type.Text = "";
               businessSeats.Text = "";
               add_cr_ecmSeats.Text = "";
               businessPrice.Text = "";
               ecmPrice.Text = "";



          }

          

          private async void reload_Click(object sender, EventArgs e)
          {
               await viewFleet(null);

               await retriveInActiveAircraft();


          }

          private void add_cr_capacity_TextChanged(object sender, EventArgs e)
          {
               economy_Seats = (add_cr_ecmSeats.Text);
          }

          private void add_am_model_TextChanged(object sender, EventArgs e)
          {
               aircraft_Name = add_am_model.Text;
          }

          private void add_ar_phonenumber_TextChanged(object sender, EventArgs e)
          {
               if (add_ar_maintenace.Text == "Yes")
               {
                    // if the aircraft is in maintenance then not usable
                    usable = false;

               }
               else if (add_ar_maintenace.Text == "No")
               {
                    usable = true;
               }
          }

          private void businessSeats_TextChanged(object sender, EventArgs e)
          {
               business_Seats = (businessSeats.Text);
          }

          private void ecmPrice_TextChanged(object sender, EventArgs e)
          {
               economy_Price = (ecmPrice.Text);
          }

          private void businessPrice_TextChanged(object sender, EventArgs e)
          {
               business_Price = (businessPrice.Text);
          }

          private void add_am_type_TextChanged(object sender, EventArgs e)
          {
               aircraft_Type = add_am_type.Text;
          }

          private void remModel_TextChanged(object sender, EventArgs e)
          {
               Model = remModel.Text;
          }

          private async void deactivate_Click(object sender, EventArgs e)
          {
               // marking the user as inactive
               if (Model == null)
               {
                    MessageBox.Show("Please enter the model to deactivate/Active");
               }
               else
               {
                    AviateContext aviateContext = new AviateContext();


                    // getting the aircraft with the given model
                    Aircraft? aircraft = (await (from f in aviateContext.Aircrafts where f.AircraftName == Model select f).ToListAsync()).FirstOrDefault();

                    if (aircraft == null)
                    {
                         MessageBox.Show("Aircraft not found");
                         return;
                    }

                    // toggling the usable value
                    aircraft.Usable = !aircraft.Usable;

                    aviateContext.Aircrafts.Update(aircraft);
                    aviateContext.SaveChanges();

                    // showing the toast message
                    ToastMessage toastMessage = new ToastMessage("success", "Aircraft status updated successfully");
                    toastMessage.Show();



               }
          }

          private void dreamTextBox14_TextChanged(object sender, EventArgs e)
          {
               aircraft_Name = dreamTextBox14.Text;
          }

          private void dreamTextBox13_TextChanged(object sender, EventArgs e)
          {
               if (dreamTextBox13.Text == "Yes")
               {
                    // if the aircraft is in maintenance then not usable
                    usable = false;

               }
               else if (dreamTextBox13.Text == "No")
               {
                    usable = true;
               }
          }

          private void dreamTextBox12_TextChanged(object sender, EventArgs e)
          {
               economy_Seats = dreamTextBox12.Text;
          }

          private void dreamTextBox10_TextChanged(object sender, EventArgs e)
          {
               business_Seats = dreamTextBox10.Text;
          }

          private void dreamTextBox9_TextChanged(object sender, EventArgs e)
          {
               economy_Price = dreamTextBox9.Text;
          }

          private void dreamTextBox8_TextChanged(object sender, EventArgs e)
          {
               business_Price = dreamTextBox8.Text;
          }

          private void dreamTextBox11_TextChanged(object sender, EventArgs e)
          {
               aircraft_Type = dreamTextBox11.Text;
          }

          private async void edit_am_changes_Click(object sender, EventArgs e)
          {

               // finding the aircraft with the given model
               AviateContext aviateContext = new AviateContext();

               Aircraft? aircraft = (await (from f in aviateContext.Aircrafts where f.AircraftName == aircraft_Name select f).ToListAsync()).FirstOrDefault();

               if (aircraft == null)
               {
                    MessageBox.Show("Aircraft not found");
                    return;
               }

               // updating the aircraft

               aircraft.AircraftType = aircraft_Type;
               aircraft.BusinessSeats = business_Seats;
               aircraft.EconomySeats = economy_Seats;
               aircraft.TotalSeats = business_Seats + economy_Seats;
               aircraft.BusinessPrice = business_Price;
               aircraft.EconomyPrice = economy_Price;
               aircraft.Usable = usable;

               aviateContext.Aircrafts.Update(aircraft);
               aviateContext.SaveChanges();


               // showing the toast message
               ToastMessage toastMessage = new ToastMessage("success", "Aircraft updated successfully");
               toastMessage.Show();


          }

          
     }
}
