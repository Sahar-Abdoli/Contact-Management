using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact
{
	public partial class ContactForm : Form
	{
		public ContactForm()
		{
			InitializeComponent();
		}

		private void AddContact(object sender, EventArgs e)
		{
			Models.DatabaseContext oDatabaseContext = null;
			try
			{
				oDatabaseContext = new Models.DatabaseContext();

				//Get Info Of Fields And Add These Into Database And Empty Fields 
				//Then Clear And Refresh Grid For Call New Info
				//***********************************************************************************
				Models.Person p1 = new Models.Person();
				p1.Id = Guid.NewGuid();
				p1.Name = NameTextbox.Text;
				p1.Family = FamilyTextbox.Text;
				p1.Email = EmailTextbox.Text;
				p1.Phone = PhoneTextbox.Text;
				if (p1.Name == string.Empty)
				{
					MessageBox.Show("Name Can not Be Empty");
				}
				else 
				{
					oDatabaseContext.People.Add(p1);
					oDatabaseContext.SaveChanges();

					//Clear Grid For Call New Info
					dataGridView.Rows.Clear();
					dataGridView.Refresh();
					NameTextbox.Text = string.Empty;
					FamilyTextbox.Text = string.Empty;
					PhoneTextbox.Text = string.Empty;
					EmailTextbox.Text = string.Empty;
					var contacts = oDatabaseContext.People.Where(current => current.Id != null).OrderBy(c => c.Name).ToList();
					for (int i = 0; i < contacts.Count(); i++)
					{
						//Add Row In Grid 
						this.dataGridView.Rows.Add(contacts[i].Name, contacts[i].Family, contacts[i].Phone, contacts[i].Email, contacts[i].Id);
					}

				}
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if (oDatabaseContext!=null)
				{
					oDatabaseContext.Dispose();
					oDatabaseContext = null;
				}
			}
		}

		private void EditContact(object sender, EventArgs e)
		{
			Models.DatabaseContext oDatabaseContext = null;
			try
			{
				oDatabaseContext = new Models.DatabaseContext();

				//Find Row of Selected Cell and Find Guid Of This Row (Guid Column is Number 4 Column. That is Hidden)
				//By These info We Can Find Record in Database And Call its Info into Our Fields
				//Then After Edit Info Refresh Grid And Empty Fields
				//***********************************************************************************
				int row = dataGridView.CurrentCell.RowIndex;
				string cellIndex = dataGridView.Rows[row].Cells[4].Value.ToString();
				Guid guid = new Guid(cellIndex);
				Models.Person p1 = oDatabaseContext.People.Where(current => current.Id == guid).FirstOrDefault();
				p1.Name = NameTextbox.Text;
				p1.Family = FamilyTextbox.Text;
				p1.Email = EmailTextbox.Text;
				p1.Phone = PhoneTextbox.Text;
				if (p1.Name == string.Empty)
				{
					MessageBox.Show("Name Can not Be Empty");
				}
				else
				{
					oDatabaseContext.SaveChanges();

					//Clear Grid For Call New Info
					dataGridView.Rows.Clear();
					dataGridView.Refresh();
					NameTextbox.Text = string.Empty;
					FamilyTextbox.Text = string.Empty;
					PhoneTextbox.Text = string.Empty;
					EmailTextbox.Text = string.Empty;
					var contacts = oDatabaseContext.People.Where(current => current.Id != null).OrderBy(c => c.Name).ToList();
					for (int i = 0; i < contacts.Count(); i++)
					{
						//Add Row In Grid 
						this.dataGridView.Rows.Add(contacts[i].Name, contacts[i].Family, contacts[i].Phone, contacts[i].Email, contacts[i].Id);
					}
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if (oDatabaseContext != null)
				{
					oDatabaseContext.Dispose();
					oDatabaseContext = null;
				}
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
			Models.DatabaseContext oDatabaseContext = null;
			try
			{
				oDatabaseContext = new Models.DatabaseContext();

				//Find Row of Selected Cell and Find Guid Of This Row (Guid Column is Number 4 Column. That is Hidden)
				//By these info We Can Find Record in Database And Call its Info into Our Fields
				//***********************************************************************************
				int index = e.RowIndex;
				string cellIndex = dataGridView.Rows[index].Cells[4].Value.ToString();
				Guid guid = new Guid(cellIndex);
				var contacts = oDatabaseContext.People.Where(current => current.Id==guid).FirstOrDefault();
				NameTextbox.Text = contacts.Name;
				FamilyTextbox.Text = contacts.Family;
				PhoneTextbox.Text = contacts.Phone;
				EmailTextbox.Text = contacts.Email;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if (oDatabaseContext != null)
				{
					oDatabaseContext.Dispose();
					oDatabaseContext = null;
				}
			}
		}

		private void ContactForm_Load(object sender, EventArgs e)
		{
			Models.DatabaseContext oDatabaseContext = null;
			try
			{
				oDatabaseContext = new Models.DatabaseContext();

				//Load All Contacts in Grid
				//***********************************************************************************
				var contacts =  oDatabaseContext.People.Where(current => current.Id != null).OrderBy(c => c.Name).ToList();
				for (int i = 0; i < contacts.Count(); i++)
				{
					//Add Row In Grid 
					this.dataGridView.Rows.Add(contacts[i].Name, contacts[i].Family, contacts[i].Phone, contacts[i].Email, contacts[i].Id);
				}

			}
			catch {

			}
		}

		private void DeleteButton(object sender, EventArgs e)
		{
			Models.DatabaseContext oDatabaseContext = null;
			try
			{
				oDatabaseContext = new Models.DatabaseContext();

				//Find Row of Selected Cell and Find Guid Of This Row (Guid Column is Number 4 Column. That is Hidden)
				//By These info We Can Find Record in Database And Delete Its Info And Record In Database
				//Then After Delete Info Refresh Grid And Empty Fields
				//***********************************************************************************
				int row = dataGridView.CurrentCell.RowIndex;
				string cellIndex = dataGridView.Rows[row].Cells[4].Value.ToString();
				Guid guid = new Guid(cellIndex);
				var person = oDatabaseContext.People.Where(current => current.Id == guid).FirstOrDefault();
				Models.Person p = new Models.Person();
				p =(Models.Person) person;
				oDatabaseContext.People.Remove(p);
				oDatabaseContext.SaveChanges();

				//Clear Grid For Call New Info
				dataGridView.Rows.Clear();
				dataGridView.Refresh();
				NameTextbox.Text = string.Empty;
				FamilyTextbox.Text = string.Empty;
				PhoneTextbox.Text = string.Empty;
				EmailTextbox.Text = string.Empty;
				var contacts = oDatabaseContext.People.Where(current => current.Id != null).OrderBy(c => c.Name).ToList();
				for (int i = 0; i < contacts.Count(); i++)
				{
					//Add Row In Grid 
					this.dataGridView.Rows.Add(contacts[i].Name, contacts[i].Family, contacts[i].Phone, contacts[i].Email, contacts[i].Id);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				
			}
			finally
			{
				if (oDatabaseContext != null)
				{
					oDatabaseContext.Dispose();
					oDatabaseContext = null;
				}
			}
		}
	}
}
