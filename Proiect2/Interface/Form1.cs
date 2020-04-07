using Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        int globalIdItem;

        public Form1()
        {
            InitializeComponent();

            datecreatedPicker.Format = DateTimePickerFormat.Custom;
            datecreatedPicker.CustomFormat = "yyyy";
            datecreatedPicker.ShowUpDown = true;
            dateFilter.Format = DateTimePickerFormat.Custom;
            dateFilter.CustomFormat = "yyyy";
            dateFilter.ShowUpDown = true;

            titleLabel.Font = new Font("Serif", 24, FontStyle.Bold);

            UpdateFilterPersonsList();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog result = new OpenFileDialog();
            result.Filter = "Image Files | *.jpg; *.jpeg; *.jpe; *.jfif; *.png ;*.PNG;| Video files |*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            if (result.ShowDialog() == DialogResult.OK)
            {
                string file = result.FileName;
                filenameLabel.Text = file;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (filenameLabel.Text == "")
            {
                MessageBox.Show("Choose a photo/video !", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                if (saveButton.Text == "Save")
                    AddItem();
                else
                    UpdateItem(globalIdItem);
            }

        }

        private void AddItem()
        {
            var extension = filenameLabel.Text.Split('.')[1];
            Item newItem = new Item()
            {
                Type = getTypeForFile(extension),
                Description = descriptionBox.Text,
                Path = filenameLabel.Text,
                Event = eventBox.Text,
                Landscape = landscapeBox.Text,
                Country = countryBox.Text,
                Date_created = datecreatedPicker.Value
            };

            ItemPersonClient client = new ItemPersonClient();
            var id_newItem = client.AddItem(newItem);
       
            var persons = personsLabel.Text.Split('\n');
            foreach (var person in persons)
            {
                Person newPerson = new Person()
                {
                    Name = person,
                    Id_item = id_newItem,
                    Gender = "male"
                };
                client.AddPerson(newPerson);
            }

            messageAdded.ForeColor = Color.Green;
            UpdateTable();
            UpdateFilterPersonsList();
            Clear();
        }

        private string getTypeForFile(string extension)
        {
            string[] photoExtensions = new string[] { "jpg", "jpeg", "jpe", "jfif", "png", "PNG" };
            string[] videoExtensions = new string[] { "wav","aac","wma","wmv","avi", "mpg","mpeg", 
            "mp4","mov","m4a", "WAV","AAC","WMA","WMV","AVI"};

            if (photoExtensions.Contains(extension))
                return "Photo";
            return "Video";
        }

        private void UpdateItem(int id)
        {
            Item newItem = new Item()
            {
                Type = "photo",
                Description = descriptionBox.Text,
                Path = filenameLabel.Text,
                Event = eventBox.Text,
                Landscape = landscapeBox.Text,
                Country = countryBox.Text,
                Date_created = datecreatedPicker.Value
            };

            ItemPersonClient client = new ItemPersonClient();

            var message = client.UpdateItem(id, newItem);

            var persons = personsLabel.Text.Split('\n');
            var numberPersonsItems = client.GetPersonsForItem(id).Count();
            var deletedPerson = client.GetPersonsForItem(id);
            var numberPersons = findLength(persons);

            if (numberPersons < numberPersonsItems)
            {
                foreach (var person in persons)
                {
                    deletedPerson = deletedPerson.Where(p => p.Name != person).ToArray();
                }

                foreach (var person in deletedPerson.ToArray())
                {
                    client.RemovePerson(person);
                }
            }
            else
            {
                foreach (var person in persons)
                {
                    if (person != "")
                    {
                        if (client.VerifyIfPersonExist(id, person) == 0)
                        {
                            Person newPerson = new Person()
                            {
                                Name = person,
                                Id_item = id,
                                Gender = "male"
                            };
                            client.AddPerson(newPerson);
                        }
                    }
                }
            }

            if (message.Contains("Try Again"))
                messageAdded.ForeColor = Color.Red;
            else
            {
                messageAdded.ForeColor = Color.Green;
                messageAdded.Text = message;
                UpdateTable();
                UpdateFilterPersonsList();
                Clear();
            }

        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            if (addPersonText.Text == "")
            {
                MessageBox.Show("This field should not be empty", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                personsLabel.Text += (personsLabel.Text == "" ? "" : "\n") + addPersonText.Text;
                addPersonText.Text = "";
            }

        }

        private void deletePersonButton_Click(object sender, EventArgs e)
        {
            if (addPersonText.Text == "")
            {
                MessageBox.Show("Person name should not be empty", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                int index = personsLabel.Text.IndexOf(addPersonText.Text);
                personsLabel.Text = personsLabel.Text.Remove(index, addPersonText.Text.Length);
                addPersonText.Text = "";
            }
        }

        private int findLength(string[] array)
        {
            int nr = 0;
            foreach (var item in array)
            {
                if (item != "")
                    nr++;
            }
            return nr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTable();
            personsLabel.Text = "";
            picture.Visible = false;
            video.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void itemsTable_DoubleClick(object sender, EventArgs e)
        {
            picture.Visible = false;
            video.Visible = false;
            if (itemsTable.CurrentRow.Index != -1)
            {
                ItemPersonClient client = new ItemPersonClient();
                var idItem = Convert.ToInt32(itemsTable.CurrentRow.Cells["Id_item"].Value);
                var item = client.GetById(idItem);
                globalIdItem = idItem;
                descriptionBox.Text = item.Description;
                filenameLabel.Text = item.Path;
                eventBox.Text = item.Event;
                landscapeBox.Text = item.Landscape;
                countryBox.Text = item.Country;
                datecreatedPicker.Value = item.Date_created;

                if(item.Type == "Photo")
                {
                    picture.Visible = true;
                    picture.ImageLocation = item.Path;
                }
                else
                {
                    video.Visible = true;
                    video.URL = item.Path;
                }

               
                var result = client.GetPersonsForItem(idItem);
                personsLabel.Text = "";
                foreach (var i in result)
                {
                    personsLabel.Text += (personsLabel.Text == "" ? "" : "\n") + i.Name;

                }
                addPersonText.Text = "";
                saveButton.Text = "Update";
                deleteButton.Enabled = true;
                deletePersonButton.Enabled = true;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want this?", "Delete item", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ItemPersonClient client = new ItemPersonClient();
                client.RemoveItem(globalIdItem);
                UpdateTable();
                UpdateFilterPersonsList();
                Clear();
            }
        }

        private void UpdateFilterPersonsList()
        {
            for (int n = filterPersons.Items.Count - 1; n >= 0; --n)
            {
                filterPersons.Items.RemoveAt(n);

            }
            ItemPersonClient client = new ItemPersonClient();
            var persons = client.GetNamePersons();
            foreach (var person in persons)
            {
                if (person != "")
                    filterPersons.Items.Add(person);
            }

        }
        private void UpdateTable()
        {
            itemsTable.AutoGenerateColumns = false;
            ItemPersonClient client = new ItemPersonClient();
            var items = client.GetAllItems();
            itemsTable.DataSource = items;

            deleteButton.Enabled = false;
            deletePersonButton.Enabled = false;
        }

        private void Clear()
        {
            descriptionBox.Text = "";
            filenameLabel.Text = "";
            eventBox.Text = "";
            landscapeBox.Text = "";
            countryBox.Text = "";
            personsLabel.Text = "";
            addPersonText.Text = "";
            saveButton.Text = "Save";
            deleteButton.Enabled = false;
            messageAdded.Text = "";
            picture.Visible = false;
            video.Visible = false;
        }

        private void ResetFilter()
        {
            photoCheckbox.Checked = false;
            videoCheckbox.Checked = false;
            noRadio.Checked = false;
            yesRadio.Checked = false;
            eventFilter.Text = "";
            landscapeFilter.Text = "";
            countryFilter.Text = "";
            dateFilter.Value = DateTime.Now;

        }
        private void filterButton_Click(object sender, EventArgs e)
        {

            if (yesRadio.Checked == false && noRadio.Checked == false)
            {
                MessageBox.Show("Choose yes/no for year", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                string Type = "";
                if (photoCheckbox.Checked == true)
                    Type = "Photo";
                else
                {
                    if (videoCheckbox.Checked == true)
                        Type = "Video";
                }

                var selectedItems = new List<string>();
                foreach (var item in filterPersons.SelectedItems)
                {
                    selectedItems.Add(item.ToString());
                }

                ItemPersonClient client = new ItemPersonClient();

                if (noRadio.Checked == true)
                {
                    FilterModel filter = new FilterModel()
                    {
                        Type = Type,
                        Event = eventFilter.Text,
                        Landscape = landscapeFilter.Text,
                        Country = countryFilter.Text,
                        Persons = selectedItems.ToArray()
                    };
                    itemsTable.AutoGenerateColumns = false;
                    var result = client.FilterItems(filter);
                    itemsTable.DataSource = result.ToList();
                    ResetFilter();
                }
                else
                {
                    FilterModel filter = new FilterModel()
                    {
                        Type = Type,
                        Event = eventFilter.Text,
                        Landscape = landscapeFilter.Text,
                        Country = countryFilter.Text,
                        Year = Int32.Parse(DateTime.Parse(dateFilter.Value.ToString()).Year.ToString()),
                        Persons = selectedItems.ToArray()
                    };

                    itemsTable.AutoGenerateColumns = false;
                    var result = client.FilterItems(filter);
                    itemsTable.DataSource = result.ToList();
                    ResetFilter();
                }

            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetFilter();
            UpdateTable();
            Clear();
        }
    }
}
