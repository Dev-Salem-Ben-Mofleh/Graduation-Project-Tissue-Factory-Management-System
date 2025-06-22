using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Electricity_Department;
using WindowsFormsApp1.Sales_Department;
using WindowsFormsApp1.Management_Persons;
using WindowsFormsApp1.Users_management;
using WindowsFormsApp1.Purncasing_Departmnet;
using WindowsFormsApp1.Products_management;
using WindowsFormsApp1.Expenses_Management;
using WindowsFormsApp1.Inventory_management;
using WindowsFormsApp1.Production_mamagment;
using WindowsFormsApp1.Management_Boxes;
using WindowsFormsApp1.ManagmentReports;
using WindowsFormsApp1.DashBoard;
using WindowsFormsApp1.Global;
using WindowsFormsApp1.Login;

namespace WindowsFormsApp1
{
    public partial class frmHome : Form
    {
        frmLogin _frmLogin;
        public frmHome(frmLogin frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
        }
        bool menuExpand = false;
        char Container = 'a';
        private void _LoadDeful()
        {
            lbUserName.Text = clsGlobal.CurrentUser.PersonInfo.Name;
        }
        private void Containers()
        {
            if (Container == 'u')
            {
                paContaierProducts.Height = 55;
                paContainerBoxes.Height = 55;
                paContainerBuying.Height = 55;
                paContainerEx.Height = 55;
                paContainerSelling.Height = 55;
                paContainerPersons.Height = 55;
                paContainerBoxessssssss.Height =55;
                paContainerReoprtss.Height = 55;
                paContainerReoprtss.Height = 55; paContainerReoprtss.BackColor = btnReports.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBoxessssssss.Height = 55; paContainerBoxessssssss.BackColor = btnMaBox.BackColor = Color.FromArgb(231, 237, 243);
                paContaierProducts.BackColor=btnMnProcducts.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBoxes.BackColor = btnBox.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBuying.BackColor = btnBuyings.BackColor = Color.FromArgb(231, 237, 243);
                paContainerEx.BackColor = btnMnEx.BackColor = Color.FromArgb(231, 237, 243);
                paContainerSelling.BackColor = btnMnSelling.BackColor = Color.FromArgb(231, 237, 243);
                paContainerPersons.BackColor = btnMnPersons.BackColor = Color.FromArgb(231, 237, 243);

                if (menuExpand == false )
                {
                    paContainerUsers.Height += 10;
                    if (paContainerUsers.Height >= 219)
                    {
                        timer1.Stop();
                        menuExpand = true;
                        paContainerUsers.BackColor= Color.White;
                        btnUsersList.BackColor = Color.White;

                    }
                }
                else
                {
                    paContainerUsers.Height -= 10;
                    if (paContainerUsers.Height <= 55)
                    {
                        timer1.Stop();
                        menuExpand = false;
                        paContainerUsers.BackColor = Color.FromArgb(231, 237, 243);
                        btnUsersList.BackColor = Color.FromArgb(231, 237, 243);
                    }

                }
            }
            else
            if (Container == 'p')
            {
                paContainerUsers.Height = 55;
                paContainerBoxes.Height = 55;
                paContainerBuying.Height = 55;
                paContainerEx.Height = 55;
                paContainerSelling.Height = 55;
                paContainerPersons.Height = 55;
                paContainerBoxessssssss.Height = 55;
                paContainerReoprtss.Height = 55;
                paContainerReoprtss.Height = 55; paContainerReoprtss.BackColor = btnReports.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBoxessssssss.Height = 55; paContainerBoxessssssss.BackColor = btnMaBox.BackColor = Color.FromArgb(231, 237, 243);
                paContainerUsers.BackColor = btnUsersList.BackColor= Color.FromArgb(231, 237, 243);
                paContainerEx.BackColor = btnMnEx.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBoxes.BackColor = btnBox.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBuying.BackColor = btnBuyings.BackColor = Color.FromArgb(231, 237, 243);
                paContainerSelling.BackColor = btnMnSelling.BackColor = Color.FromArgb(231, 237, 243);
                paContainerPersons.BackColor = btnMnPersons.BackColor = Color.FromArgb(231, 237, 243);
                if (menuExpand == false)
                {
                    paContaierProducts.Height += 10;
                    if (paContaierProducts.Height >= 201)
                    {
                        timer1.Stop();
                        menuExpand = true;
                        paContaierProducts.BackColor = Color.White;
                        btnMnProcducts.BackColor = Color.White;

                    }
                }
                else
                {
                    paContaierProducts.Height -= 10;
                    if (paContaierProducts.Height <= 55)
                    {
                        timer1.Stop();
                        menuExpand = false;
                        paContaierProducts.BackColor = Color.FromArgb(231, 237, 243);
                        btnMnProcducts.BackColor = Color.FromArgb(231, 237, 243);

                    }

                }
            }

            else
            if (Container == 'b')
            {
                paContainerUsers.Height = 55;
                paContaierProducts.Height = 55;
                paContainerBuying.Height = 55;
                paContainerEx.Height = 55;
                paContainerSelling.Height = 55;
                paContainerPersons.Height = 55;
                paContainerReoprtss.Height = 55;
                paContainerReoprtss.Height = 55; paContainerReoprtss.BackColor = btnReports.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBoxessssssss.Height = 55;
                paContainerBoxessssssss.Height = 55; paContainerBoxessssssss.BackColor = btnMaBox.BackColor = Color.FromArgb(231, 237, 243);
                paContainerUsers.BackColor = btnUsersList.BackColor = Color.FromArgb(231, 237, 243);
                paContaierProducts.BackColor = btnMnProcducts.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBuying.BackColor = btnBuyings.BackColor = Color.FromArgb(231, 237, 243);
                paContainerEx.BackColor = btnMnEx.BackColor = Color.FromArgb(231, 237, 243);
                paContainerSelling.BackColor = btnMnSelling.BackColor = Color.FromArgb(231, 237, 243);
                paContainerPersons.BackColor = btnMnEx.BackColor = Color.FromArgb(231, 237, 243);

                if (menuExpand == false)
                {
                    paContainerBoxes.Height += 10;
                    if (paContainerBoxes.Height >= 200)
                    {
                        timer1.Stop();
                        menuExpand = true;
                        paContainerBoxes.BackColor = Color.White;
                        btnBox.BackColor = Color.White; 
                    }
                }
                else
                {
                    paContainerBoxes.Height -= 10;
                    if (paContainerBoxes.Height <= 55)
                    {
                        timer1.Stop();
                        menuExpand = false;
                        paContainerBoxes.BackColor = Color.FromArgb(231, 237, 243);
                        btnBox.BackColor = Color.FromArgb(231, 237, 243);

                    }

                }
            }

            else
            if (Container == 'y')
            {
                paContainerUsers.Height = 55;
                paContaierProducts.Height = 55;
                paContainerBoxes.Height = 55;
                paContainerEx.Height = 55;
                paContainerSelling.Height = 55;
                paContainerPersons.Height = 55;
                paContainerBoxessssssss.Height = 55;
                paContainerReoprtss.Height = 55;
                paContainerReoprtss.Height = 55; paContainerReoprtss.BackColor = btnReports.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBoxessssssss.Height = 55; paContainerBoxessssssss.BackColor = btnMaBox.BackColor = Color.FromArgb(231, 237, 243);
                paContainerUsers.BackColor = btnUsersList.BackColor = Color.FromArgb(231, 237, 243);
                paContaierProducts.BackColor = btnMnProcducts.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBoxes.BackColor = btnBox.BackColor = Color.FromArgb(231, 237, 243);
                paContainerEx.BackColor = btnMnEx.BackColor = Color.FromArgb(231, 237, 243);
                paContainerSelling.BackColor = btnMnSelling.BackColor = Color.FromArgb(231, 237, 243);
                paContainerPersons.BackColor = btnMnEx.BackColor = Color.FromArgb(231, 237, 243);

                if (menuExpand == false)
                {
                    paContainerBuying.Height += 10;
                    if (paContainerBuying.Height >= 200)
                    {
                        timer1.Stop();
                        menuExpand = true;
                        paContainerBuying.BackColor = Color.White;
                        btnBuyings.BackColor = Color.White;

                    }
                }
                else
                {
                    paContainerBuying.Height -= 10;
                    if (paContainerBuying.Height <= 55)
                    {
                        timer1.Stop();
                        menuExpand = false;
                        paContainerBuying.BackColor = Color.FromArgb(231, 237, 243);
                        btnBuyings.BackColor = Color.FromArgb(231, 237, 243);

                    }

                }
            }
            else
            if (Container == 'e')
            {
                if (menuExpand == false)
                {
                    paContainerUsers.Height = 55;
                    paContaierProducts.Height = 55;
                    paContainerBoxes.Height = 55;
                    paContainerBuying.Height = 55;
                    paContainerSelling.Height = 55;
                    paContainerPersons.Height = 55;
                    paContainerBoxessssssss.Height = 55;
                    paContainerReoprtss.Height = 55;
                    paContainerReoprtss.Height = 55; paContainerReoprtss.BackColor = btnReports.BackColor = Color.FromArgb(231, 237, 243);
                    paContainerBoxessssssss.Height = 55; paContainerBoxessssssss.BackColor = btnMaBox.BackColor = Color.FromArgb(231, 237, 243);
                    paContainerUsers.BackColor = btnUsersList.BackColor = Color.FromArgb(231, 237, 243);
                    paContaierProducts.BackColor = btnMnProcducts.BackColor = Color.FromArgb(231, 237, 243);
                    paContainerBoxes.BackColor = btnBox.BackColor = Color.FromArgb(231, 237, 243);
                    paContainerBuying.BackColor = btnBuyings.BackColor = Color.FromArgb(231, 237, 243);
                    paContainerSelling.BackColor = btnMnSelling.BackColor = Color.FromArgb(231, 237, 243);
                    paContainerPersons.BackColor = btnMnEx.BackColor = Color.FromArgb(231, 237, 243);

                    paContainerEx.Height += 10;
                    if (paContainerEx.Height >= 154)
                    {
                        timer1.Stop();
                        menuExpand = true;
                        paContainerEx.BackColor = Color.White;
                        btnMnEx.BackColor = Color.White;

                    }
                }
                else
                {
                    paContainerEx.Height -= 10;
                    if (paContainerEx.Height <= 55)
                    {
                        timer1.Stop();
                        menuExpand = false;
                        paContainerEx.BackColor = Color.FromArgb(231, 237, 243);
                        btnMnEx.BackColor = Color.FromArgb(231, 237, 243);

                    }

                }
            }
            else
            if (Container == 's')
            {
                paContainerUsers.Height = 55;
                paContaierProducts.Height = 55;
                paContainerBoxes.Height = 55;
                paContainerBuying.Height = 55;
                paContainerEx.Height = 55;
                paContainerPersons.Height = 55;
                paContainerBoxessssssss.Height = 55;
                paContainerReoprtss.Height = 55;
                paContainerReoprtss.Height = 55; paContainerReoprtss.BackColor = btnReports.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBoxessssssss.Height = 55; paContainerBoxessssssss.BackColor = btnMaBox.BackColor = Color.FromArgb(231, 237, 243);
                paContainerUsers.BackColor = btnUsersList.BackColor = Color.FromArgb(231, 237, 243);
                paContaierProducts.BackColor = btnMnProcducts.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBoxes.BackColor = btnBox.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBuying.BackColor = btnBuyings.BackColor = Color.FromArgb(231, 237, 243);
                paContainerEx.BackColor = btnMnEx.BackColor = Color.FromArgb(231, 237, 243);
                paContainerPersons.BackColor = btnMnEx.BackColor = Color.FromArgb(231, 237, 243);

                if (menuExpand == false)
                {
                    paContainerSelling.Height += 10;
                    if (paContainerSelling.Height >= 148)
                    {
                        timer1.Stop();
                        menuExpand = true;
                        paContainerSelling.BackColor = Color.White;
                        btnMnSelling.BackColor = Color.White;

                    }
                }
                else
                {
                    paContainerSelling.Height -= 10;
                    if (paContainerSelling.Height <= 55)
                    {
                        timer1.Stop();
                        menuExpand = false;
                        paContainerSelling.BackColor = Color.FromArgb(231, 237, 243);
                        btnMnSelling.BackColor = Color.FromArgb(231, 237, 243);

                    }

                }
            }
            else
            if (Container == 'c')
            {
                paContainerUsers.Height = 55;
                paContaierProducts.Height = 55;
                paContainerBoxes.Height = 55;
                paContainerBuying.Height = 55;
                paContainerEx.Height = 55;
                paContainerSelling.Height = 55;
                paContainerBoxessssssss.Height = 55;
                paContainerReoprtss.Height = 55;
                paContainerReoprtss.Height = 55; paContainerReoprtss.BackColor = btnReports.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBoxessssssss.Height = 55; paContainerBoxessssssss.BackColor = btnMaBox.BackColor = Color.FromArgb(231, 237, 243);
                paContainerSelling.BackColor = btnMnSelling.BackColor = Color.FromArgb(231, 237, 243);
                paContainerUsers.BackColor = btnUsersList.BackColor = Color.FromArgb(231, 237, 243);
                paContaierProducts.BackColor = btnMnProcducts.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBoxes.BackColor = btnBox.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBuying.BackColor = btnBuyings.BackColor = Color.FromArgb(231, 237, 243);
                paContainerEx.BackColor = btnMnEx.BackColor = Color.FromArgb(231, 237, 243);

                if (menuExpand == false)
                {
                    paContainerPersons.Height += 10;
                    if (paContainerPersons.Height >= 202)
                    {
                        timer1.Stop();
                        menuExpand = true;
                        paContainerPersons.BackColor = Color.White;
                        btnClients.BackColor = Color.White;
                        btnMnPersons.BackColor = Color.White;

                    }
                }
                else
                {
                    paContainerPersons.Height -= 10;
                    if (paContainerPersons.Height <= 55)
                    {
                        timer1.Stop();
                        menuExpand = false;
                        paContainerPersons.BackColor = Color.FromArgb(231, 237, 243);
                        btnClients.BackColor = Color.FromArgb(231, 237, 243);
                        btnMnPersons.BackColor = Color.FromArgb(231, 237, 243);

                    }

                }
            }
            else
            if (Container == 'x')
            {


                paContaierProducts.Height = 55;
                paContainerBoxes.Height = 55;
                paContainerBuying.Height = 55;
                paContainerEx.Height = 55;
                paContainerSelling.Height = 55;
                paContainerReoprtss.Height = 55;
                paContainerReoprtss.Height = 55; paContainerReoprtss.BackColor = btnReports.BackColor = Color.FromArgb(231, 237, 243);
                paContainerUsers.BackColor = btnUsersList.BackColor = Color.FromArgb(231, 237, 243);
                paContaierProducts.BackColor = btnMnProcducts.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBoxes.BackColor = btnBox.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBuying.BackColor = btnBuyings.BackColor = Color.FromArgb(231, 237, 243);
                paContainerEx.BackColor = btnMnEx.BackColor = Color.FromArgb(231, 237, 243);
                paContainerSelling.BackColor = btnMnSelling.BackColor = Color.FromArgb(231, 237, 243);

                if (menuExpand == false)
                {
                    paContainerBoxessssssss.Height += 10;
                    if (paContainerBoxessssssss.Height >= 202)
                    {
                        timer1.Stop();
                        menuExpand = true;
                        paContainerBoxessssssss.BackColor = Color.White;
                        btnMaBox.BackColor = Color.White;

                    }
                }
                else
                {
                    paContainerBoxessssssss.Height -= 10;
                    if (paContainerBoxessssssss.Height <= 55)
                    {
                        timer1.Stop();
                        menuExpand = false;
                        paContainerBoxessssssss.BackColor = Color.FromArgb(231, 237, 243);
                        btnMaBox.BackColor = Color.FromArgb(231, 237, 243);

                    }

                }
            }
            else
            if (Container == 'r')
            {


                paContaierProducts.Height = 55;
                paContainerBoxes.Height = 55;
                paContainerBuying.Height = 55;
                paContainerEx.Height = 55;
                paContainerSelling.Height = 55;
                paContainerBoxessssssss.Height = 55;
                paContainerBoxessssssss.Height = 55; paContainerBoxessssssss.BackColor = btnMaBox.BackColor = Color.FromArgb(231, 237, 243);
                paContainerUsers.BackColor = btnUsersList.BackColor = Color.FromArgb(231, 237, 243);
                paContaierProducts.BackColor = btnMnProcducts.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBoxes.BackColor = btnBox.BackColor = Color.FromArgb(231, 237, 243);
                paContainerBuying.BackColor = btnBuyings.BackColor = Color.FromArgb(231, 237, 243);
                paContainerEx.BackColor = btnMnEx.BackColor = Color.FromArgb(231, 237, 243);
                paContainerSelling.BackColor = btnMnSelling.BackColor = Color.FromArgb(231, 237, 243);

                if (menuExpand == false)
                {
                    paContainerReoprtss.Height += 10;
                    if (paContainerReoprtss.Height >= 390)
                    {
                        timer1.Stop();
                        menuExpand = true;
                        paContainerReoprtss.BackColor = Color.White;
                        btnReports.BackColor = Color.White;

                    }
                }
                else
                {
                    paContainerReoprtss.Height -= 10;
                    if (paContainerReoprtss.Height <= 55)
                    {
                        timer1.Stop();
                        menuExpand = false;
                        paContainerReoprtss.BackColor = Color.FromArgb(231, 237, 243);
                        btnReports.BackColor = Color.FromArgb(231, 237, 243);

                    }

                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Containers();
        }

        bool sidebarExpand = true;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidbar.Width -= 10;
                if (sidbar.Width <= 52)
                {
                    sidebarExpand = false;
                    timer2.Stop();
                }
            }
            else
            {
                sidbar.Width += 10;
                if(sidbar.Width >= 236)
                {
                    sidebarExpand = true;
                    timer2.Stop();
                }
            }
        }

        private void btnLittel_Click(object sender, EventArgs e)
        {
            timer2.Start();

        }


        private void btnUsersList_Click(object sender, EventArgs e)
        {
            menuExpand = (Container == (Convert.ToChar(btnUsersList.Tag)) && paContainerUsers.Height>55);
            Container = 'u';
            timer1.Start();
        }



        private void btnMnEx_Click(object sender, EventArgs e)
        {
            menuExpand = Container==(Convert.ToChar( btnMnEx.Tag) )&& (paContainerEx.Height > 55);
            Container = 'e';
            timer1.Start();

        }

        private void btnBox_Click(object sender, EventArgs e)
        {
            menuExpand = Container ==( Convert.ToChar(btnBox.Tag)) && (paContainerBoxes.Height > 55);
            Container = 'b';
            timer1.Start();

        }

        private void btnMatrialBoxes_Click(object sender, EventArgs e)
        {
            LoadForm(new frmListOfRawMaterialStock());

        }

        private void btnMovedBoxes_Click(object sender, EventArgs e)
        {
            LoadForm(new frmStockMovement());

        }

        private void btnBuyings_Click(object sender, EventArgs e)
        {
            menuExpand = Container == (Convert.ToChar(btnBuyings.Tag)) &&( paContainerBuying.Height > 55);
            Container = 'y';
            timer1.Start();

        }
        private void btnMnProcducts_Click(object sender, EventArgs e)
        {
            menuExpand = Container == (Convert.ToChar(btnMnProcducts.Tag)) &&( paContaierProducts.Height > 55);
            Container = 'p';
            timer1.Start();

        }
        public void LoadForm(Object from)
        {
            if (this.paMain.Controls.Count > 0)
                this.paMain.Controls.RemoveAt(0);
            Form f = from as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.paMain.Controls.Add(f);
            this.paMain.Tag = f;
            f.Show();
        }
        private void btnMnElectricty_Click(object sender, EventArgs e)
        {
            paContainerUsers.Height = 55;
            paContaierProducts.Height = 55;
            paContainerBoxes.Height = 55;
            paContainerBuying.Height = 55;
            paContainerSelling.Height = 55;
            paContainerEx.Height = 55;
            paContainerPersons.Height = 55;
            paContainerBoxessssssss.Height = 55;
            paContainerReoprtss.Height = 55;
            paContainerReoprtss.Height = 55; paContainerReoprtss.BackColor = btnReports.BackColor = Color.FromArgb(231, 237, 243);
            paContainerBoxessssssss.Height = 55; paContainerBoxessssssss.BackColor = btnMaBox.BackColor = Color.FromArgb(231, 237, 243);
            paContainerUsers.BackColor = btnUsersList.BackColor = Color.FromArgb(231, 237, 243);
            paContaierProducts.BackColor = btnMnProcducts.BackColor = Color.FromArgb(231, 237, 243);
            paContainerBoxes.BackColor = btnBox.BackColor = Color.FromArgb(231, 237, 243);
            paContainerBuying.BackColor = btnBuyings.BackColor = Color.FromArgb(231, 237, 243);
            paContainerEx.BackColor = btnMnEx.BackColor = Color.FromArgb(231, 237, 243);
            paContainerSelling.BackColor = btnMnSelling.BackColor = Color.FromArgb(231, 237, 243);
            paContainerPersons.BackColor = btnMnPersons.BackColor = Color.FromArgb(231, 237, 243);

            LoadForm(new frmElectricity());

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            menuExpand = Container == (Convert.ToChar(btnReports.Tag)) && (paContainerReoprtss.Height > 55);
            Container = 'r';
            timer1.Start();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            menuExpand = false;
            paContainerUsers.Height = 55;
            paContaierProducts.Height = 55;
            paContainerBoxes.Height = 55;
            paContainerBuying.Height = 55;
            paContainerSelling.Height = 55;
            paContainerEx.Height = 55;
            paContainerPersons.Height = 55;
            paContainerBoxessssssss.Height = 55;
            paContainerReoprtss.Height = 55;
            paContainerReoprtss.Height = 55; paContainerReoprtss.BackColor = btnReports.BackColor = Color.FromArgb(231, 237, 243);
            paContainerBoxessssssss.Height = 55; paContainerBoxessssssss.BackColor = btnMaBox.BackColor = Color.FromArgb(231, 237, 243);
            paContainerUsers.BackColor = btnUsersList.BackColor = Color.FromArgb(231, 237, 243);
            paContaierProducts.BackColor = btnMnProcducts.BackColor = Color.FromArgb(231, 237, 243);
            paContainerBoxes.BackColor = btnBox.BackColor = Color.FromArgb(231, 237, 243);
            paContainerBuying.BackColor = btnBuyings.BackColor = Color.FromArgb(231, 237, 243);
            paContainerEx.BackColor = btnMnEx.BackColor = Color.FromArgb(231, 237, 243);
            paContainerSelling.BackColor = btnMnSelling.BackColor = Color.FromArgb(231, 237, 243);
            paContainerPersons.BackColor = btnMnPersons.BackColor = Color.FromArgb(231, 237, 243);
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {

            menuExpand = false;
            paContainerUsers.Height = 55;
            paContaierProducts.Height = 55;
            paContainerBoxes.Height = 55;
            paContainerBuying.Height = 55;
            paContainerSelling.Height = 55;
            paContainerEx.Height = 55;
            paContainerPersons.Height = 55;
            paContainerBoxessssssss.Height = 55;
            paContainerReoprtss.Height = 55;
            paContainerReoprtss.Height = 55; paContainerReoprtss.BackColor = btnReports.BackColor = Color.FromArgb(231, 237, 243);
            paContainerBoxessssssss.Height = 55; paContainerBoxessssssss.BackColor = btnMaBox.BackColor = Color.FromArgb(231, 237, 243);
            paContainerUsers.BackColor = btnUsersList.BackColor = Color.FromArgb(231, 237, 243);
            paContaierProducts.BackColor = btnMnProcducts.BackColor = Color.FromArgb(231, 237, 243);
            paContainerBoxes.BackColor = btnBox.BackColor = Color.FromArgb(231, 237, 243);
            paContainerBuying.BackColor = btnBuyings.BackColor = Color.FromArgb(231, 237, 243);
            paContainerEx.BackColor = btnMnEx.BackColor = Color.FromArgb(231, 237, 243);
            paContainerSelling.BackColor = btnMnSelling.BackColor = Color.FromArgb(231, 237, 243);
            paContainerPersons.BackColor = btnMnPersons.BackColor = Color.FromArgb(231, 237, 243);
            LoadForm(new frmDashBoard());

        }

        private void btnNewBuying_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateSalesBill frm = new frmAddAndUpdateSalesBill();
            frm.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            menuExpand = Container == (Convert.ToChar(btnClients.Tag)) && (paContainerPersons.Height > 55);
            Container = 'c';
            timer1.Start();
        }


        private void btnProductsBoxes_Click(object sender, EventArgs e)
        {
            LoadForm(new frmProducingMaterials());

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LoadForm(new frmListOfProducts());

        }

        private void btnMnUser_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserList());

        }
        private void btnMnPersons_Click(object sender, EventArgs e)
        {
            LoadForm(new frmPersonsList());

        }      
        private void btnMangeSales_Click(object sender, EventArgs e)
        {
            LoadForm(new frmSales());


        }

        private void btnBuyingBill_Click(object sender, EventArgs e)
        {
            LoadForm(new frmListOfPurncasing());

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            LoadForm(new frmListProductions());

        }

        private void btnExKind_Click(object sender, EventArgs e)
        {
            LoadForm(new frmListOfExpenses());

        }

        private void btnMnSelling_Click(object sender, EventArgs e)
        {
            menuExpand = Container == (Convert.ToChar(btnMnSelling.Tag)) && (paContainerSelling.Height > 55);
            Container = 's';
            timer1.Start();
        }

        private void paMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMaBox_Click(object sender, EventArgs e)
        {
            menuExpand = Container == (Convert.ToChar(btnMaBox.Tag)) && (paContainerBoxessssssss.Height > 55);
            Container = 'x';
            timer1.Start();
        }

        private void btnMovmentBox_Click(object sender, EventArgs e)
        {
            LoadForm(new frmBoxMovemnets());

        }

        private void btnBoxInfo_Click(object sender, EventArgs e)
        {

            frmShowBoxInfo frm = new frmShowBoxInfo();
            frm.ShowDialog();
        }

        private void btnUpdateCureency_Click(object sender, EventArgs e)
        {
            frmUpdateCurrncy frm = new frmUpdateCurrncy();
            frm.ShowDialog();

        }

        private void btnSaleR_Click(object sender, EventArgs e)
        {
            LoadForm(new frmSalingR());

        }

        private void btnprunchR_Click(object sender, EventArgs e)
        {
            LoadForm(new frmBurncheR());

        }

        private void btnProductR_Click(object sender, EventArgs e)
        {
            LoadForm(new frmProdctsR());

        }

        private void btnRawsR_Click(object sender, EventArgs e)
        {
            LoadForm(new frmRawmaR());

        }

        private void btnElectR_Click(object sender, EventArgs e)
        {
            LoadForm(new frmElctrciyuR());

        }

        private void btnExpenseReports_Click(object sender, EventArgs e)
        {
            LoadForm(new frmExpense());

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            _LoadDeful();
            LoadForm(new frmDashBoard());

        }

        private void btnRecordsUsers_Click(object sender, EventArgs e)
        {
            LoadForm(new frmLoginRegiter());
          
        }

        private void عرضمعلوماتكToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void تحدديثمعلوماتToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmAddAndUpdateUser frm = new frmAddAndUpdateUser(clsGlobal.CurrentUser.UserID);
            //frm.ShowDialog();
        }

        private void تغييركملةالسرواسمالمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatePassword frm = new frmUpdatePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnSetting, new Point(0, btnSetting.Height));
        }


        private void ptUserAccount_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddAndUpdatePerson frm = new frmAddAndUpdatePerson();
            frm.ShowDialog();
        }

        private void btnCheckAccount_Click(object sender, EventArgs e)
        {
            frmSearchPerson frm = new frmSearchPerson();
            frm.ShowDialog();
        }

        private void btnNewBuyingBill_Click(object sender, EventArgs e)
        {
            frmAddAndUpdatePurncasing frm = new frmAddAndUpdatePurncasing();
            frm.ShowDialog();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateProduction frm = new frmAddAndUpdateProduction();
            frm.ShowDialog();
        }

        private void iconButton28_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateExpenses frm = new frmAddAndUpdateExpenses();
            frm.ShowDialog();
        }

        private void btnMatiralBuying_Click(object sender, EventArgs e)
        {
            LoadForm(new frmListOfRawMaterialStock());

        }
    }
}
