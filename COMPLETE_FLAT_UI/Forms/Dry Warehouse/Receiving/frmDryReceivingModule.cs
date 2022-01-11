﻿using COMPLETE_FLAT_UI.Models;
using CrystalDecisions.CrystalReports.Engine;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmDryReceivingModule : MaterialForm
    {
        myclasses xClass = new myclasses();
        DataSet dSet = new DataSet();
        DataSet dSet_temp = new DataSet();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();

        string Rpt_Path = "";
     
        ReportDocument rpt = new ReportDocument();
        public frmDryReceivingModule()
        {
            InitializeComponent();
        }

        public string totalRecords { get; set; }
        public int p_id { get; set; }
        public string sp_item_code { get; set; }
        public string sp_item_description { get; set; }
        public string sp_added_by { get; set; }
        public string sp_added_by_userid { get; set; }
        public string sp_final_id { get; set; }
        public double sp_receiving_qty { get; set; }
        public string sp_total_remaining_po { get; set; }
        public string sp_warehouse_reject_approval { get; set; }
        public int sp_projection_id { get; set; }
        
        private void frmDryReceivingModule_Load(object sender, EventArgs e)
        {
            this.firstLoad();
            this.sp_added_by = userinfo.emp_name.ToString();
            this.sp_added_by_userid = userinfo.user_id.ToString();
            this.mattxtbarcode.Focus();
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.mattxtbarcode.Focus();
    
        }

        private void showLatestID()      
        {
            try
            {
               
                xClass.fillDataGridView(dgvReceivedID, "tblDryWHReceiving_last_id", dSet);
         
  
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void firstLoad()
        {
            mattxtlotno.BackColor = Color.Red;

            DateTime dNow = DateTime.Now;
            this.crV1.Visible = false;
            this.dgvReceivedID.Visible = false;
            this.mattxtreceivingdate.Text = (dNow.ToString("M/d/yyyy"));
            this.dgvMajorCategory.Visible = false;
            this.materialCard2.Visible = false;
            this.materialCard3.Visible = false;
            this.mattxtReceived.Visible = false;
            this.matbtnCancel.Visible = false;
        }

        private void mattxtbarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.scanBarcode();
            }
        }

        private void RMNotExist()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Item Not Exist!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Crimson;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void RMNotExistReceiving()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "No Item for Receiving";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void QCReceiverAlreadyApproved()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Item Already Approved on QC Supervisor for receiving!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }
        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("Po_Receiving_Warehouse_CheckingBinding");

        }

        private void doSearchInTextBoxCmb()
        {
            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {


                        //Gerard Singian Developer Man




                        dv.RowFilter = "item_code = '" + mattxtbarcode.Text + "'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    this.dgvMajorCategory.DataSource = dv;
                    totalRecords = dgvMajorCategory.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found xxx!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }




        }

        private void scanBarcode()
        {

            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                mattxtbarcode.Text, "", "", "", "", "", "", "", "", "", "", "",0, "getdetailsforBulkInsertItemCode");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();
                dSet.Clear();
                dSet = objStorProc.sp_Raw_Materials_Dry(0,
                    mattxtbarcode.Text, "", "", "", "", "", "", "", "", "", "", "",0, "getRMforReceivingDryWH");
                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.SearchMethodJarVarCallingSP();
                    this.doSearchInTextBoxCmb();

                    if(totalRecords == "0")
                    {
                        this.RMNotExistReceiving();
                        this.mattxtbarcode.Text = String.Empty;
                        this.mattxtbarcode.Focus();
                    }
                    else
                    {
                        this.mattxtbarcode.Text = String.Empty;
                        this.ItemFoundforReceiving();
                        this.materialCard2.Visible = true;
                        this.materialCard3.Visible = true;
                        this.mattxtReceived.Visible = true;
                        this.matbtnCancel.Visible = true;

                        //Remove Some Data
                        this.mattxtqtyReceived.Text = String.Empty;
                        this.mattxtlotno.Text = String.Empty;
                        this.mattxtLotDescription.Text = String.Empty;
                        //mattxtqtyreject.Text = String.Empty;
                        this.mattxtqtyreject_TextChanged(new object(), new System.EventArgs());
                    }
                }
                else
                {
                    this.RMNotExistReceiving();
                    this.mattxtbarcode.Text = String.Empty;
                    this.mattxtbarcode.Focus();
                    return;
                }


                }
            else
            {
                this.RMNotExist();
                this.mattxtbarcode.Text = String.Empty;
                this.mattxtbarcode.Focus();
                return;

            }


        }

        private void ItemFoundforReceiving()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "For Receiving '"+mattxtitemdesc.Text+"'";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void dgvMajorCategory_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showValueCell();
        }

        private void showValueCell()
        {
            if (this.dgvMajorCategory.Rows.Count > 0)
            {
                if (this.dgvMajorCategory.CurrentRow != null)
                {
                    if (this.dgvMajorCategory.CurrentRow.Cells["item_code"].Value != null)
                    {
                        this.p_id = Convert.ToInt32(dgvMajorCategory.CurrentRow.Cells["PrimaryID"].Value);
                        this.sp_projection_id = Convert.ToInt32(dgvMajorCategory.CurrentRow.Cells["ProjectID"].Value);
                        this.mattxtitemcode.Text = dgvMajorCategory.CurrentRow.Cells["item_code"].Value.ToString();
                        this.mattxtitemdesc.Text = dgvMajorCategory.CurrentRow.Cells["item_description"].Value.ToString();
                        this.mattxtSupplier.Text = dgvMajorCategory.CurrentRow.Cells["Supplier"].Value.ToString();
                        this.mattxtmfgdate.Text = dgvMajorCategory.CurrentRow.Cells["mfg_date"].Value.ToString();
                        this.mattxtexpirydate.Text = dgvMajorCategory.CurrentRow.Cells["expiration_date"].Value.ToString();
                        this.matdaysExpiry.Text = dgvMajorCategory.CurrentRow.Cells["DaysToExpired"].Value.ToString();
                        this.mattxtcategory.Text = dgvMajorCategory.CurrentRow.Cells["major_category"].Value.ToString();
                        this.mattxtqtyuom.Text = dgvMajorCategory.CurrentRow.Cells["qty_uom"].Value.ToString();
                        this.mattxtponumber.Text = dgvMajorCategory.CurrentRow.Cells["po_number"].Value.ToString();


                        this.mattxtqtyreject.Text = this.dgvMajorCategory.CurrentRow.Cells["totalreject"].Value.ToString();
                        if (this.totalRecords == "1")
                        {
                            this.mattxtsoh.Text = dgvMajorCategory.CurrentRow.Cells["total_received"].Value.ToString();

                            
                        }
                        else
                        {
                            //int sum = 0;
                            //for (int i = 0; i < this.dgvMajorCategory.Rows.Count; ++i)
                            //{
                            //    sum += Convert.ToInt32(this.dgvMajorCategory.Rows[i].Cells["total_received"].Value);
                            //}
                            //this.mattxtsoh.Text = sum.ToString();
                        
                                int sum2 = 0;
                                for (int i = 0; i < this.dgvMajorCategory.Rows.Count; ++i)
                                {
                                    sum2 += Convert.ToInt32(this.dgvMajorCategory.Rows[i].Cells["TOTALRECEIVEDFINAL"].Value);
                                }
                                this.mattxtsoh.Text = sum2.ToString();
                            
                        }
                        this.sp_total_remaining_po = dgvMajorCategory.CurrentRow.Cells["totalremainingpo"].Value.ToString();
                        this.sp_warehouse_reject_approval = dgvMajorCategory.CurrentRow.Cells["WH_Reject_Approval"].Value.ToString();

                        if (this.sp_warehouse_reject_approval == "1")                
                        {
                            this.mattxtactualdelivery.Text = this.dgvMajorCategory.CurrentRow.Cells["WH_Reject_QTY"].Value.ToString();
                            //this.mattxtqtyreject.Text = "0";

                        }
                        else
                        {
                            //MessageBox.Show("0");
                            this.mattxtactualdelivery.Text = this.dgvMajorCategory.CurrentRow.Cells["actual_delivery"].Value.ToString();


                        }
                        if(this.matdaysExpiry.Text == String.Empty)
                        {
                            this.matdaysExpiry.Text = "0";              
                        }
                        //MessageBox.Show(p_id.ToString());
                        //DateTime temp;
                        //temp = Convert.ToDateTime(this.mattxtexpirydate.Text);
                        //this.mattxtexpirydate.Text = temp.ToString("dd/MM/yyyy"); // or "MM/dd/yyyy"
                    }
                }
            }
        }

        private void mattxtqtyReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(mattxtqtyReceived.Text + ch, out x))
            {
                e.Handled = true;
            }



        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectLot_Click(object sender, EventArgs e)
        {
            frmChooseLotNumber showModal = new frmChooseLotNumber(this, mattxtcategory.Text);
            showModal.ShowDialog();


   
        }

        private void mattxtqtyReceived_TextChanged(object sender, EventArgs e)
        {
            //Removing an Entry 
            try
            {


              mattxtupdatedstocks.Text = (float.Parse(mattxtsoh.Text) + float.Parse(mattxtqtyReceived.Text)).ToString();
            }
            catch (Exception)
            {


            }

            if (mattxtqtyReceived.Text == String.Empty)
            {
                try
                {


                    mattxtupdatedstocks.Text = String.Empty;
                }
                catch (Exception)
                {


                }
            }
          
        }

        private void mattxtactualdelivery_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void FillRequiredFields()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Fill up the required fields!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Crimson;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;
            popup.ShowOptionsButton = true;


        }

        public void InvalidQuantity()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Invalid Quantity!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;
            popup.ShowOptionsButton = true;


        }

        private void mattxtReceived_Click(object sender, EventArgs e)
        {

        }

        public void LessThanQtyReceived()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Less Than Qty Received";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        public void InvalidQtyReceived()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Invalid Qty Received";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void mattxtReceived_Click_1(object sender, EventArgs e)
        {

            if (this.mattxtqtyReceived.Text.Trim() == string.Empty)
            {
                this.FillRequiredFields();
      
                return;
            }

            if(this.mattxtqtyReceived.Text == "0")
            {
                this.InvalidQuantity();

                return;
            }

            double orderActual;
            double currentrejectActual;
            double rejecttotal;


            orderActual = double.Parse(mattxtactualdelivery.Text);
            currentrejectActual = double.Parse(mattxtqtyReceived.Text);
            rejecttotal = double.Parse(mattxtqtyreject.Text);

            if (orderActual < currentrejectActual)
            {
                // code

                this.LessThanQtyReceived();
                this.mattxtqtyReceived.Text = String.Empty;
                this.mattxtqtyReceived.Focus();
                return;
            }
            else
            {
                //MessageBox.Show("Bebes");
                //return;
            }


            if (mattxtlotno.Text.Trim() == string.Empty)
            {
                this.FillRequiredFields();
                frmChooseLotNumber LotSelection = new frmChooseLotNumber(this, mattxtcategory.Text);
                LotSelection.ShowDialog();
                return;
            }
            if (mattxtLotDescription.Text.Trim() == string.Empty)
            {
                this.FillRequiredFields();
                frmChooseLotNumber LotSelection = new frmChooseLotNumber(this, mattxtcategory.Text);
                LotSelection.ShowDialog();
                return;
            }


       

            double order;
            double currentreject;
       

            order = double.Parse(mattxtactualdelivery.Text);
            currentreject = double.Parse(mattxtqtyreject.Text);
     

            if (order < currentreject)
            {
                // code
  
                this.LessThanQtyReceived();
                this.btnAddRejetModal_Click(sender, e);
                return;
            }
            else
            {
                //MessageBox.Show("Bebes");
                //return;
            }

            //proceess of repack kupra
            if (currentreject == 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to received ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {




                    //this.SummaryComputation();  11/19/2021
                    this.SummaryComputation(); //Inject 11/25/2021

               

                    //Second Summary of Queryy Disposal of Rejection Remarks
                    this.dSet.Clear();
                    this.dSet = objStorProc.sp_tblDryWHReceiving(0,
                        p_id, mattxtitemcode.Text, mattxtitemdesc.Text, sp_receiving_qty.ToString(), "", sp_added_by, sp_added_by, "", mattxtSupplier.Text,
                        mattxtlotno.Text, mattxtLotDescription.Text, mattxtmfgdate.Text, mattxtexpirydate.Text, mattxtcategory.Text, mattxtqtyuom.Text, mattxtqtyreject.Text, Convert.ToInt32(mattxtponumber.Text), Convert.ToInt32(sp_added_by_userid), "rejected_status_timer_dispossal");

                    //Second Summary of Queryy Disposal of Rejection Remarks RE == QA
                    this.dSet.Clear();
                    this.dSet = objStorProc.sp_tblDryWHReceiving(0,
                        p_id, mattxtitemcode.Text, mattxtitemdesc.Text, sp_receiving_qty.ToString(), "", sp_added_by, sp_added_by, "", mattxtSupplier.Text,
                        mattxtlotno.Text, mattxtLotDescription.Text, mattxtmfgdate.Text, mattxtexpirydate.Text, mattxtcategory.Text, mattxtqtyuom.Text, mattxtqtyreject.Text, Convert.ToInt32(mattxtponumber.Text), Convert.ToInt32(sp_added_by_userid), "rejected_status_wh_re_qa'");


                    //Commit the Data on The Database Stored procedure
                    this.dSet.Clear();
                    this.dSet = objStorProc.sp_tblDryWHReceiving(0,
                        p_id, mattxtitemcode.Text, mattxtitemdesc.Text, sp_receiving_qty.ToString(), "", sp_added_by, sp_added_by, "", mattxtSupplier.Text,
                        mattxtlotno.Text, mattxtLotDescription.Text, mattxtmfgdate.Text, mattxtexpirydate.Text, mattxtcategory.Text, mattxtqtyuom.Text, mattxtqtyreject.Text, Convert.ToInt32(mattxtponumber.Text), Convert.ToInt32(sp_added_by_userid), "add");
                    if (this.sp_warehouse_reject_approval =="1")
                    {

                  
                        this.dSet.Clear();
                        this.dSet = objStorProc.sp_tblDryWHReceiving(0,
                            p_id, mattxtitemcode.Text, mattxtitemdesc.Text, sp_receiving_qty.ToString(), "", sp_added_by, sp_added_by, "", mattxtSupplier.Text,
                            mattxtlotno.Text, mattxtLotDescription.Text, mattxtmfgdate.Text, mattxtexpirydate.Text, mattxtcategory.Text, mattxtqtyuom.Text, mattxtqtyreject.Text, Convert.ToInt32(mattxtponumber.Text), Convert.ToInt32(sp_added_by_userid), "updated_rejected_partial");

                        //Second Summary of Queryy Disposal of Rejection Remarks
                        this.dSet.Clear();
                        this.dSet = objStorProc.sp_tblDryWHReceiving(0,
                            p_id, mattxtitemcode.Text, mattxtitemdesc.Text, sp_receiving_qty.ToString(), "", sp_added_by, sp_added_by, "", mattxtSupplier.Text,
                            mattxtlotno.Text, mattxtLotDescription.Text, mattxtmfgdate.Text, mattxtexpirydate.Text, mattxtcategory.Text, mattxtqtyuom.Text, mattxtqtyreject.Text, Convert.ToInt32(mattxtponumber.Text), Convert.ToInt32(sp_added_by_userid), "rejected_status_timer_dispossal");
                    }

                        this.SaveSuccessfully();
                    this.showLatestID();
                    //this.SummaryComputation();

                    this.PrintingProcess();
                    this.frmDryReceivingModule_Load(sender, e);
                }
                else
                {
                    return;
                }
            }
            else 
            {
                //double qtyReceiving;
                //double rejected;
                //double totalSum;


                //qtyReceiving = double.Parse(mattxtqtyReceived.Text);
                //rejected = double.Parse(mattxtqtyreject.Text);


                //totalSum = qtyReceiving - rejected;
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure " +
                    "you want to received the Qty '"+mattxtqtyreject.Text+"' ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {




                    this.SummaryComputation();
           

                    //Second Summary of Queryy Disposal of Rejection Remarks
                    this.dSet.Clear();
                    this.dSet = objStorProc.sp_tblDryWHReceiving(0,
                        p_id, mattxtitemcode.Text, mattxtitemdesc.Text, sp_receiving_qty.ToString(), "", sp_added_by, sp_added_by, "", mattxtSupplier.Text,
                        mattxtlotno.Text, mattxtLotDescription.Text, mattxtmfgdate.Text, mattxtexpirydate.Text, mattxtcategory.Text, mattxtqtyuom.Text, mattxtqtyreject.Text, Convert.ToInt32(mattxtponumber.Text), Convert.ToInt32(sp_added_by_userid), "rejected_status_timer_dispossal");

                    //Second Summary of Queryy Disposal of Rejection Remarks RE == QA
                    this.dSet.Clear();
                    this.dSet = objStorProc.sp_tblDryWHReceiving(0,
                        p_id, mattxtitemcode.Text, mattxtitemdesc.Text, sp_receiving_qty.ToString(), "", sp_added_by, sp_added_by, "", mattxtSupplier.Text,
                        mattxtlotno.Text, mattxtLotDescription.Text, mattxtmfgdate.Text, mattxtexpirydate.Text, mattxtcategory.Text, mattxtqtyuom.Text, mattxtqtyreject.Text, Convert.ToInt32(mattxtponumber.Text), Convert.ToInt32(sp_added_by_userid), "rejected_status_wh_re_qa'");


                    //Commit Data on The Database Stored Procedure
                    this.dSet.Clear();
                    this.dSet = objStorProc.sp_tblDryWHReceiving(0,
                        p_id, mattxtitemcode.Text, mattxtitemdesc.Text, sp_receiving_qty.ToString(), "", sp_added_by, sp_added_by, "", mattxtSupplier.Text,
                        mattxtlotno.Text, mattxtLotDescription.Text, mattxtmfgdate.Text, mattxtexpirydate.Text, mattxtcategory.Text, mattxtqtyuom.Text, mattxtqtyreject.Text, Convert.ToInt32(mattxtponumber.Text), Convert.ToInt32(sp_added_by_userid), "add");

                    if (this.sp_warehouse_reject_approval == "1")
                    {


                        this.dSet.Clear();
                        this.dSet = objStorProc.sp_tblDryWHReceiving(0,
                            p_id, mattxtitemcode.Text, mattxtitemdesc.Text, sp_receiving_qty.ToString(), "", sp_added_by, sp_added_by, "", mattxtSupplier.Text,
                            mattxtlotno.Text, mattxtLotDescription.Text, mattxtmfgdate.Text, mattxtexpirydate.Text, mattxtcategory.Text, mattxtqtyuom.Text, mattxtqtyreject.Text, Convert.ToInt32(mattxtponumber.Text), Convert.ToInt32(sp_added_by_userid), "updated_rejected_partial");



                    }




                    this.SaveSuccessfully();
                    this.showLatestID();
                    //this.SummaryComputation();

                    this.PrintingProcess();

                    //Update Projects Partial PO Actual Remaining

                    double qtytotalPo;
                    double QtyReject;
                    double qtyReturnSummary;
               

                    qtytotalPo = double.Parse(sp_total_remaining_po);
                    QtyReject = double.Parse(mattxtqtyreject.Text);

                    qtyReturnSummary = qtytotalPo + QtyReject;

                    this.dSet.Clear();
                    this.dSet = objStorProc.sp_tblDryWHReceiving(0,
                        p_id, mattxtitemcode.Text, mattxtitemdesc.Text, qtyReturnSummary.ToString(), "", sp_added_by, sp_added_by, "", mattxtSupplier.Text,
                        mattxtlotno.Text, mattxtLotDescription.Text, mattxtmfgdate.Text, mattxtexpirydate.Text, mattxtcategory.Text, mattxtqtyuom.Text, mattxtqtyreject.Text, Convert.ToInt32(mattxtponumber.Text), Convert.ToInt32(sp_added_by_userid), "rejectComeback");
                    this.frmDryReceivingModule_Load(sender, e);
                }
                else
                {
                    return;
                }
            }
      

        }

        private void SummaryComputation()
        {
            //sp_final_id = (float.Parse(sp_final_id) + 1).ToString();
            double qtyReceiving;
            double rejected;


            qtyReceiving = double.Parse(mattxtactualdelivery.Text);
            rejected = double.Parse(mattxtqtyreject.Text);


            sp_receiving_qty = qtyReceiving - rejected;
        }
        private void PrintingProcess()
        {
            Rpt_Path = ULTRAMAVERICK.Properties.Settings.Default.fdg;



            PrintDialog printDialog = new PrintDialog();
            rpt.Load(Rpt_Path + "\\DryReceivingBarcode.rpt");

            //rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
            //MessageBox.Show(sp_final_id);
            rpt.Refresh();
            myglobal.DATE_REPORT2 = sp_final_id;
            //string mystringid = myglobal.DATE_REPORT2;
            //string mystringid = myglobal.DATE_REPORT2;
            rpt.SetParameterValue("@mystringid", sp_final_id);



            crV1.ReportSource = rpt;
            crV1.Refresh();



            rpt.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;


            rpt.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.ToPage, printDialog.PrinterSettings.ToPage);

        }
        public void SaveSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Successfully Received";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void btnAddRejetModal_Click(object sender, EventArgs e)
        {

            //Notify the User if the Transactioin already approve by QC Superviosr
            if (this.sp_warehouse_reject_approval == "1")
            {
                this.QCReceiverAlreadyApproved();
            }
           
                frmAddNewPartialRejectReceiving showModal = new frmAddNewPartialRejectReceiving(this, mattxtitemdesc.Text, mattxtactualdelivery.Text, p_id, Convert.ToInt32(mattxtponumber.Text), sp_projection_id);
                showModal.ShowDialog();
          
        

    

        }

        private void dgvReceivedID_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvReceivedID.Rows.Count > 0)
            {
                if (dgvReceivedID.CurrentRow != null)
                {
                    if (dgvReceivedID.CurrentRow.Cells["id"].Value != null)
                    {

                        this.sp_final_id = dgvReceivedID.CurrentRow.Cells["id"].Value.ToString();

                    }
                }
            }
        }

        private void mattxtqtyreject_TextChanged(object sender, EventArgs e)
        {
            try
            {


                this.mattxtupdatedstocks.Text = (float.Parse(mattxtsoh.Text) + float.Parse(mattxtqtyReceived.Text)).ToString();
            }
            catch (Exception)
            {


            }
            try
            {


                this.mattxtqtyReceived.Text = (float.Parse(mattxtactualdelivery.Text) - float.Parse(mattxtqtyreject.Text)).ToString();
            }
            catch (Exception)
            {


            }


            if (mattxtqtyReceived.Text == String.Empty)
            {
                try
                {


                    this.mattxtupdatedstocks.Text = String.Empty;
                }
                catch (Exception)
                {


                }
            }




        }

       
    }
}