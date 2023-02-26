namespace RheolauArmsManagmentSystemPrototype
{
    internal class stockMenu
    {
        static int defaultPadding = 5;
        public void ViewStock(Panel View_panel)
        {

            // - variables --------------------------------------------------------------------------------------------------------------------
            Settings settings = new Settings(); //create nenw instance of login settings
            Cryptography cryptography = new Cryptography();

            Size panelSize = new Size(View_panel.Size.Width - defaultPadding * 6, 72);
            Size textSize = new Size(250, 24);

            ItemInfo[] itemInfo = getItemInfo();
            StockInfo[] stockInfo = GetStockInfo();

            Panel[] panels = new Panel[stockInfo.Length];
            Label[] StockID_Label = new Label[stockInfo.Length];
            Label[] ItemID_Label = new Label[stockInfo.Length];
            Label[] Quantity_Label = new Label[stockInfo.Length];

            // - customer information -
            Label[] ItemDescription_Label = new Label[stockInfo.Length];
            Label[] ItemLocation_Label = new Label[stockInfo.Length];

            // --------------------------------------------------------------------------------------------------------------------------------

            // - setup controls ---------------------------------------------------------------------------------------------------------------

            RemoveControlls(View_panel);

            for (int i = 0; i < stockInfo.Length; i++)
            {

                //setup controlls

                // - Panel -
                panels[i] = new Panel();
                panels[i].Parent = View_panel;
                panels[i].Location = new Point(defaultPadding, defaultPadding + panelSize.Height * i + defaultPadding * i);
                panels[i].Size = panelSize;
                panels[i].BackColor = Color.FromArgb(66, 96, 138);

                // - Booking ID -
                StockID_Label[i] = new Label();
                StockID_Label[i].Parent = panels[i];
                StockID_Label[i].Text = "Stock ID: " + stockInfo[i].StockID.ToString();
                StockID_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                StockID_Label[i].Location = new Point(defaultPadding, defaultPadding);
                StockID_Label[i].ForeColor = Color.White;
                

                // - Customer ID -
                ItemID_Label[i] = new Label();
                ItemID_Label[i].Parent = panels[i];
                ItemID_Label[i].Text = "Item ID: " + stockInfo[i].ItemID.ToString();
                ItemID_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                ItemID_Label[i].Size = textSize;
                ItemID_Label[i].Location = new Point(defaultPadding * 2 + 200 + StockID_Label[i].Size.Width, defaultPadding);
                ItemID_Label[i].ForeColor = Color.White;

                // - Number Of People -
                Quantity_Label[i] = new Label();
                Quantity_Label[i].Parent = panels[i];
                Quantity_Label[i].Text = "Stock Quantity: " + stockInfo[i].Quantity.ToString();
                Quantity_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                Quantity_Label[i].Size = textSize;
                Quantity_Label[i].Location = new Point(defaultPadding, StockID_Label[i].Location.Y + StockID_Label[i].Size.Height);
                Quantity_Label[i].ForeColor = Color.White;

                // - customer surname -
                ItemDescription_Label[i] = new Label(); // new label
                ItemDescription_Label[i].Parent = panels[i];
                ItemDescription_Label[i].Text = "Description: " + itemInfo[stockInfo[i].ItemID].Description; // 
                ItemDescription_Label[i].Size = textSize;
                ItemDescription_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                ItemDescription_Label[i].Location = new Point(defaultPadding * 2 + 200 + StockID_Label[i].Size.Width, StockID_Label[i].Location.Y + StockID_Label[i].Size.Height);
                ItemDescription_Label[i].Size = textSize;
                ItemDescription_Label[i].ForeColor = Color.White;

                // - customer ForeName -
                ItemLocation_Label[i] = new Label(); // new label
                ItemLocation_Label[i].Parent = panels[i];
                ItemLocation_Label[i].Text = "Location: " + itemInfo[stockInfo[i].ItemID].location; // 
                ItemLocation_Label[i].Size = textSize;
                ItemLocation_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                ItemLocation_Label[i].Location = new Point(defaultPadding * 2 + 200 + StockID_Label[i].Size.Width, ItemDescription_Label[i].Location.Y + ItemDescription_Label[i].Size.Height);
                ItemLocation_Label[i].Size = textSize;
                ItemLocation_Label[i].ForeColor = Color.White;

                // --------------------------------------------------------------------------------------------------------------------------------

            }
        }
        public void EditStock(Panel View_panel)
        {

            // - variables --------------------------------------------------------------------------------------------------------------------
            Settings settings = new Settings(); //create nenw instance of login settings
            Cryptography cryptography = new Cryptography();

            Size panelSize = new Size(View_panel.Size.Width - defaultPadding * 6, 72);
            Size textSize = new Size(250, 24);

            ItemInfo[] itemInfo = getItemInfo();
            StockInfo[] stockInfo = GetStockInfo();

            Panel[] panels = new Panel[stockInfo.Length];
            TextBox[] StockID_TextBox = new TextBox[stockInfo.Length];
            TextBox[] ItemID_TextBox = new TextBox[stockInfo.Length];
            TextBox[] Quantity_TextBox = new TextBox[stockInfo.Length];

            // - customer information -
            TextBox[] ItemDescription_TextBox = new TextBox[stockInfo.Length];
            TextBox[] ItemLocation_TextBox = new TextBox[stockInfo.Length];

            Button[] editEntry_button = new Button[stockInfo.Length];
            Button[] deleteEntry_button = new Button[stockInfo.Length];

            // --------------------------------------------------------------------------------------------------------------------------------

            // - setup controls ---------------------------------------------------------------------------------------------------------------

            RemoveControlls(View_panel);

            for (int i = 0; i < stockInfo.Length; i++)
            {

                //setup controlls

                // - Panel -
                panels[i] = new Panel();
                panels[i].Parent = View_panel;
                panels[i].Location = new Point(defaultPadding, defaultPadding + panelSize.Height * i + defaultPadding * i);
                panels[i].Size = panelSize;
                panels[i].BackColor = Color.FromArgb(66, 96, 138);

                // - Booking ID -
                StockID_TextBox[i] = new TextBox();
                StockID_TextBox[i].Parent = panels[i];
                StockID_TextBox[i].Enabled = false;
                StockID_TextBox[i].Text = stockInfo[i].StockID.ToString();
                StockID_TextBox[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                StockID_TextBox[i].Location = new Point(defaultPadding, defaultPadding);
                StockID_TextBox[i].ForeColor = Color.Black;

                // - Customer ID -
                ItemID_TextBox[i] = new TextBox();
                ItemID_TextBox[i].Parent = panels[i];
                ItemID_TextBox[i].Enabled = false;
                ItemID_TextBox[i].Text = stockInfo[i].ItemID.ToString();
                ItemID_TextBox[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                ItemID_TextBox[i].Size = textSize;
                ItemID_TextBox[i].Location = new Point(defaultPadding * 2 + 200 + StockID_TextBox[i].Size.Width, defaultPadding);
                ItemID_TextBox[i].ForeColor = Color.Black;

                // - Number Of People -
                Quantity_TextBox[i] = new TextBox();
                Quantity_TextBox[i].Parent = panels[i];
                Quantity_TextBox[i].Text = stockInfo[i].Quantity.ToString();
                Quantity_TextBox[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                Quantity_TextBox[i].Size = textSize;
                Quantity_TextBox[i].Location = new Point(defaultPadding, StockID_TextBox[i].Location.Y + StockID_TextBox[i].Size.Height);
                Quantity_TextBox[i].ForeColor = Color.Black;

                // - customer surname -
                ItemDescription_TextBox[i] = new TextBox(); // new label
                ItemDescription_TextBox[i].Parent = panels[i];
                ItemDescription_TextBox[i].Text = itemInfo[stockInfo[i].ItemID].Description; // 
                ItemDescription_TextBox[i].Size = textSize;
                ItemDescription_TextBox[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                ItemDescription_TextBox[i].Location = new Point(defaultPadding * 2 + 200 + StockID_TextBox[i].Size.Width, StockID_TextBox[i].Location.Y + StockID_TextBox[i].Size.Height);
                ItemDescription_TextBox[i].Size = textSize;
                ItemDescription_TextBox[i].ForeColor = Color.Black;

                // - customer ForeName -
                ItemLocation_TextBox[i] = new TextBox(); // new label
                ItemLocation_TextBox[i].Parent = panels[i];
                ItemLocation_TextBox[i].Text = itemInfo[stockInfo[i].ItemID].location; // 
                ItemLocation_TextBox[i].Size = textSize;
                ItemLocation_TextBox[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                ItemLocation_TextBox[i].Location = new Point(defaultPadding * 2 + 200 + StockID_TextBox[i].Size.Width, ItemDescription_TextBox[i].Location.Y + ItemDescription_TextBox[i].Size.Height);
                ItemLocation_TextBox[i].Size = textSize;
                ItemLocation_TextBox[i].ForeColor = Color.Black;

                // - Edit Entry button -
                editEntry_button[i] = new Button();
                editEntry_button[i].Text = "Save Changes!";
                editEntry_button[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                editEntry_button[i].BackColor = Color.FromArgb(64, 199, 73);
                editEntry_button[i].ForeColor = Color.White;
                editEntry_button[i].Location = new Point(panelSize.Width - editEntry_button[i].Size.Width - defaultPadding, defaultPadding);
                editEntry_button[i].Parent = panels[i];
                editEntryButtonAddCallBack(i, stockInfo[i].ItemID, stockInfo, itemInfo);


                // - delete entry button -
                deleteEntry_button[i] = new Button();
                deleteEntry_button[i].Text = "Delete";
                deleteEntry_button[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                deleteEntry_button[i].ForeColor = Color.White;
                deleteEntry_button[i].BackColor = Color.Red;
                deleteEntry_button[i].Location = new Point(panelSize.Width - deleteEntry_button[i].Size.Width - defaultPadding, defaultPadding + editEntry_button[i].Location.Y + editEntry_button[i].Size.Height);
                deleteEntry_button[i].Parent = panels[i];
                deleteEntryButtonAddCallBack(i, stockInfo[i].ItemID, stockInfo, itemInfo);

                // --------------------------------------------------------------------------------------------------------------------------------

                // - Save and edit buttons --------------------------------------------------------------------------------------------------------

                // - to edit or delete a entry it requiers the item ID , stock Id of the item to be affected
                // - it will also require the actuall entry information itself "stockInfo" and "item Info"
                // - the raw data part of the srturct is then used for the delete function where it writes each whanted entrys raw data exept for the one to be deleted 
                // - this is done to not have to re-construct the string from the individual records 

                void editEntryButtonAddCallBack(int StockID, int ItemID, StockInfo[] stockInfo, ItemInfo[] itemInfo) // not sure why this function is neccasary dosnt work if not in function
                {
                    editEntry_button[i].Click += delegate (object sender, EventArgs e) { SaveEntry(sender, e, StockID, ItemID, stockInfo, itemInfo); }; // delegate function to be run on click and pass i to later refer to witch button was pressed
                }
                void deleteEntryButtonAddCallBack(int StockID, int ItemID, StockInfo[] stockInfo, ItemInfo[] itemInfo) // not sure why this function is neccasary dosnt work if not in function
                {
                    deleteEntry_button[i].Click += delegate (object sender, EventArgs e) { DeleteEntry(sender, e, StockID, ItemID, stockInfo, itemInfo); }; // delegate function to be run on click and pass i to later refer to witch button was pressed        
                }
                void DeleteEntry(object sender, EventArgs e, int StockID, int ItemID, StockInfo[] stockInfo, ItemInfo[] itemInfo)
                {
                    if (LgnFrm.CurrentUserInfo.accessLevel < 2) // ensure access level is high enough to delete stock entrys
                    {
                        //delete entry in both customer and bookings file
                        if (MessageBox.Show("Are you Sure you wish to delete this Stock ?", "Delete ?", MessageBoxButtons.YesNo) == DialogResult.Yes) // ensure that the user is sure to delete 
                        {
                            using (StreamWriter sw = new StreamWriter(settings.ItemFile, false)) // items
                            {
                                for (int i = 0; i < itemInfo.Length; i++)
                                {
                                    if (i != ItemID)
                                    {
                                        sw.WriteLine(cryptography.encryptStr(itemInfo[i].RawData)); // wrtie each line exept for the selected one 
                                    }
                                }

                            }
                            using (StreamWriter sw = new StreamWriter(settings.StockFile, false)) // stock 
                            {
                                for (int i = 0; i < stockInfo.Length; i++)
                                {
                                    if (i != StockID)
                                    {
                                        sw.WriteLine(cryptography.encryptStr(stockInfo[i].RawData)); // wrtie each line exept for the selected one 
                                    }
                                }

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Access Level Too Low !");
                    }                 
                }
                void SaveEntry(object sender, EventArgs e, int StockID, int ItemID, StockInfo[] stockInfo, ItemInfo[] itemInfo)
                {

                    ItemInfo editedItemInfo = new ItemInfo(); // store edited entry
                    StockInfo editedStockInfo = new StockInfo();
                    Validator validator = new Validator();


                    // gather edited information from textboxes and store in variable as all controlls are arrays we need to give it the stock id witch is the one that is currently being effected 
                    try
                    {
                        editedItemInfo.ItemID = int.Parse(ItemID_TextBox[StockID].Text);
                        editedItemInfo.Description = ItemDescription_TextBox[StockID].Text;
                        editedItemInfo.location = ItemLocation_TextBox[StockID].Text;

                        editedStockInfo.StockID = int.Parse(StockID_TextBox[StockID].Text);
                        editedStockInfo.ItemID = int.Parse(ItemID_TextBox[StockID].Text);
                        editedStockInfo.Quantity = int.Parse(Quantity_TextBox[StockID].Text);
                    }
                    catch
                    {
                        MessageBox.Show("Please Enter Valid Information !");
                    }


                    if (!validator.validateItem(editedItemInfo).IsError && !validator.ValidateStock(editedStockInfo).IsError)
                    {
                        using (StreamWriter sw = new StreamWriter(settings.ItemFile, false)) // save customer data 
                        {
                            for (int i = 0; i < itemInfo.Length; i++)
                            {
                                if (i != ItemID)
                                {
                                    sw.WriteLine(cryptography.encryptStr(itemInfo[i].RawData)); // wrtie each line exept for the selected one 
                                }
                                else
                                {
                                    string finalString = cryptography.encryptStr(
                                                        editedItemInfo.ItemID.ToString() + "," +
                                                        editedItemInfo.Description + "," +
                                                        editedItemInfo.location
                                                        );

                                    sw.WriteLine(finalString);
                                }
                            }
                        }

                        using (StreamWriter sw = new StreamWriter(settings.StockFile, false)) // save customer data 
                        {
                            for (int i = 0; i < stockInfo.Length; i++)
                            {
                                if (i != StockID)
                                {
                                    sw.WriteLine(cryptography.encryptStr(stockInfo[i].RawData)); // wrtie each line exept for the selected one 
                                }
                                else
                                {
                                    string finalString = cryptography.encryptStr(
                                                        editedStockInfo.StockID.ToString() + "," +
                                                        editedStockInfo.ItemID.ToString() + "," +
                                                        editedStockInfo.Quantity.ToString()
                                                        );

                                    sw.WriteLine(finalString);

                                    MessageBox.Show("Succesfully saved change !");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(validator.ValidateStock(editedStockInfo).Message);
                        MessageBox.Show(validator.validateItem(editedItemInfo).Message);
                    }
                }

                // --------------------------------------------------------------------------------------------------------------------------------
            }
        }
        public void CreateStock(Panel View_panel)
        {
            // - variables --------------------------------------------------------------------------------------------------------------------

            Size textSize = new Size(250, 24);
            Size panelSize = new Size(View_panel.Size.Width - defaultPadding * 6, 80);
            Settings settings = new Settings(); //create nenw instance of login settings
            Cryptography cryptography = new Cryptography();

            // - Stock Controlls - 
            Panel panels = new Panel();
            TextBox StockID_TextBox = new TextBox();
            TextBox ItemID_TextBox = new TextBox();
            TextBox Quantity_TextBox = new TextBox();


            // - item Controlls -
            TextBox ItemDescription_TextBox = new TextBox();
            TextBox ItemLocation_TextBox = new TextBox();

            Button createEntry_button = new Button();

            // --------------------------------------------------------------------------------------------------------------------------------

            // - Setup Controlls --------------------------------------------------------------------------------------------------------------

            RemoveControlls(View_panel);

            // - Panel -
            panels = new Panel();
            panels.Parent = View_panel;
            panels.Location = new Point(defaultPadding, defaultPadding);
            panels.Size = panelSize;
            panels.BackColor = Color.FromArgb(66, 96, 138);

            // - stock ID -
            StockID_TextBox = new TextBox();
            StockID_TextBox.Parent = panels;
            StockID_TextBox.Text = (GetStockInfo().Length != 0) ? (GetStockInfo()[GetStockInfo().Length - 1].StockID + 1).ToString() : "0"; // get next availabele booking ID, i hate this but ohh well it stays
            StockID_TextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            StockID_TextBox.Location = new Point(defaultPadding, defaultPadding);
            StockID_TextBox.ForeColor = Color.Black;

            // - item ID -
            ItemID_TextBox = new TextBox();
            ItemID_TextBox.Parent = panels;
            ItemID_TextBox.Text = (getItemInfo().Length != 0) ? (getItemInfo()[getItemInfo().Length - 1].ItemID + 1).ToString() : "0"; // get next availabele customer ID, i also hate this but my ability has not changed since 6 lines ago 
            ItemID_TextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ItemID_TextBox.Enabled = false;
            ItemID_TextBox.Size = textSize;
            ItemID_TextBox.Location = new Point(defaultPadding * 2 + 200 + StockID_TextBox.Size.Width, defaultPadding);
            ItemID_TextBox.ForeColor = Color.Black;

            // - stock quantity -
            Quantity_TextBox = new TextBox();
            Quantity_TextBox.Parent = panels;
            Quantity_TextBox.PlaceholderText = "Stock Quantity";
            Quantity_TextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Quantity_TextBox.Size = textSize;
            Quantity_TextBox.Location = new Point(defaultPadding, StockID_TextBox.Location.Y + StockID_TextBox.Size.Height);
            Quantity_TextBox.ForeColor = Color.Black;

            // - item description -
            ItemDescription_TextBox = new TextBox(); // new label
            ItemDescription_TextBox.Parent = panels;
            ItemDescription_TextBox.Size = textSize;
            ItemDescription_TextBox.PlaceholderText = "Description";
            ItemDescription_TextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ItemDescription_TextBox.Location = new Point(defaultPadding * 2 + 200 + StockID_TextBox.Size.Width, StockID_TextBox.Location.Y + StockID_TextBox.Size.Height);
            ItemDescription_TextBox.Size = textSize;
            ItemDescription_TextBox.ForeColor = Color.Black;

            // - Item Location -
            ItemLocation_TextBox = new TextBox(); // new label
            ItemLocation_TextBox.Parent = panels;
            ItemLocation_TextBox.Size = textSize;
            ItemLocation_TextBox.PlaceholderText = "Location";
            ItemLocation_TextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ItemLocation_TextBox.Location = new Point(defaultPadding * 2 + 200 + StockID_TextBox.Size.Width, ItemDescription_TextBox.Location.Y + ItemDescription_TextBox.Size.Height);
            ItemLocation_TextBox.Size = textSize;
            ItemLocation_TextBox.ForeColor = Color.Black;

            // - Create Entry button -
            createEntry_button = new Button();
            createEntry_button.Text = "Save Changes!";
            createEntry_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            createEntry_button.BackColor = Color.FromArgb(64, 199, 73);
            createEntry_button.ForeColor = Color.White;
            createEntry_button.Location = new Point(panelSize.Width - createEntry_button.Size.Width - defaultPadding, defaultPadding);
            createEntry_button.Parent = panels;
            createEntry_button.Click += delegate (object sender, EventArgs e) { CreateEntry(sender, e); }; // delegate function to be run on click and pass i to later refer to witch button was pressed

            // --------------------------------------------------------------------------------------------------------------------------------

            // - Create Entry -----------------------------------------------------------------------------------------------------------------

            void CreateEntry(object sender, EventArgs e)
            {
                StockInfo stockInfo = new StockInfo();
                ItemInfo itemInfo = new ItemInfo();
                Validator validator = new Validator();

                try
                {
                    itemInfo.ItemID = int.Parse(ItemID_TextBox.Text);
                    itemInfo.Description = ItemDescription_TextBox.Text;
                    itemInfo.location = ItemLocation_TextBox.Text;

                    stockInfo.StockID = int.Parse(StockID_TextBox.Text);
                    stockInfo.ItemID = int.Parse(ItemID_TextBox.Text);
                    stockInfo.Quantity = int.Parse(Quantity_TextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Error! please ensure that all information is corrent !");
                    return;
                }


                // validate string
                if (!validator.ValidateStock(stockInfo).IsError && !validator.validateItem(itemInfo).IsError)
                {
                    string finalString = cryptography.encryptStr(
                                        stockInfo.StockID.ToString() + "," +
                                        stockInfo.ItemID.ToString() + "," +
                                        stockInfo.Quantity

                                        );


                    using (StreamWriter sw = File.AppendText(settings.StockFile))
                    {
                        sw.WriteLine(finalString);

                    }

                    finalString = cryptography.encryptStr(
                                        itemInfo.ItemID.ToString() + "," +
                                        itemInfo.Description + "," +
                                        itemInfo.location
                                        );


                    using (StreamWriter sw = File.AppendText(settings.ItemFile))
                    {
                        sw.WriteLine(finalString);

                    }



                    MessageBox.Show("Created New Stock Entry !");

                }
                else
                {
                    MessageBox.Show(validator.validateItem(itemInfo).Message);
                    MessageBox.Show(validator.ValidateStock(stockInfo).Message);
                }
            }
            // --------------------------------------------------------------------------------------------------------------------------------
        }
        public void SearchStock(Panel View_panel, string quieryString)
        {
            // - variables --------------------------------------------------------------------------------------------------------------------

            Search searcher = new Search();

            Size textSize = new Size(250, 24);
            Size panelSize = new Size(View_panel.Size.Width - defaultPadding * 6, 72);

            ItemInfo[] itemInfo = getItemInfo();
            StockInfo[] stockInfo = GetStockInfo();
            int[] stockID = new int[stockInfo.Length];

            // - Stock Controlls - 
            Panel panels = new Panel();
            Label StockID_Label = new Label();
            Label ItemID_Label = new Label();
            Label Quantity_Label = new Label();

            // - item Controlls -
            Label ItemDescription_Label = new Label();
            Label ItemLocation_Label = new Label();

            int quiery = -1; // if parsing enterd quiery fails it will still proceed to search for something so by default
                             // search for -1 as it never be found so there is a constistant ouctput in wierd cases 
            int quieryLocation;

            RemoveControlls(View_panel);

            // --------------------------------------------------------------------------------------------------------------------------------

            // - Search For Enterd Quiery -----------------------------------------------------------------------------------------------------

            try
            {
                quiery = int.Parse(quieryString);
            }
            catch
            {
                MessageBox.Show("Error! please ensure searh quiery is a valid ID (Numbers Only)");
            }
            for (int i =0; i < stockInfo.Length; i++)
            {
                stockID[i] = stockInfo[i].StockID;
            }

            quieryLocation = searcher.binarySearch(stockID, 0, stockID.Length - 1, quiery);
            if(quieryLocation == -1)
            {
                MessageBox.Show("Quiery Not Found!");
            }

            // --------------------------------------------------------------------------------------------------------------------------------

            // - Setup Controlls --------------------------------------------------------------------------------------------------------------

            else
            {
                

                // - Panel -
                panels.Parent = View_panel;
                panels.Location = new Point(defaultPadding, defaultPadding);
                panels.Size = panelSize;
                panels.BackColor = Color.FromArgb(66, 96, 138);

                // - stock ID -
                StockID_Label.Parent = panels;
                StockID_Label.Text = "Stock ID: " + stockInfo[quieryLocation].StockID.ToString();
                StockID_Label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                StockID_Label.Location = new Point(defaultPadding, defaultPadding);
                StockID_Label.ForeColor = Color.White;

                // - item ID -
                ItemID_Label.Parent = panels;
                ItemID_Label.Text = "Item ID: " + stockInfo[(quieryLocation)].ItemID.ToString();    
                ItemID_Label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                ItemID_Label.Size = textSize;
                ItemID_Label.Location = new Point(defaultPadding * 2 + 200 + StockID_Label.Size.Width, defaultPadding);
                ItemID_Label.ForeColor = Color.White;

                // - stock quantity -
                Quantity_Label.Parent = panels;
                Quantity_Label.Text = "Quantity: " + stockInfo[quieryLocation].Quantity.ToString();
                Quantity_Label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                Quantity_Label.Size = textSize;
                Quantity_Label.Location = new Point(defaultPadding, StockID_Label.Location.Y + StockID_Label.Size.Height);
                Quantity_Label.ForeColor = Color.White;

                // - item description -
                ItemDescription_Label.Parent = panels;
                ItemDescription_Label.Size = textSize;
                ItemDescription_Label.Text = "Description: " + itemInfo[stockInfo[quieryLocation].ItemID].Description; // item description at the item id of the stock entry searched for
                                                                                                       // this is not nessacerilt needed as in most cases item id = stock id but there are cases where it is possible 
                ItemDescription_Label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                ItemDescription_Label.Location = new Point(defaultPadding * 2 + 200 + StockID_Label.Size.Width, StockID_Label.Location.Y + StockID_Label.Size.Height);
                ItemDescription_Label.Size = textSize;
                ItemDescription_Label.ForeColor = Color.White;

                // - Item Location -
                ItemLocation_Label.Parent = panels;
                ItemLocation_Label.Size = textSize;
                ItemLocation_Label.Text = "Location: " + itemInfo[stockInfo[quieryLocation].ItemID].location;
                ItemLocation_Label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                ItemLocation_Label.Location = new Point(defaultPadding * 2 + 200 + StockID_Label.Size.Width, ItemDescription_Label.Location.Y + ItemDescription_Label.Size.Height);
                ItemLocation_Label.Size = textSize;
                ItemLocation_Label.ForeColor = Color.White;

                // --------------------------------------------------------------------------------------------------------------------------------
            }



        }
        StockInfo[] GetStockInfo()
        {
            // - Variables --------------------------------------------------------------------------------------------------------------------
            Settings settings = new Settings();
            Cryptography cryptography = new Cryptography();
            int NumberOfStock = 0; // number of lines in file
            // --------------------------------------------------------------------------------------------------------------------------------

            // - Get number of entrys in file -------------------------------------------------------------------------------------------------

            using (StreamReader Sr = new StreamReader(settings.StockFile)) // create new stream reader  
            {
                while (Sr.Peek() >= 0) // if not at end of file
                {
                    Sr.ReadLine(); //read line to advance file pointer 
                    NumberOfStock++; // incriment number of lines 
                }
            }
            // --------------------------------------------------------------------------------------------------------------------------------

            // - Get entrys from file and store in array --------------------------------------------------------------------------------------

            StockInfo[] StockInfo = new StockInfo[NumberOfStock];

            using (StreamReader Sr = new StreamReader(settings.StockFile)) // create new stream reader
            {
                int i = 0;
                while (Sr.Peek() >= 0) // if not at end of file
                {
                    StockInfo[i].RawData = cryptography.decryptStr(Sr.ReadLine());            //read line from file and decrypt
                    string[] entry = StockInfo[i].RawData.Split(","); // split read line by ,
                    StockInfo[i].StockID = int.Parse(entry[0]); // parse first field "Stock ID"
                    StockInfo[i].ItemID = int.Parse(entry[1]); // parse second field "Item ID"
                    StockInfo[i].Quantity = int.Parse(entry[2]); // parse third field "quantity"
                    i++;
                }

            }
            // --------------------------------------------------------------------------------------------------------------------------------
            return StockInfo;
        }
        ItemInfo[] getItemInfo()
        {
            // - Variables --------------------------------------------------------------------------------------------------------------------
            Settings settings = new Settings();
            Cryptography cryptography = new Cryptography();
            int NumberOfItems = 0; // number of lines in file
            // --------------------------------------------------------------------------------------------------------------------------------

            // - Get number of entrys in file -------------------------------------------------------------------------------------------------

            using (StreamReader Sr = new StreamReader(settings.ItemFile)) // create new stream reader  
            {
                while (Sr.Peek() >= 0) // if not at end of file
                {
                    Sr.ReadLine(); //read line to advance file pointer 
                    NumberOfItems++; // incriment number of lines 
                }
            }
            // --------------------------------------------------------------------------------------------------------------------------------

            // - get entrys from file and store in array --------------------------------------------------------------------------------------

            ItemInfo[] itemInfo = new ItemInfo[NumberOfItems];

            using (StreamReader Sr = new StreamReader(settings.ItemFile)) // create new stream reader
            {
                int i = 0;
                while (Sr.Peek() >= 0) // if not at end of file
                {
                    itemInfo[i].RawData = cryptography.decryptStr(Sr.ReadLine());            //read line from file and decrypt
                    string[] entry = itemInfo[i].RawData.Split(","); // split read line by ,
                    itemInfo[i].ItemID = int.Parse(entry[0]); // parse first field "Item ID"
                    itemInfo[i].Description = entry[1]; // parse second field "description"
                    itemInfo[i].location = entry[2]; // parse third field "location"
                    i++;
                }

            }
            // --------------------------------------------------------------------------------------------------------------------------------
            return itemInfo;
        }
        private void RemoveControlls(Panel panel)
        {
            while (panel.Controls.Count > 0)
            {
                panel.Controls[0].Dispose(); // remove child if there is one remaining
            }
        }
    }
}
